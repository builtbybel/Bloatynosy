using Microsoft.Win32;
using BloatynosyAI;
using System;
using System.Drawing;

namespace Walks
{
    public class VisualFX: WalksBase
    {
        public VisualFX(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\VisualEffects";
        private const int desiredValue = 2;

        public override string ID() => "VisualFX";
      

        public override bool Check()
        {
            return Utils.IntEquals(keyName, "VisualFXSetting", desiredValue);
        }

        public override bool Enable()
        {
            try
            {
                Registry.SetValue(keyName, "VisualFXSetting", 2, RegistryValueKind.DWord);

                return true;
            }
            catch (Exception ex)
            {
                logger.Log("Code red in " + ex.Message, Color.Red);
            }

            return false;
        }

        public override bool Disable()
        {
            try
            {
                Registry.SetValue(keyName, "VisualFXSetting", 0, RegistryValueKind.DWord);

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