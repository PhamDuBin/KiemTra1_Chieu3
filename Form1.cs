using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra1_Chieu3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            String passWord = txtpassword.Text;
            if(userName == "admin" && passWord == "admin")
            {
                TrangChu TrangChu = new TrangChu();
                TrangChu.Show();
            }
        }
    }
}
