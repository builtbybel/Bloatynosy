using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BloatynosyAI
{
    public class Logger
    {
        private WebView2 webView;

        public Logger(WebView2 webView)
        {
            if (webView == null)
            {
                // Handle the case where webView is null (e.g., log an error)
                return;
            }

            this.webView = webView;
        }

        // Log method for a single string
        public void Log(string message, Color color)
        {
            if (webView.InvokeRequired)
            {
                webView.Invoke(new Action(() => Log(message, color)));
                return;
            }

            LogToWebView(message, color);
        }

        // Helper method to add log entry to WebView2
        private async void LogToWebView(string message, Color color)
        {
            // Clear log container before adding a new log
            await webView.ExecuteScriptAsync("document.getElementById('logContainer').innerHTML = '';");

            string formattedMessage = $"<div style='color:{ColorToHex(color)}'>{message}</div>";
            webView.CoreWebView2.PostWebMessageAsString(formattedMessage);

            // Some JS to append formatted message to logContainer
            await webView.ExecuteScriptAsync($"document.getElementById('logContainer').innerHTML += '{formattedMessage}';");

            // Ensure log container is visible
            await webView.ExecuteScriptAsync("document.getElementById('logContainer').style.display = 'block';");

            // Scroll down after adding new content to logContainer
            await webView.ExecuteScriptAsync("scrollToBottom();");
        }

        // Some Helpers to convert Color to hexadecimal
        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }
    }
}