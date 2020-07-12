using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;

namespace POLICE_FORWARDER
{
    public partial class Forwarder : Form
    {
        public Forwarder()
        {
            InitializeComponent();
        }

        static void runCommand(string cmp)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"C:\Python38\python.exe";
            process.StartInfo.Arguments = "\"C:\\Users\\HAL 9000\\Desktop\\main.py\" \""+cmp+"\""; 
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            process.Start();
            //* Read the output (or the error)
            string output = process.StandardOutput.ReadToEnd();
            MessageBox.Show(output);   
            process.WaitForExit();
        }
        private void complaint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                runCommand(complaint.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
