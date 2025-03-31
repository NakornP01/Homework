namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        Form2 frm2;

        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2(this);
          
        }

        private void btnok1_Click(object sender, EventArgs e)
        {
            frm2.SetText(textBox1.Text); // ???????????? Form2
            frm2.Show(); // ???? Form2
            this.Hide(); // ???? Form1
        }

        public void SetText(string text)
        {
            textBox1.Text = text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
