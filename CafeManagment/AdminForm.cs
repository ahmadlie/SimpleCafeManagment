using AutoMapper;
using Business.Abstract;
using Business.Concreate;
using Business.Config;
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
    public partial class AdminForm : Form
    {
        IProductService _productService;
        MapperConfiguration _mapperConfiguration;
        IMapper _mapper;
        public AdminForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<MapperProfile>());
            _mapper = _mapperConfiguration.CreateMapper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedCategory = comboBox1.SelectedItem.ToString();
            ProductDTO productDTO = new ProductDTO()
            {
                Name = textBox2.Text,
                CategoryId = selectedCategory == "Food" ? 1 : 2,
                Price = Convert.ToDouble(textBox3.Text)
            };

            _productService.Create(productDTO);
            LoadProducts();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        public void LoadProducts()
        {
            IEnumerable<ProductListDTO> productList;
            var products = _productService.GetAll();
            var newProducts = _mapper.Map<IEnumerable<ProductListDTO>>(products);

            itemsGV.DataSource = newProducts;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           // var selectedCategory = comboBox1.SelectedItem.ToString();
            var selectedRows = itemsGV.SelectedRows[0];
            //var id = Convert.ToInt32(selectedRows.Cells[0].Value);
            selectedRows.Cells[0].Value = textBox2.Text;
            selectedRows.Cells[1].Value = textBox3.Text;


            ProductDTO productDTO = new ProductDTO()
            {
                Name = textBox2.Text,
                Price = Convert.ToDouble(textBox3.Text)
            };

           // _productService.Update(id, productDTO);
        }
    }
}

