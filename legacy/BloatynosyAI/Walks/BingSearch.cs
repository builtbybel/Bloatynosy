using Microsoft.Win32;
using BloatynosyAI;
using System;
using System.Drawing;

namespace Walks
{
    internal class BingSearch : WalksBase
    {
        public BingSearch(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Bing Cloud content search";
        }

        public override bool Check()
        {
            return !(
                   Utils.IntEquals(keyName, "DisableSearchBoxSuggestions", desiredValue)
             );
        }

        public override bool Enable()
        {
            try
            {
                Registry.SetValue(keyName, "DisableSearchBoxSuggestions", 1, RegistryValueKind.DWord);
                return true;
            }
            catch (Exception ex)
            {
                logger.Log("Code red in " + ex.Message, Color.Red);
            }

            return false;
        }

        public override bool Disable()
        {
            try
            {
                Registry.SetValue(keyName, "DisableSearchBoxSuggestions", desiredValue, RegistryValueKind.DWord);

                return true;
            }
            catch (Exception ex)
            {
                logger.Log("Code red in " + ex.Message, Color.Red);
            }

            return false;
        }
    }
}