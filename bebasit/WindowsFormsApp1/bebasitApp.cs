using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace bebasit
{
    public partial class bebasitApp : Form
    {
        public void checkFile(string path)
        {

            bool ada = File.Exists(AppDomain.CurrentDomain.BaseDirectory+"/"+path);
            if (!ada)
            {
                MessageBox.Show("Aplikasi telah mengalami modifikasi, silakan mengunduh ulang bebasit (https://bebasid.github.io/bebasit/)","BEBASID TUNNEL");
                Environment.Exit(0);
            }
        }
        public bebasitApp()
        {
            InitializeComponent();
            checkFile("dependencies/x86_64/goodbyedpi.exe");
            checkFile("dependencies/x86/goodbyedpi.exe");
            checkFile("dependencies/PowerTunnel.jar");
            var path = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command", null, null) as string;
            if (path != null)
            {
            }
            else
            {
                MessageBox.Show("Google Chrome terdeteksi tidak terpasang di komputer ini, opsi 'Tanpa Browser' akan tercentang secara default", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox2.Enabled = false;
                checkBox2.Checked = true;
                //checkBox2.Visible = false;
            }
        }
        dynamic funGrepDoh(string muach)
        {
            switch (muach)
            {
                case "DNSLify": return "https://doh.dnslify.com/dns-query";
                case "TiarApp": return "https://doh.tiarap.org/dns-query";
                case "AdGuard": return "https://dns.adguard.com/dns-query";
                case "BlahDNS": return "https://doh-de.blahdns.com/dns-query";
                case "CleanBrowsing": return "https://doh.cleanbrowsing.org/doh/security-filter";
                case "CloudFlare": return "https://1dot1dot1dot1.cloudflare-dns.com/dns-query";
                case "Synology": return "https://ibksturm.synology.me/dns-query";
                default: return null;
            }
        }

        dynamic funGrepDohIPv4(string doh)
        {
            switch (doh)
            {
                case "DNSLify": return "185.235.81.1";
                case "TiarApp": return "174.138.21.128";
                case "AdGuard": return "176.103.130.130";
                case "BlahDNS": return "159.69.198.101";
                case "CleanBrowsing": return "185.228.168.9";
                case "CloudFlare": return "1.1.1.1";
                case "Synology": return "83.77.85.7";
                default: return null;
            }
        }

        dynamic funGrepDohIPv6(string doh)
        {
            switch (doh)
            {
                case "DNSLify": return "2a0d:4d00:81::1";
                case "TiarApp": return "2400:6180:0:d0::5f6e:4001";
                case "AdGuard": return "2a00:5a60::ad1:0ff";
                case "BlahDNS": return "2a01:4f8:1c1c:6b4b::1";
                case "CleanBrowsing": return "2a0d:2a00:1::2";
                case "CloudFlare": return "2606:4700:4700::1111";
                case "Synology": return "2a02:1205:34d5:5070:b26e:bfff:fe1d:e19b";
                default: return null;
            }
        }

        dynamic funGrepPort(string doh)
        {
            switch (doh)
            {
                case "TiarApp": return "5003";
                default: return null;
            }
        }
        public void disableMulaiButton()
        {
            checkBox1.Enabled = false;
            if (checkBox1.Enabled)
            {
                comboBox1.Enabled = (checkBox1.CheckState == CheckState.Checked);
            }
            else
            {
                comboBox1.Enabled = false;
            }
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        public void disableSelesaiButton()
        {
            checkBox1.Enabled = true;
            if (checkBox1.Enabled)
            {
                comboBox1.Enabled = (checkBox1.CheckState == CheckState.Checked);
            }
            else
            {
                comboBox1.Enabled = false;
            }
            var path = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command", null, null) as string;
            if (path != null)
            {
                checkBox2.Enabled = true;
            }
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = true;
                textBox1.Enabled = false;
            }
            else
            {
                if (checkBox4.Checked)
                {
                    checkBox4.Checked = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = false;
                    textBox1.Enabled = true;
                }
            }
            button1.Enabled = true;
            button2.Enabled = false;
        }
        
        public void killJava()
        {
            foreach (Process killChrome in Process.GetProcessesByName("java"))
            {
                killChrome.Kill();
            }
        }
        
        public void killChrome()
        {
            foreach( Process killChrome in Process.GetProcessesByName("chrome")){
                killChrome.Kill();
            }            
        }

        public void killGoodbyeDPI()
        {
            foreach( Process killGoodbyeDPI in Process.GetProcessesByName("goodbyedpi"))
            {
                killGoodbyeDPI.Kill();
            }
        }

        public void startGoodbyeDPI(string doh)
        {
            string dnsIPv4 = funGrepDohIPv4(doh);
            string dnsIPv6 = funGrepDohIPv6(doh);
            string dnsPort = funGrepPort(doh);
            if (string.IsNullOrEmpty(dnsPort))
            {
                dnsPort = "53";
                MessageBox.Show(doh+" tidak memiliki selain DNS port 53, jika GoodbyeDPI gagal dalam menembus DPI, silakan pilih Custom DNS yang lain (misalnya TiarApp)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Process startGoodbyeDPI = new Process();
            startGoodbyeDPI.StartInfo.UseShellExecute = true;
            startGoodbyeDPI.StartInfo.Verb = "runas";
            if (Environment.Is64BitOperatingSystem)
            {
                startGoodbyeDPI.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "/dependencies/x86_64/goodbyedpi.exe";
            }
            else
            {
                startGoodbyeDPI.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "/dependencies/x86/goodbyedpi.exe";
            }
            startGoodbyeDPI.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startGoodbyeDPI.StartInfo.CreateNoWindow = true;
            startGoodbyeDPI.StartInfo.Arguments = "-1 --dns-addr "+dnsIPv4+" --dns-port "+dnsPort+" --dnsv6-addr "+dnsIPv6+" --dnsv6-port "+dnsPort;
            try
            {
                if (startGoodbyeDPI.Start())
                {
                    label3.Text = "Sedang membuka GoodbyeDPI";
                    Thread.Sleep(5000);
                    label3.Text = "Menunggu GoodbyeDPI";
                    Thread.Sleep(5000);
                    disableMulaiButton();
                    return;
                }
                else
                {
                    label3.Text = "Tidak dapat membuka GoodbyeDPI";
                    disableSelesaiButton();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                disableSelesaiButton();
            }
        }

        public void startPowerTunnel(string dns, string port)
        {
            Process startPowerTunnel = new Process();
            startPowerTunnel.StartInfo.UseShellExecute = false;
            startPowerTunnel.StartInfo.FileName = "java";
            startPowerTunnel.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startPowerTunnel.StartInfo.CreateNoWindow = true;
            startPowerTunnel.StartInfo.Arguments = "-jar "+ AppDomain.CurrentDomain.BaseDirectory+ "/dependencies/PowerTunnel.jar -start -console -send-payload 21 -disable-tray -disable-updater -government-blacklist-from https://raw.githubusercontent.com/bebasid/bebasit/master/dependencies/goodbyedpi/blacklist.txt -use-dns-server " + dns + " -ip 127.0.0.1 -port " + port + " -disable-auto-proxy-setup";
            try
            {
                if (startPowerTunnel.Start())
                {
                    label3.Text = "Sedang membuka PowerTunnel";
                    Thread.Sleep(10000);
                    label3.Text = "Menunggu PowerTunnel merespon";
                    Thread.Sleep(5000);
                    return;
                }
                else
                {
                    label3.Text = "Tidak dapat membuka PowerTunnel";
                    disableSelesaiButton();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                disableSelesaiButton();
            }
        }

        public void startChrome(string port)
        {
            Process startChrome = new Process();
            var path = Microsoft.Win32.Registry.GetValue(@"HKEY_CLASSES_ROOT\ChromeHTML\shell\open\command", null, null) as string;
            string chromeApp ="";
            if (path != null)
            {
                var split = path.Split('\"');
                chromeApp = split.Length >= 2 ? split[1] : null;
            }
            startChrome.StartInfo.FileName = chromeApp;
            startChrome.StartInfo.Arguments = "https://www.netflix.com --proxy-server=http://127.0.0.1:" + port + " --proxy-bypass-list=<-loopback>";
            try
            {
                if (startChrome.Start())
                {
                    label3.Text = "Sedang membuka Google Chrome";
                    return;
                }
                else
                {
                    label3.Text = "Tidak dapat membuka PowerTunnel";
                    disableSelesaiButton();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                disableSelesaiButton();
            }
        }

        public void startChromeNoProxy()
        {
            Process startChrome = new Process();
            startChrome.StartInfo.FileName = "chrome";
            startChrome.StartInfo.Arguments = "https://www.netflix.com";
            try
            {
                if (startChrome.Start())
                {
                    label3.Text = "Sedang membuka Google Chrome";
                    return;
                }
                else
                {
                    label3.Text = "Tidak dapat membuka PowerTunnel";
                    disableSelesaiButton();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                disableSelesaiButton();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = (checkBox1.CheckState == CheckState.Checked);
            }
            else
            {
                comboBox1.Enabled = false;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string grepDoh;
            string hasembuh;
            string bebasitPort = textBox1.Text;
            disableMulaiButton();
            if (checkBox1.Checked)
            {
                grepDoh = funGrepDoh(comboBox1.SelectedItem.ToString().Trim());
                hasembuh = comboBox1.SelectedItem.ToString().Trim();
            }
            else
            {
                grepDoh = "https://doh.tiarap.org/dns-query/";
                hasembuh = "TiarApp";
            }
            var bebasitKonfirmasi = MessageBox.Show("Dengan menekan tombol Yes, Google Chrome (kecuali centang opsi tanpa browser) dan Java (untuk PowerTunnel) akan tertutup, pastikan Anda telah menyimpan/mengamankan aktivitas yang sedang dilakukan",
                "Konfirmasi",
                MessageBoxButtons.YesNo);
            if (bebasitKonfirmasi == DialogResult.Yes)
            {
                if (checkBox3.Checked)
                {
                    startGoodbyeDPI(hasembuh);
                    if (!checkBox2.Checked)
                    {
                        killChrome();
                        startChromeNoProxy();
                        Thread.Sleep(5000);
                        label3.Text = "Berhasil membuka Google Chrome";
                    }
                    else
                    {
                        label3.Text = "Berhasil membuka GoodbyeDPI";
                    }

                }
                else
                {
                    if (checkBox4.Checked)
                    {
                        killJava();
                        startPowerTunnel(grepDoh, bebasitPort);
                        if (!checkBox2.Checked)
                        {
                            killChrome();
                            startChrome(bebasitPort);
                            Thread.Sleep(5000);
                            label3.Text = "Berhasil membuka Google Chrome";
                        }
                        else
                        {
                            label3.Text = "Berhasil membuka PowerTunnel";
                        }
                        
                    }
                }
            }
            else
            {
                disableSelesaiButton();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (!checkBox2.Checked)
                {
                    killGoodbyeDPI();
                    killChrome();
                    disableSelesaiButton();
                }
                else
                {
                    killGoodbyeDPI();
                    disableSelesaiButton();
                }
            }
            else
            {
                if (checkBox4.Checked)
                {
                    if (!checkBox2.Checked)
                    {
                        killJava();
                        killChrome();
                        disableSelesaiButton();
                    }
                    else
                    {
                        killJava();
                        disableSelesaiButton();
                    }
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Petunjuk penggunaan:\n 1. Centang GoodbyeDPI atau PowerTunnel (pilih salah satu), \n 2. Klik tombol Mulai, \n 3. Akan ada konfirmasi, klik tombol Yes, \n 4a. Tunggu hingga Google Chrome terbuka secara otomatis, \n 4b. Tunggu hingga muncul tulisan Sukses membuka...\n 5. Happy Streaming \n\n Note:\n 1. Aplikasi ini 100% GRATIS, tidak untuk dikomersilkan / diperjualbelikan. \n 2. Metode PowerTunnel membutuhkan JRE 7+ \n 3. Aplikasi ini tidak dapat ditutup selama masih streaming \n 4. Untuk berhenti, tekan tombol SELESAI \n\n bebasit (haibara) \n by KINI\n https://github.com/bebasid/bebasit/",
                "Petunjuk Penggunaan bebasit");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.linkLabel1.LinkVisited = true;
            //System.Diagnostics.Process.Start("https://bebasid.github.io/bebasit/");
            MessageBox.Show("BEBASIT (bebasid tunnel) v1.1\n[2020.6] (Annia) \n\n --haibara--\n\nbased on:\n-GoodbyeDPI v0.1.6 (https://github.com/ValdikSS/GoodbyeDPI)\n-PowerTunnel v1.11 (https://github.com/krlvm/PowerTunnel) (Java 8)",
                "About");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox4.Checked = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = true;
                textBox1.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox3.Checked = false;
                checkBox4.Enabled = false;
                checkBox3.Enabled = true;
                textBox1.Enabled = true;
            }
        }

        private void bebasitApp_Load(object sender, EventArgs e)
        {

        }
        private void bebasitApp_SizeChanged(object sender, EventArgs e)
        {
            bool mosgaditaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);
            if (this.WindowState == FormWindowState.Minimized && mosgaditaskbar)
            {
                bebasitTray.ShowBalloonTip(3000);
                this.ShowInTaskbar = false;
                bebasitTray.Visible = true;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            if(this.WindowState == FormWindowState.Normal)
            {
                bebasitTray.Visible = false;
                ShowInTaskbar = true;
            }
            
        }

    }
}