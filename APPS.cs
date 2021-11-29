using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SOFTWARE
{
    public partial class APPS : Form
    {
        DECRYPT u1;
        public APPS()
        {
            InitializeComponent();        
            GetInstalledApps();          
        }
        public void GetInstalledApps()
        {

            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))

            {
                foreach (string skName in rk.GetSubKeyNames())

                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            checkedListBox1.Items.Add(sk.GetValue("DisplayName"));
                        }
                        catch (Exception ex)
                        { }
                    }
                }
                label1.Text = checkedListBox1.Items.Count.ToString();
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                
                this.Hide();
                DECRYPT registration = new DECRYPT();
                registration.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                this.Hide();
                DECRYPT registration = new DECRYPT();
                registration.ShowDialog();
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
