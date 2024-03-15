using Business.Abstract;
using Business.Concreate;
using DataAccess.Entities;
using DTOs;

namespace CafeManagment
{
    public partial class LoginForm : Form
    {
        IUserService _userService;
        SignUpForm _signUpForm;
        public LoginForm(SignUpForm signUpForm)
        {
            InitializeComponent();
            _userService = new UserService();
            _signUpForm = signUpForm;
        }

        public LoginForm()
        {
            _userService = new UserService();
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO()
            {
                Username = textBox1.Text,
                Password = textBox2.Text,
            };
            try
            {
                var roles = _userService.Login(userDTO);
                var userRole = roles.FirstOrDefault();
                    

                if (userRole.UserRole == UserRole.Member)
                {
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    Hide();
                }
                else
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    Hide();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            Hide();
        }
    }
}
