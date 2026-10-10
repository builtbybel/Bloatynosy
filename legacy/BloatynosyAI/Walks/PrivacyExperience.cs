using Microsoft.Win32;
using BloatynosyAI;
using System;
using System.Drawing;

namespace Walks
{
    public class PrivacyExperience : WalksBase
    {
        public PrivacyExperience(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\OOBE";
        private const int desiredValue = 1;

        public override string ID() => "Privacy Settings Experience at sign-in";

        public override bool Check()
        {
            return !Utils.IntEquals(keyName, "DisablePrivacyExperience", desiredValue);
        }

        public override bool Enable()
        {
            try
            {
                Registry.SetValue(keyName, "DisablePrivacyExperience", 1, Microsoft.Win32.RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, "DisablePrivacyExperience", 0, Microsoft.Win32.RegistryValueKind.DWord);

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