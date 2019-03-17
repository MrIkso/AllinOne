using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using AllInOne.Logic;

namespace AllInOne.Forms
{
    public partial class AsmToHexArmForm : Form
    {
        public AsmToHexArmForm()
        {
            InitializeComponent();
            Text = Language.tools_ams_to_hex;
            clearBtn.Text = Language.clearButtonText;
            convert_btn.Text = Language.tools_ams_to_hex_convert_btn;
            resultGBox.Text = Language.tools_ams_to_hex_result;
        }
        private void convert_Click(object sender, EventArgs e)
        {
            var outpotly = "";
            var instructionText = pseudocodeTbox.Text;
            if (string.IsNullOrEmpty(instructionText))
            {
                tips.Text = "Please input Opcode";
                return;
            }
            tips.Text = "";
            var compeler = new ProcessStartInfo();
            var processStartInfo = compeler;
            processStartInfo.FileName = Program.pathToMyPluginDir + "\\tools\\as.exe";
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.CreateNoWindow = true;
            var streamWriter = new StreamWriter("tmp");
            streamWriter.Write(instructionText);
            streamWriter.Close();
            tips.Text = "Working hard";
            try
            {
                compeler.Arguments = "-mthumb tmp -al";
                var outText = Process.Start(compeler);
                var process = outText;
                if (process != null && !process.HasExited)
                {
                    outpotly = process.StandardOutput.ReadToEnd();
                }
                if (string.Equals(outpotly.Substring(38, 4), "    "))
                {
                    tips.Text = "Please input correct opcode";
                    return;
                }
                thumbTBox.Text = outpotly.Substring(38, 4);
                compeler.Arguments = "tmp -al";
                outText = Process.Start(compeler);
                process = outText;
                if (process != null && !process.HasExited)
                {
                    outpotly = process.StandardOutput.ReadToEnd();
                }
                ArmTbox.Text = outpotly.Substring(38, 8);
            }
            catch (Exception)
            {
                // ignored
                tips.Text = "Convert Expcetion";
                File.Delete("tmp");
                return;
            }
            tips.Text = "Complete";
            File.Delete("tmp");
        }

        private void AsmToHexArm_Load(object sender, EventArgs e)
        {
            tips.Text = "";
            if (!File.Exists(Program.pathToMyPluginDir + "\\tools\\as.exe"))
            {
                tips.Text = "Error! Not Found as.exe in tools!";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            thumbTBox.Text = "";
            ArmTbox.Text = "";
            pseudocodeTbox.Text = "";
            File.Delete(Program.pathToMyPluginDir + "\\a.out");
        }

        private void AsmToHexArm_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.Delete(Program.pathToMyPluginDir + "\\a.out");
        }
    }
}
