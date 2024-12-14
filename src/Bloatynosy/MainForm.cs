using BloatynosyNue.Views;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Views;

namespace BloatynosyNue
{
    public partial class MainForm : Form
    {
        private ExperienceView experienceView;
        private AppsView appsView;
        private PluginsView pluginsView;
        private Logger logger;

        public MainForm()
        {
            InitializeComponent();
            // Uncomment lower line and add lang code to run localization test
            // Thread.CurrentThread.CurrentUICulture = new CultureInfo("it");

            InitializeLogger();
            InitializeLocalizedStrings();

            SwitchView.DefaultView = panelForm.Controls[0];

            btnAboutApp.Text = "\uED54"; // Set the feedback icon
            btnLogger.Text = "\uE8BD"; // Set the logger icon
            btnPlugins.Text = "\uEA86"; // Set the plugins icon
            this.Size = new Size(900, 700); // Set the default form size
        }

        private void InitializeLogger()
        {
            logger = new Logger();

            // Init logs
            logger.Log($"Application started at: {DateTime.Now}", Color.Gray);
            string appVersion = Program.GetAppVersion();
            logger.Log($"Application version: {appVersion}", Color.Gray);
            logger.Log($"OS Version: {Environment.OSVersion}", Color.Gray);
            logger.Log($"Machine Name: {Environment.MachineName}", Color.Gray);
            logger.Log($"User: {Environment.UserName}", Color.Gray);

            bool pluginReady = IsPluginEnvironmentReady();
            logger.Log(pluginReady ? "Plugin environment is ready." : "Plugin environment is not ready.", pluginReady ? Color.Green : Color.Red);

            // Add additional info
            logger.Log("Follow this app on GitHub: https://github.com/builtbybel/Bloatynosy", Color.Magenta);
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            lblHeader.Text = Locales.Strings.ctl_lblHeader;
            lblSubHeader.Text = Locales.Strings.ctl_lblSubHeader;
            lblSteps.Text = Locales.Strings.ctl_lblSteps;
            btnExperience.Text = Locales.Strings.ctl_btnExperience;
            btnDumputer.Text = Locales.Strings.ctl_btnDumputer;
            toolTip.SetToolTip(btnExperience, Locales.Strings.tt_btnExperience);
            toolTip.SetToolTip(btnDumputer, Locales.Strings.tt_btnDumputer);

            toolTip.SetToolTip(btnPlugins, Locales.Strings.tt_btnPlugins);
            toolTip.SetToolTip(btnLogger, Locales.Strings.tt_btnLogger);
            toolTip.SetToolTip(btnAboutApp, Locales.Strings.tt_btnAboutApp);
        }

        private bool IsPluginEnvironmentReady() =>
                 Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins")) &&
                 File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Newtonsoft.Json.dll"));

        private void btnExperience_Click(object sender, EventArgs e)
        {
            if (experienceView == null)
            {
                experienceView = new ExperienceView();
            }
            SwitchView.SetView(experienceView, panelForm);
        }

        private void btnDumputer_Click(object sender, EventArgs e)
        {
            if (appsView == null)
            {
                appsView = new AppsView();
            }
            SwitchView.SetView(appsView, panelForm);
        }

        private void btnPlugins_Click(object sender, EventArgs e)
        {
            var pluginsView = new PluginsView(panelForm);
            SwitchView.DefaultView = pluginsView;
            SwitchView.SetView(pluginsView, panelForm);
        }

        private void btnAboutApp_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void btnLogger_Click(object sender, EventArgs e)
        {
            Logger.OpenLoggerForm();
        }
    }
}