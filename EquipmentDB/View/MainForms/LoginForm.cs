using System;
using System.Windows.Forms;
using EquipmentDB.Controller;
using EquipmentDB.Forms;


namespace EmployeeApp.View
{
    public partial class LoginForm : Form
    {
        private readonly IRepository _repository = Repository.Instance;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login()
        {
            try
            {
                //_repository.UserLogin(textBoxLogin.Text, textBoxPassword.Text);
                //if (_repository.GetCurrentUser()!=null)
                //{
                //    Close();
                //}                
                if (textBoxLogin.Text == "Admin" && textBoxPassword.Text == "Admin") 
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();                     
                }
                else if (textBoxLogin.Text == "Manager" && textBoxPassword.Text == "Manager")
                {
                    MainFormManager mainFormManager = new MainFormManager();
                    mainFormManager.Show();                    
                }
                else if (textBoxLogin.Text == "User" && textBoxPassword.Text == "User")
                {
                    MainFormUser mainFormUser = new MainFormUser();
                    mainFormUser.Show();                    
                }                   
                else
                {
                    MessageBox.Show(" Пользователь с таким логином и паролем не найден!", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    textBoxPassword.Clear();
                }
            }
            catch (Exception e)
            {
                _repository.HandleException(e);
            }
            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
           Login();
        }

       private void LoginForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
               Login(); 
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
