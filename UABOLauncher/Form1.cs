using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UABOLauncher
{
    public partial class Form1 : Form
    {
        const string jreExe = @"C:\Program Files (x86)\Java\jre6\bin\javaw.exe";
        const string baseBOUrl = "";
        public Form1()
        {
            InitializeComponent();
            LoadSettings();
        }
        private void StartBO()
        {
            if (string.IsNullOrEmpty(storeNumber.Text) || string.IsNullOrEmpty(countryCode.Text))
                return;
            if (!int.TryParse(storeNumber.Text, out _))
            {
                MessageBox.Show("Please enter a valid store number");
                return;
            }
            if (countryCode.Text.Length != 2)
            {
                MessageBox.Show("Please enter a valid country code (i.e. DK,UA,UK etc)");
                return;
            }
            launchButton.Text = "Launching...";
            var jnlpFile = $@"{baseBOUrl}{storeNumber.Text.PadLeft(4, '0')}-{countryCode.Text}:8096/jnlp/boclient.jnlp";

            var argumentsList = new string[] {
                @" -Xbootclasspath/a:""C:\Program Files (x86)\Java\jre6\lib\javaws.jar"";""C:\Program Files (x86)\Java\jre6\lib\deploy.jar"";""C:\Program Files (x86)\Java\jre6\lib\plugin.jar""",
                "-classpath",
                 @"""C:\Program Files (x86)\Java\jre6\lib\deploy.jar""",
                 @"-Djava.security.policy=file:""C:\Program Files (x86)\Java\jre6\lib\security\javaws.policy""",
                 "-DtrustProxy=true",
                 "-Xverify:remote",
                 @"-Djnlpx.home=""C:\Program Files (x86)\Java\jre6\Bin""",
                 "-Dsun.awt.warmup=true",
                 "-Djnlpx.origFilenameArg=$jnlpFile",
                 "-Djnlpx.remove=true",
                 "-ea",
                 "-Xmx512m",
                 "-Djnlpx.heapsize=NULL,512m",
                 "-Djnlpx.splashport=50057",
                 @"-Djnlpx.jvm=""C:\Program Files (x86)\Java\jre6\bin\javaw.exe""",
                 "-Djnlpx.vmargs=-ea com.sun.javaws.Main",
                 jnlpFile
            };
            _ = Process.Start(jreExe, string.Join(" ", argumentsList));
            if (closeAfterLaunch.Checked)
                Application.Exit();
            //wait for 5 seconds before changing the button text
            Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
                launchButton.Text = "Launch BO";
            });
        }
        private void LoadSettings()
        {
            var settingsFile = Path.GetTempPath() + "settings.txt";
            if (File.Exists(settingsFile))
            {
                var settings = File.ReadAllLines(settingsFile);
                if (settings.Length == 2)
                {
                    countryCode.Text = settings[0];
                    closeAfterLaunch.Checked = bool.Parse(settings[1]);
                }
            }
        }
        private void SaveSettings()
        {
            var settingsFile = Path.GetTempPath() + "settings.txt";
            File.WriteAllLines(settingsFile, new string[] { countryCode.Text, closeAfterLaunch.Checked.ToString() });
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void closeAfterLaunch_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void storeNumber_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartBO();
            }
        }

        private void launchBO_Click(object sender, EventArgs e)
        {
            StartBO();
        }
    }
}
