using BloatynosyNue.Views;
using System.Collections.Generic;
using System.Drawing;
using System;

public class Logger
{
    private static LoggerView loggerViewInstance;
    private static readonly List<(string Message, Color Color)> logBuffer = new List<(string, Color)>();

    // Set the LoggerView instance dynamically
    public static void SetLoggerView(LoggerView loggerView)
    {
        if (loggerView == null)
        {
            throw new ArgumentNullException(nameof(loggerView), "LoggerView cannot be null.");
        }

        loggerViewInstance = loggerView;

        // If there were logs buffered before the view was set, flush them now
        foreach (var log in logBuffer)
        {
            loggerViewInstance.AddLog(log.Message, log.Color);
        }

        // Clear the buffer after flushing
        logBuffer.Clear();
    }

    // Log a message with color and timestamp
    public void Log(string message, Color color)
    {
        string timestampedMessage = $"{DateTime.Now:HH:mm:ss} - {message}";

        // Log to the LoggerView if it's open
        if (loggerViewInstance != null)
        {
            loggerViewInstance.AddLog(timestampedMessage, color);
        }
        else
        {
            // If LoggerView isn't open, buffer the log for future display
            logBuffer.Add((timestampedMessage, color));
        }
    }
}
