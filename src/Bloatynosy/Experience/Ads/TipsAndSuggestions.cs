using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Settings.Ads
{
    internal class TipsAndSuggestions : FeatureBase
    {
        public TipsAndSuggestions(Logger logger) : base(logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const string valueName = "SubscribedContent-338389Enabled";
        private const int desiredValue = 0;

        public override string ID()
        { return BloatynosyNue.Locales.Strings._adsTipsAndSuggestions; }

        public override string Info()
        { return BloatynosyNue.Locales.Strings._adsTipsAndSuggestions_desc; }

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override bool CheckFeature()
        {
            return (Utils.IntEquals(keyName, valueName, desiredValue)
                 );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, Microsoft.Win32.RegistryValueKind.DWord);

                return true;
            }
            catch (Exception ex)
            {
                logger.Log("Code red in " + ex.Message, Color.Red);
            }

            return false;
        }

        public override bool UndoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 1, Microsoft.Win32.RegistryValueKind.DWord);

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