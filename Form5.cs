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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into BorrowBy values (@M_Id, @B_Id, @Issue_Date, @Due_Date, @Return_Date)", conn);
            cmd.Parameters.AddWithValue("@M_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@B_Id", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Issue_Date", textBox3.Text);
            cmd.Parameters.AddWithValue("@Due_Date", textBox4.Text);
            cmd.Parameters.AddWithValue("Return_Date", textBox5.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Book Borrowed");
        }
    }
}
