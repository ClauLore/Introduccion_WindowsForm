namespace Introduccion_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ls_usuario = txtUsuario.Text;
            string ls_password = txtPassword.Text;

            if (ls_usuario.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un usuario válido");
                txtUsuario.Focus();
                return;
            }

            if (ls_password.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese un password válido");
                txtPassword.Focus();
                return;
            }

            if (ls_usuario=="cgarcia" && ls_password == "cl@u2025**")
            {
                var text = "Bienvenido " + ls_usuario;
                Form2 form2 = new Form2(text);
                
                progressBar1.Visible = true;
                progressBar1.Value = 100;
                form2.ShowDialog();
            }


           
        }

       
    }
}
