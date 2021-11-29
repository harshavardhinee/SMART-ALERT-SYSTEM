using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTWARE
{
    public partial class DECRYPT : Form
    {
        public DECRYPT()
        {
            InitializeComponent();
        }
        dbcontrol sql = new dbcontrol();
        bool Login()
        {
            sql.Param("@username", textBox1.Text);
            sql.Param("@password", textBox2.Text);
            sql.query("select count(*) from tbluser where username = @username and password = @password");
            if ((int)sql.dt.Rows[0][0] == 1)
            {
                return true;
            }

            MessageBox.Show("invalid username and password", "invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        private void DECRYPT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
            if ((int)sql.dt.Rows[0][0] == 1)
            {
                Environment.Exit(0);
            }
            else
            {
                this.Hide();
                
            }
        }
    }
}
