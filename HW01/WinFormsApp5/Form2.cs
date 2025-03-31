using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        Form1 frmMain;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            frmMain = form1;
        }

        private void btnokSecond_Click(object sender, EventArgs e)
        {
            frmMain.SetText(textBoxSecond.Text); // ส่งข้อความกลับไป Form1
            frmMain .Show(); // แสดง Form1
            this.Hide(); // ซ่อน Form2    
        }

        public void SetText(string text)
        {
            textBoxSecond   .Text = text;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
