using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AllInOne.Logic;

namespace AllInOne.Forms
{
    public partial class CheckProtectForm : Form
    {
        string patch = Program.processApkPath;

        public CheckProtectForm()
        {
            InitializeComponent();
            Text = Language.tools_check_protect;
            checkBtn.Text = Language.tools_check_protect_btn;
            packerGB.Text = Language.tools_check_protect_packer;
            engineGB.Text = Language.tools_check_protect_engine;
            //при открытии формы, проверка не будет производится
           // checkProtect(patch);
        }

        public void checkProtect(string str)
        {
            if (Directory.Exists(str + "\\assets\\"))
            {
                string[] assets = Directory.GetFiles(str + "\\assets", "*", SearchOption.AllDirectories);
                foreach (string file in assets)
                {
                    if (file.Contains("dp.arm.so.dat") || file.Contains("dp.arm-v7.so.dat") || file.Contains("dp.arm-v7.so.dat") || file.Contains("dp.arm-v8.so.dat") || file.Contains("dp.x86.so.dat") || file.Contains("dp.x86_64.so.dat"))
                    {
                        dexprotectorCheckCB.Checked = true;
                        dexprotectorCheckCB.CheckState = CheckState.Checked;
                        dexprotectorCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("dp.arm-v7.art.kk.so") || file.Contains("dp.arm-v7.art.l.so") || file.Contains("dp.arm-v7.dvm.so")
                     || file.Contains("dp.arm.art.kk.so") || file.Contains("dp.arm.art.l.so") || file.Contains("dp.arm.dvm.so") || file.Contains("dp.x86.art.kk.so") || file.Contains("dp.x86.art.l.so") || file.Contains("dp.x86.dvm.so"))
                    {
                        dexprotect_aCheckCB.Checked = true;
                        dexprotect_aCheckCB.CheckState = CheckState.Checked;
                        dexprotect_aCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("secData0.jar"))
                    {
                        bangcle_secshellCheckCB.Checked = true;
                        bangcle_secshellCheckCB.CheckState = CheckState.Checked;
                        bangcle_secshellCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("ijiami.dat"))
                    {
                        ijiamiCheckCB.Checked = true;
                        ijiamiCheckCB.CheckState = CheckState.Checked;
                        ijiamiCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libsecenh.so") || file.Contains("libsecenh_x86.so") || file.Contains("respatcher.jar"))
                    {
                        secenhCB.Checked = true;
                        secenhCB.CheckState = CheckState.Checked;
                        secenhCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libjiagu.so") || file.Contains("libjiagu_x86.so"))
                    {
                        jiaguCheckCB.Checked = true;
                        jiaguCheckCB.CheckState = CheckState.Checked;
                        jiaguCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("jiami.dat") || file.Contains("libdexload_a64.so") || file.Contains("libdexload_arm.so"))
                    {
                        ijiamiCheckCB.Checked = true;
                        ijiamiCheckCB.CheckState = CheckState.Checked;
                        ijiamiCheckCB.ForeColor = Color.Red;
                    }
                }
            }
            if (Directory.Exists(str + "\\lib\\"))
            {
                string[] lib = Directory.GetFiles(str + "\\lib", "*.so", SearchOption.AllDirectories);
                foreach (string file in lib)
                {
                    //switch (file)
                    //{
                    //    case string a when a.Contains("libmono.so"):
                    //        unityCheckCB.Checked = true;
                    //        break;
                    //    //разширение диапазонов
                    //    case string b when b.Contains("libunity.so"):
                    //    case string b1 when b1.Contains("libil2cpp.so"):
                    //    case string b2 when b2.Contains("libmain.so"):
                    //        unrealCheckCB.Checked = true;
                    //        break;
                    //}

                    ///======/ Engine /========///
                    if (file.Contains("libmono.so"))
                    {
                        // MessageBox.Show("Detect", "Unity");
                        unity_monoCB.Checked = true;
                        unity_monoCB.CheckState = CheckState.Checked;
                        unity_monoCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libil2cpp.so"))
                    {
                        unity_il2cppCB.Checked = true;
                        unity_il2cppCB.CheckState = CheckState.Checked;
                        unity_il2cppCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libUAE4.so"))
                    {
                        unrealCheckCB.Checked = true;
                        unrealCheckCB.CheckState = CheckState.Checked;
                        unrealCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libcocos2d.so") || file.Contains("libcocos2dlua.so"))
                    {
                        cocosCB.Checked = true;
                        cocosCB.CheckState = CheckState.Checked;
                        cocosCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libmonodroid.so") || file.Contains("libmonosgen-2.0.so"))
                    {
                        xamarinCB.Checked = true;
                        xamarinCB.CheckState = CheckState.Checked;
                        xamarinCB.ForeColor = Color.Red;
                    }
                    ///=====/ Packers /======///
                    if (file.Contains("libjiagu.so") || file.Contains("libjiagu_art.so"))
                    {
                        jiaguCheckCB.Checked = true;
                        jiaguCheckCB.CheckState = CheckState.Checked;
                        jiaguCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libapktoolplus_jiagu.so"))
                    {
                        jiagu_aCheckCB.Checked = true;
                        jiagu_aCheckCB.CheckState = CheckState.Checked;
                        jiagu_aCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libAppGuard.so") || file.Contains("libAppGuard-x86.so"))
                    {
                        appguardCheckCB.Checked = true;
                        appguardCheckCB.CheckState = CheckState.Checked;
                        appguardCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libdxbase.so"))
                    {
                        dxshieldCheckCB.Checked = true;
                        dxshieldCheckCB.CheckState = CheckState.Checked;
                        dxshieldCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libDexHelper.so") || file.Contains("libDexHelper-x86.so"))
                    {
                        secneoCheckCB.Checked = true;
                        secneoCheckCB.CheckState = CheckState.Checked;
                        secneoCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libAPKProtect.so"))
                    {
                        apkprotectCheckCB.Checked = true;
                        apkprotectCheckCB.CheckState = CheckState.Checked;
                        apkprotectCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libsecexe.so") || file.Contains("libsecmain.so"))
                    {
                        bangcleCheckCB.Checked = true;
                        bangcleCheckCB.CheckState = CheckState.Checked;
                        bangcleCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libSecShell.so") || file.Contains("libSecShell-x86.so"))
                    {
                        bangcle_secshellCheckCB.Checked = true;
                        bangcle_secshellCheckCB.CheckState = CheckState.Checked;
                        bangcle_secshellCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libkiroro.so"))
                    {
                        kiroCheckCB.Checked = true;
                        kiroCheckCB.CheckState = CheckState.Checked;
                        kiroCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libprotectClass.so"))
                    {
                        qihoo360CheckCB.Checked = true;
                        qihoo360CheckCB.CheckState = CheckState.Checked;
                        qihoo360CheckCB.ForeColor = Color.Red;
                    }
                    //if (file.Contains(""))
                    //{
                    //unicom_loaderCheckCB.Checked = true;
                    //unicom_loaderCheckCB.CheckState = CheckState.Checked;
                    //unicom_loaderCheckCB.ForeColor = Color.Red;
                    //}
                    if (file.Contains("libNSaferOnly.so"))
                    {
                        app_fortifyCheckCB.Checked = true;
                        app_fortifyCheckCB.CheckState = CheckState.Checked;
                        app_fortifyCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libshell.so") || file.Contains("libmobisecy.so"))
                    {
                        tencentCheckCB.Checked = true;
                        tencentCheckCB.CheckState = CheckState.Checked;
                        tencentCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libbaiduprotect.so"))
                    {
                        baiduCheckCB.Checked = true;
                        baiduCheckCB.CheckState = CheckState.Checked;
                        baiduCheckCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libnsecure.so"))
                    {
                        pangxieCB.Checked = true;
                        pangxieCB.CheckState = CheckState.Checked;
                        pangxieCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libkonyjsvm.so"))
                    {
                        konyCB.Checked = true;
                        konyCB.CheckState = CheckState.Checked;
                        konyCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libapproov.so"))
                    {
                        aproovCB.Checked = true;
                        aproovCB.CheckState = CheckState.Checked;
                        aproovCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libcovault.so") || file.Contains("libcovault-appsec.so"))
                    {
                        appsealingCB.Checked = true;
                        appsealingCB.CheckState = CheckState.Checked;
                        appsealingCB.ForeColor = Color.Red;
                    }
                    if (file.Contains("libnqshield.so") || file.Contains("nqshield") || file.Contains("nqshell"))
                    {
                        nqshieldCB.Checked = true;
                        nqshieldCB.CheckState = CheckState.Checked;
                        nqshieldCB.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            checkProtect(patch);
        }
    }
}
