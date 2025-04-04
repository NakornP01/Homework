namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        Form2 frmsec;

        public Form1()
        {
            InitializeComponent();
            frmsec = new Form2(this);

        }

        private void btnokMain_Click(object sender, EventArgs e)
        {
            frmsec.SetText(textBoxMain.Text);
            if (pictureBoxmain.Image != null)
            {
                frmsec.SetImage(pictureBoxmain.Image);
            }
            frmsec.Show();
            this.Hide();
        }

        public void SetText(string text)
        {
            textBoxMain.Text = text;
        }

        public void SetImage(Image img)
        {
            pictureBoxmain.Image = img;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBoxMain.Clear();
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(dialog.FileName);
                pictureBoxmain.Image = selectedImage;
            }


        }

    
    }
}
