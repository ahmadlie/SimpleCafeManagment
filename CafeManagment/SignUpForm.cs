using Business.Abstract;
using Business.Concreate;
using DataAccess.Entities;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagment
{
    public partial class SignUpForm : Form
    {
        IUserService _userService;
        public SignUpForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO()
            {
                FirstName = textBox1.Text,
                LastName = textBox2.Text,
                Email = textBox3.Text,
                Username = textBox5.Text,
                Password = textBox4.Text,               
            };
            try
            {
                _userService.SignUp(userDTO, textBox6.Text);
                LoginForm loginForm = new LoginForm(this);
                loginForm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.Show();
            Hide();
        }
    }
}
