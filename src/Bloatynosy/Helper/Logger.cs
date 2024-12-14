using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BloatynosyNue
{
    public class Logger
    {
        private readonly RichTextBox defaultRtbLog;
        private static LoggerForm loggerFormInstance;
        private static readonly List<(string Message, Color Color)> logBuffer = new List<(string, Color)>();

        // Constructor with optional RichTextBox
        public Logger(RichTextBox rtbLog = null) => defaultRtbLog = rtbLog;

        // Open the LoggerForm and load buffered logs
        public static void OpenLoggerForm()
        {
            if (loggerFormInstance == null || loggerFormInstance.IsDisposed)
            {
                loggerFormInstance = new LoggerForm();
                loggerFormInstance.Show();

                // Load buffered logs
                logBuffer.ForEach(log => loggerFormInstance.AddLog(log.Message, log.Color));
              //  logBuffer.Clear(); // Clear buffer after displaying
            }
            else
            {
                loggerFormInstance.BringToFront();
            }
        }

        // Log a message with color and timestamp
        public void Log(string message, Color color)
        {
            string timestampedMessage = $"{DateTime.Now:HH:mm:ss} - {message}";

            // Log to the default RichTextBox if it's available and the handle is created
            if (defaultRtbLog != null && defaultRtbLog.IsHandleCreated)
            {
                defaultRtbLog.BeginInvoke(new Action(() =>
                {
                    defaultRtbLog.SelectionColor = color;
                    defaultRtbLog.AppendText(timestampedMessage + Environment.NewLine);
                    defaultRtbLog.ScrollToCaret();
                }));
            }

            // Buffer the log for future display in LoggerForm
            logBuffer.Add((timestampedMessage, color));

            // Log to LoggerForm if it's open and the handle is created
            if (loggerFormInstance != null && loggerFormInstance.IsHandleCreated && !loggerFormInstance.IsDisposed)
            {
                loggerFormInstance.BeginInvoke(new Action(() => loggerFormInstance.AddLog(timestampedMessage, color)));
            }
        }

    }
}
