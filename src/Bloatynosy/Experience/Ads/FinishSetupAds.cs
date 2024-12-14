using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;

namespace Settings.Ads
{
    public class FinishSetupAds : FeatureBase
    {
        public FinishSetupAds(Logger logger) : base(logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\UserProfileEngagement";
        private const string valueName = "ScoobeSystemSettingEnabled";
        private const int desiredValue = 0;

        public override string ID()
        { return BloatynosyNue.Locales.Strings._adsFinishSetupAds; }

        public override string Info()
        { return BloatynosyNue.Locales.Strings._adsFinishSetupAds_desc; }

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, valueName, 0);
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