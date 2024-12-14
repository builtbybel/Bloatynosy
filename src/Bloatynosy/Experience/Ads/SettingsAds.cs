using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Settings.Ads
{
    internal class SettingsAds : FeatureBase
    {
        public SettingsAds(Logger logger) : base(logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const string valueName = "SubscribedContent-338393Enabled";
        private const string valueName2 = "SubscribedContent-353694Enabled";
        private const string valueName3 = "SubscribedContent-353696Enabled";

        private const int desiredValue = 0;

        public override string ID()  { return BloatynosyNue.Locales.Strings._adsSettingsAds; }

        public override string Info() { return BloatynosyNue.Locales.Strings._adsSettingsAds_desc; }

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} + {valueName2} + {valueName3} | Desired Value: {desiredValue}";
        }

        public override bool CheckFeature()
        {
            return (Utils.IntEquals(keyName, valueName, desiredValue) &&
                   Utils.IntEquals(keyName, valueName2, desiredValue) &&
                   Utils.IntEquals(keyName, valueName3, desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName2, 0, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName3, 0, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, valueName2, 1, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName3, 1, Microsoft.Win32.RegistryValueKind.DWord);

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