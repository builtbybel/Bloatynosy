using System.Drawing;
using System.Windows.Forms;

namespace Bloatynosy
{
    public class FAQManager
    {
        public static void InitializeFAQ(Panel panelFAQ)
        {
            panelFAQ.BackColor = Color.FromArgb(44, 44, 44);
            panelFAQ.ForeColor = Color.White;

            // Create a FlowLayoutPanel to arrange the buttons and answer panels
            var flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false, // Prevent controls from wrapping to the next line
                BackColor = Color.FromArgb(44, 44, 44),
            };

            // Array of FAQ
            var questionsAndAnswers = new (string Question, string Answer)[]
            {
                ("Is the app free?",
                 "Yes! The app is completely free and open-source. It's the most powerful, and most well-known debloater for Microsoft Windows."),

                ("Which OS versions are supported?",
                 "Bloatynosy supports all versions of Windows 11. The 'Dumputer' debloater module is also fully compatible with Windows 10. The 'Experience' module partially supports Windows 10. Third-party plugins are OS-specific but fully support Windows 11 and may support Windows 10 as well. For more details, please refer to the respective developers on GitHub."),

                ("Can I use this app without any concerns?",
                 "The app has hundreds of hours of development and testing behind it, and I’ve never managed to break my system with it. That said, always be cautious on production systems and pay attention to what apps you’re uninstalling. Important system apps can’t be removed, so no worries there. Just make sure you don’t accidentally remove something you need — and always back up if you’re unsure!"),

                ("How can I support the project?",
                 "Yes! You can contribute on GitHub as a developer, or you can buy Belim, the main developer, a coffee! You’ll find the donation button in the settings of the app."),

                ("Does the app use AI?",
                 "Yes! The Debloater module uses an AI-enhanced database to provide optimal functionality. This feature requires the 'AppMatrix' plugin, which you can download from the store. Otherwise, the app is a highly sophisticated tool with powerful debloating mechanisms."),

                 ("Does Microsoft hate this app?",
                 "Kind of! The app was once published in the Microsoft Store but was unexpectedly removed due to a missing certificate. The exact reason was never disclosed, and it hasn’t been re-published since. Fun fact: even some Microsoft employees have reportedly been spotted using this debloater. 😉\r\n\r\nThat said, the app doesn’t do anything you couldn’t achieve using Microsoft's own tools: uninstalling apps with PowerShell and tweaking registry values via the Settings app."),

                ("Is this the best app in the world?",
                 "Probably! It's almost as good as the most popular social platform, but with a much better name. 😉")
            };

            // Iterate through all question-answer pairs
            foreach (var qa in questionsAndAnswers)
            {
                // Create a button for the question
                var questionButton = new Button
                {
                    Text = qa.Question,
                    //Width = 400,
                    //Height = 50,
                    AutoSize = true,
                    AutoEllipsis = true,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(61, 61, 61),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 5, 10, 0), // Padding inside the button
                    Margin = new Padding(35, 10, 20, 0) // Margin between buttons
                };

                // Apply custom border style to this specific question
                if (qa.Question == "Which OS versions are supported?")
                {
                    questionButton.FlatAppearance.BorderColor = Color.Gold;
                    questionButton.FlatAppearance.BorderSize = 2;
                }

                // Create a panel for the answer
                var answerPanel = new Panel
                {
                    AutoSize = true,
                    BackColor = Color.FromArgb(40, 40, 40),
                    BorderStyle = BorderStyle.FixedSingle,
                    Visible = false, // Initially hidden
                    Margin = new Padding(20, 10, 10, 10) // Margin below the answer panel
                };

                // Create a label for the answer text
                var answerLabel = new Label
                {
                    Text = qa.Answer,
                    AutoSize = true,
                    MaximumSize = new Size(380, 0), // Set a maximum width to wrap text
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    ForeColor = Color.White,
                    Padding = new Padding(10) // Padding inside the label
                };

                // Add the answer label to the answer panel
                answerPanel.Controls.Add(answerLabel);

                // Handle the button click event to toggle the visibility of the answer panel
                questionButton.Click += (sender, e) =>
                {
                    answerPanel.Visible = !answerPanel.Visible;
                };

                // Add the question button and the answer panel to the FlowLayoutPanel
                flowPanel.Controls.Add(questionButton);
                flowPanel.Controls.Add(answerPanel);
            }

            // Add the FlowLayoutPanel to the main panel (panelFAQ)
            panelFAQ.Controls.Add(flowPanel);
        }
    }
}