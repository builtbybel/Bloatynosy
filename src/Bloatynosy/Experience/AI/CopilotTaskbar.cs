using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Settings.AI
{
    internal class CopilotTaskbar : FeatureBase
    {
        public CopilotTaskbar(Logger logger) : base(logger)
        {
        }


        private const string keyName = @"HKEY_CURRENT_USER\Software\Policies\Microsoft\Windows\WindowsCopilot";
        private const string valueName = "TurnOffWindowsCopilot";
        private const int desiredValue = 1;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return  BloatynosyNue.Locales.Strings._aiCopilotTaskbar; 
        }

        public override string Info()
        {
            return BloatynosyNue.Locales.Strings._aiCopilotTaskbar_desc;
        }

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, valueName, 1);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, desiredValue, RegistryValueKind.DWord);
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
                Registry.SetValue(keyName, valueName, 0, RegistryValueKind.DWord);
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