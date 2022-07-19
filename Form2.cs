using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Books values (@B_Id, @Title, @Author, @Price, @Available)", conn);
            cmd.Parameters.AddWithValue("@B_Id", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Title", textBox2.Text);
            cmd.Parameters.AddWithValue("@Author", textBox4.Text);
            cmd.Parameters.AddWithValue("@Price", textBox3.Text);
            cmd.Parameters.AddWithValue("@Available", textBox1.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Book Added Successfully");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
