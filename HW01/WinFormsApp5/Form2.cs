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
            frmMain.SetText(textBoxSecond.Text);

            if (pictureBoxsecond.Image != null)
            {
                frmMain.SetImage(pictureBoxsecond.Image);
            }

            frmMain.Show();
            this.Hide();
        }



        public void SetText(string text)
        {
            textBoxSecond.Text = text;
        }

        public void SetImage(Image img)
        {
            pictureBoxsecond.Image = img;
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnuploadsecond_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(dialog.FileName);
                pictureBoxsecond.Image = selectedImage;
            }
        }
    }
}
