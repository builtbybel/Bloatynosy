using Microsoft.Win32;
using BloatynosyAI;
using System;
using System.Drawing;

namespace Walks
{
    public class VerboseMessages : WalksBase
    {
        public VerboseMessages(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System";
        private const int desiredValue = 0;

        public override string ID() => "Display highly detailed status messages";

        public override bool Check()
        {
            return !Utils.IntEquals(keyName, "verbosestatus", desiredValue);
        }

        public override bool Enable()
        {
            try
            {
                Registry.SetValue(keyName, "verbosestatus", 1, RegistryValueKind.DWord);

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
                Registry.SetValue(keyName, "verbosestatus", desiredValue, Microsoft.Win32.RegistryValueKind.DWord);

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