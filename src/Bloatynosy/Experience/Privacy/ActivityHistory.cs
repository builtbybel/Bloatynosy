using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Settings.Privacy
{
    internal class ActivityHistory : FeatureBase
    {
        public ActivityHistory(Logger logger) : base(logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy";
        private const string valueName = "ActivityHistoryEnabled";
        private const int desiredValue = 0;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return BloatynosyNue.Locales.Strings._privacyActivityHistory;
        }

        public override string Info()
        {
            return BloatynosyNue.Locales.Strings._privacyActivityHistory_desc;
        }

        public override bool CheckFeature()
        {
            return (
               Utils.IntEquals(keyName, valueName, desiredValue)
         );
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, RegistryValueKind.DWord);
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
                Registry.SetValue(keyName, valueName, 1, RegistryValueKind.DWord);

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