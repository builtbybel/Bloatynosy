using BloatynosyNue;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Settings.Gaming
{
    internal class VisualFX: FeatureBase
    {
        public VisualFX(Logger logger) : base(logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects";
        private const string valueName = "VisualFXSetting";
        private const int desiredValue = 2;

        public override string GetRegistryKey()
        {
            return $"{keyName} | Value: {valueName} | Desired Value: {desiredValue}";
        }

        public override string ID()
        {
            return BloatynosyNue.Locales.Strings._gamingVisualFX;
        }

        public override string Info()
        {
            return BloatynosyNue.Locales.Strings._gamingVisualFX_desc;
        }

        public override bool CheckFeature()
        {
            return Utils.IntEquals(keyName, valueName, 0);
        }

        public override bool DoFeature()
        {
            try
            {
                Registry.SetValue(keyName, valueName,0, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, valueName, 2, Microsoft.Win32.RegistryValueKind.DWord);

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