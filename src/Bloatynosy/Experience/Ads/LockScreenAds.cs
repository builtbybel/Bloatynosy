using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Settings.Ads
{
    internal class LockScreenAds : FeatureBase
    {
        public LockScreenAds(Logger logger) : base(logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const string valueName = "RotatingLockScreenOverlayEnabled";
        private const string valueName2 = "SubscribedContent-338387Enabled";
        private const int desiredValue = 0;

        public override string ID() { return BloatynosyNue.Locales.Strings._adsLockScreenAds; }

        public override string Info() {  return BloatynosyNue.Locales.Strings._adsLockScreenAds_desc; }

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override bool CheckFeature()
        {
            return (Utils.IntEquals(keyName, valueName, desiredValue) &&
                   Utils.IntEquals(keyName, valueName2, desiredValue)
            );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, Microsoft.Win32.RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName2, 0, Microsoft.Win32.RegistryValueKind.DWord);

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