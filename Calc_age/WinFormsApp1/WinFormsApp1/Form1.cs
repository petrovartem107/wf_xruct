namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tb3.Text = Convert.ToString(Convert.ToInt32(tb2.Text) - Convert.ToInt32(tb1.Text));
        }
    }
}