using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SOFTWARE
{
    public partial class REGISTRATION : Form
    {
        public REGISTRATION()
        {
            InitializeComponent();
        }
        dbcontrol sql = new dbcontrol();
        void register()
        {
            sql.Param("@username", textBox1.Text);
            sql.Param("@password", textBox2.Text);
            sql.Param("@gmail", textBox4.Text); 
            
            sql.query("insert into tbluser (username,password,gmail) values (@username,@password,@gmail)");
            if (sql.Check4error(true))
            {
                return;
            }
            MessageBox.Show("Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            register();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN login = new LOGIN();
            login.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
