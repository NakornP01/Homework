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
            frmsec  .Show(); 
            this.Hide();
        }

        public void SetText(string text)
        {
            textBoxMain.Text = text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBoxMain.Clear();
        }
    }
}
