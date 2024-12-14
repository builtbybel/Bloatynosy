using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;

namespace Settings.AI
{
    internal class RecallMachine : FeatureBase
    {
        public RecallMachine(Logger logger) : base(logger)
        {
        }


        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\WindowsAI";
        private const string valueName = "DisableAIDataAnalysis";
        private const int desiredValue = 0;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return BloatynosyNue.Locales.Strings._aiRecallMachine;
        }

        public override string Info()
        {
            return BloatynosyNue.Locales.Strings._aiRecallMachine_desc;
        }

        public override bool CheckFeature()
        {
            // Check if reg key exists
            object value = Registry.GetValue(keyName, valueName, null);
            if (value == null)
            {
                // Key does not exist, turn off feature
                return false;
            }

            // Key exists, check if value is desired value
            return (int)value != desiredValue;
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName, 1, Microsoft.Win32.RegistryValueKind.DWord);
                logger.Log("You've even disabled system-wide Snapshots for all users now.", Color.Green);
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
                Registry.SetValue(keyName, valueName, desiredValue, Microsoft.Win32.RegistryValueKind.DWord);
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