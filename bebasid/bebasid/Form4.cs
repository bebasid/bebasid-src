using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace bebasid
{
    public partial class Form4 : Form
    {
        static string ekncrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                return value;
            }
        }

        public Form4()
        {
            InitializeComponent();
            richTextBox1.Text = ekncrypt(richTextBox1.Text);
            richTextBox2.Text = ekncrypt(richTextBox2.Text);
        }
    }
}
