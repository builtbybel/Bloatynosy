using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Settings.Gaming
{
    internal class GameDVR : FeatureBase
    {
        public GameDVR(Logger logger) : base(logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\System\GameConfigStore";

        // 0 = Enabled, 2 = Disabled
        private const string keyName2 = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\PolicyManager\default\ApplicationManagement\AllowGameDVR";

        private const string valueName = "GameDVR_Enabled";
        private const string valueName2 = "GameDVR_FSEBehaviorMode";
        private const string valueName3 = "value";

        public override string GetRegistryKey()
        {
            return $"{keyName} |Value: {valueName} | {valueName2} | {keyName2} | {valueName3} ";
        }

        public override string ID()
        {
            return BloatynosyNue.Locales.Strings._gamingGameDVR;
        }

        public override string Info()
        {
            return BloatynosyNue.Locales.Strings._gamingGameDVR_desc;
        }

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, valueName, 0) &&
                       Utils.IntEquals(keyName, valueName2, 2) &&
                       Utils.IntEquals(keyName2, valueName3, 0);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 0, RegistryValueKind.DWord);
                Registry.SetValue(keyName, valueName2, 2, RegistryValueKind.DWord);
                Registry.SetValue(keyName2, valueName3, 0, RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, valueName2, 0, RegistryValueKind.DWord);
                Registry.SetValue(keyName2, valueName3, 1, RegistryValueKind.DWord);

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