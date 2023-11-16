namespace WinFormsApp4
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button_Comecar_Click(object sender, EventArgs e)
        {
            TelaCadastro form2 = new TelaCadastro();
            form2.Show();
            this.Hide();
        }

    }
}