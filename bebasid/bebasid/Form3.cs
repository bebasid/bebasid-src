using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using IWshRuntimeLibrary;
using System.Reflection;
using System.Net;
using System.Threading;

namespace bebasid
{
    public partial class About : Form
    {
        public static bool isBebasidStartMenu()
        {
            return System.IO.File.Exists(Environment.GetEnvironmentVariable("AppData") + "/Microsoft/Windows/Start Menu/Programs/bebasid.lnk");
        }
        
        public About()
        {
            InitializeComponent();
            
            if (isBebasidStartMenu())
            {
                button4.Enabled = false;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        public static void CreateShortcut(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.Description = "bebasid";   // The description of the shortcut
            shortcut.IconLocation = @"c:\windows\temp\logo_black_80e_icon.ico";  // The icon of the shortcut
            shortcut.TargetPath = targetFileLocation;                 // The path of the file that will launch when the shortcut is run
            shortcut.Save();                                    // Save the shortcut
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient dlico = new WebClient();
            dlico.DownloadFile(new Uri("https://raw.githubusercontent.com/bebasid/bebasid-src/main/bebasid/bebasid/logo_black_80e_icon.ico"), Environment.GetEnvironmentVariable("SystemRoot") + "/Temp/logo_black_80e_icon.ico");
            Thread.Sleep(500);
            
            CreateShortcut("bebasid", Environment.GetEnvironmentVariable("AppData") + "/Microsoft/Windows/Start Menu/Programs/", Assembly.GetExecutingAssembly().Location);
            button4.Enabled = false;
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(Environment.GetEnvironmentVariable("AppData") + "/Microsoft/Windows/Start Menu/Programs/bebasid.lnk");
            button4.Enabled = true;
            button5.Enabled = false;
        }

        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(Encrypt(textBox1.Text) == "jridcdjrbiduejse")
            {
                this.Close();
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("No problem if you don't have the Secret Key Code (SKC), because it's not affect this application. This application is 100% free without license key needed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bebasid.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bebasid/bebasid");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/EKrxZyu");
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
    }
}
