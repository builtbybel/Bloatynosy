using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using BloatynosyAI;

namespace Interop
{
    public class ClippyConversationHandler : InteropBase
    {
        private readonly Random random = new Random();
        private readonly List<string> clippySayings;
        private readonly List<string> aiSayings;

        public ClippyConversationHandler(MainForm form, Logger logger) : base(form, logger)
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app\\clippySayings.json");
            string jsonContent = File.ReadAllText(jsonFilePath);
            var jsonData = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonContent);
            clippySayings = jsonData["clippySayings"];
            aiSayings = jsonData["aiSayings"];
        }

        // Clippy's supreme tips
        public override void Execute()
        {
            int index = random.Next(clippySayings.Count);
            string saying = clippySayings[index];

            Logger.Log($"Clippy says: {saying}", Color.Black);
        }

        public void ShowAISayings()
        {
            int index = random.Next(aiSayings.Count);
            string saying = aiSayings[index];

            _form.WebView.CoreWebView2.ExecuteScriptAsync($"document.getElementById('logContainer').innerText = '{saying}';");
        }
    }
}
