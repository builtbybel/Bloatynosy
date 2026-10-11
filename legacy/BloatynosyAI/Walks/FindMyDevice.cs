using Microsoft.Win32;
using BloatynosyAI;
using System;
using System.Drawing;

namespace Walks
{
    internal class FindMyDevice : WalksBase
    {
        public FindMyDevice(MainForm form, Logger logger) : base(form, logger)
        {
        }

        private const string keyName = @"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\location";
        private const string desiredValue = @"Deny";

        public override string ID()
        {
            return "Find my device";
        }

        public override bool Check()
        {
            return !(
                  Utils.StringEquals(keyName, "Value", desiredValue)
            );
        }

        public override bool Enable()
        {
            try
            {
                Registry.SetValue(keyName, "Value", "Allow", RegistryValueKind.String);
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
                Registry.SetValue(keyName, "Value", desiredValue, RegistryValueKind.String);

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