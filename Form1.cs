using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using Microsoft.Win32;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace dynolts
{
    public partial class Form1 : Form
    {
        private const string d1 = @"%SystemRoot%\System32\ClipSVC.dll";
        private const string d2 = @"%SystemRoot%\System32\ClipSVC.dll";

        public Form1()
        {
            MessageBox.Show("WARNING : This launcher is for x64 PC only ! If you use this in a x32 PC , don't say i didn't warn you because all thing in this launcher are tweaked for x64 .");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DynoLTS Launcher \nVersion LTS.1 \nThis product is made by a UWP cracker group");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CREDITS \n \n ClickNin#4252 \n TinedPakGamer#8742 \n santu#6900 \n ItzLightyHD#6309 \n White#0008 \n 『𝑵𝑿₇』GODY#4148 \n DetectiveGhost#5076 \n Tech Archives#0443");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Default : Start MC with default ClipSVC mode , can be unstable and Unlock Full Game can comeback after 10 or 30 minutes . You'll need to disable the crack manually after finished playing . Also , this mode can cause Black Screen on some machines . \n \nInjection : Same with default but when launched , ClipSVC will be restarted and running while the game has in crack mode . This will allow you download or install apps from MS Store while playing games . No need to disable after finished playing . \n \nAdvanced : Start MC without any system modify . This allow you to play all versions with no limited . This mode allow you play MC without anything but can results as system broken . Unlock Full Game can't comeback and you will not need to do anything after finished playing . You can repatch Advanced Mode to revert to trial mode . \n \nFresh Start : Launch MC with default and current system configuration . Best for testing .");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Before install MC , i should make a notice : If you going to use Default mode , you should install 1.16 or newer only . Same at Injection but if you going to use Advanced Mode , you can install any version you want !");
            openFileDialog1.ShowDialog();
            string apath = openFileDialog1.FileName;
            MessageBox.Show("You selected : " + apath);
            System.Diagnostics.Process.Start("powershell", "Add-AppxPackage -Path " + apath);
            MessageBox.Show("MC should be installed now . If you not see MC on the start menu , i should recommended you check if ClipSVC enabled and if MC has already installed .");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ClipSVC\Parameters", true);
            //adding/editing a value 
            key.SetValue("ServiceDll", d1, RegistryValueKind.ExpandString); //sets 'someData' in 'someValue' 
            key.Close();
            string clst;
            string pw;
            clst = @"/C net start ""ClipSVC"" ";
            pw = @"/C powershell -Command ""Get-AppxPackage Microsoft.MinecraftUWP | Remove-AppxPackage"" ";
            System.Diagnostics.Process.Start("cmd.exe", clst);
            System.Diagnostics.Process.Start("cmd.exe", pw);
            MessageBox.Show("MC is uninstalled !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ClipSVC\Parameters", true);
            //adding/editing a value 
            key.SetValue("ServiceDll", d2, RegistryValueKind.ExpandString); //sets 'someData' in 'someValue' 
            key.Close();
            string clst1;
            clst1 = @"/C net start ""ClipSVC"" ";
            System.Diagnostics.Process.Start("cmd.exe", clst1);
            MessageBox.Show("Default Mode is disabled !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry but Injection is not ready at this moment !");
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\ClipSVC\Parameters", true);
            //adding/editing a value 
            const string V = @"%SystemRoot%\System32\ClipSVC.dll";
            key.SetValue("ServiceDll", V + new Random().Next(1, 1000), RegistryValueKind.ExpandString); //sets 'someData' in 'someValue' 
            key.Close();
            string strCmdText;
            string mc1;
            string mc2;
            strCmdText = @"/C net stop ""ClipSVC"" ";
            mc1 = @"/C explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App";
            mc2 = @"/C taskkill /IM ""RuntimeBroker.exe"" /F";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            System.Diagnostics.Process.Start("CMD.exe", mc1);
            await Task.Delay(45000);
            System.Diagnostics.Process.Start("CMD.exe", mc2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sourceforge.net/projects/mc-appx/files/");
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string dir1 = AppDomain.CurrentDomain.BaseDirectory + @"\system32\Windows.ApplicationModel.Store.dll";
            string dir2 = AppDomain.CurrentDomain.BaseDirectory + @"\syswow64\Windows.ApplicationModel.Store.dll";
            string t1 = @"C:\Windows\System32\Windows.ApplicationModel.Store.dll";
            string t2 = @"C:\Windows\SysWOW64\Windows.ApplicationModel.Store.dll";
            string cmdtake;
            string cmdtake2;
            cmdtake = @"cmd.exe /c takeown /f C:\Windows\System32\Windows.ApplicationModel.Store.dll && icacls C:\Windows\System32\Windows.ApplicationModel.Store.dll  /grant administrators:F";
            cmdtake2 = @"cmd.exe /c takeown /f C:\Windows\SysWOW64\Windows.ApplicationModel.Store.dll && icacls C:\Windows\SysWOW64\Windows.ApplicationModel.Store.dll  /grant administrators:F";
            System.Diagnostics.Process.Start("CMD.exe", cmdtake);
            await Task.Delay(3000);
            System.Diagnostics.Process.Start("CMD.exe", cmdtake2);
            await Task.Delay(3000);
            File.Copy(dir1, t1, true);
            File.Copy(dir2, t2, true);
            string mcl;
            mcl = @"/C explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App";
            System.Diagnostics.Process.Start("CMD.exe", mcl);
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            string dirr1 = AppDomain.CurrentDomain.BaseDirectory + @"revert\system32\Windows.ApplicationModel.Store.dll";
            string dirr2 = AppDomain.CurrentDomain.BaseDirectory + @"revert\syswow64\Windows.ApplicationModel.Store.dll";
            string tr1 = @"C:\Windows\System32\Windows.ApplicationModel.Store.dll";
            string tr2 = @"C:\Windows\SysWOW64\Windows.ApplicationModel.Store.dll";
            string cmdtake;
            string cmdtake2;
            cmdtake = @"cmd.exe /c takeown /f C:\Windows\System32\Windows.ApplicationModel.Store.dll && icacls C:\Windows\System32\Windows.ApplicationModel.Store.dll  /grant administrators:F";
            cmdtake2 = @"cmd.exe /c takeown /f C:\Windows\SysWOW64\Windows.ApplicationModel.Store.dll && icacls C:\Windows\SysWOW64\Windows.ApplicationModel.Store.dll  /grant administrators:F";
            System.Diagnostics.Process.Start("CMD.exe", cmdtake);
            await Task.Delay(3000);
            System.Diagnostics.Process.Start("CMD.exe", cmdtake2);
            await Task.Delay(3000);
            File.Copy(dirr1, tr1, true);
            File.Copy(dirr2, tr2, true);
            MessageBox.Show("Advanced Mode reverted !");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string mclk;
            mclk = @"/C explorer.exe shell:appsFolder\Microsoft.MinecraftUWP_8wekyb3d8bbwe!App";
            System.Diagnostics.Process.Start("CMD.exe", mclk);
        }
    }
}
