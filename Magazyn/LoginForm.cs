namespace Magazyn
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //TODO Login
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            //TODO Register
        }

        #region ShowPassword
        private void ShowPasswordButton_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void ShowPasswordButton_MouseClick(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void ShowPasswordButton_MouseLeave(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }
        #endregion ShowPassword
    }
}
