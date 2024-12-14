using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Settings.Gaming
{
    internal class PowerThrottling : FeatureBase
    {
        public PowerThrottling(Logger logger) : base(logger)
        {
        }

        private const string keyName = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Power\PowerThrottling";
        private const string valueName = "PowerThrottlingOff";
        private const int desiredValue = 1;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return BloatynosyNue.Locales.Strings._gamingPowerThrottling;
        }

        public override string Info()
        {
            return BloatynosyNue.Locales.Strings._gamingPowerThrottling_desc;
        }

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, valueName, desiredValue);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, desiredValue, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, valueName, 0, Microsoft.Win32.RegistryValueKind.DWord);

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