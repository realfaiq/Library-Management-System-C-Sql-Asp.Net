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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagement;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Members set Name=@Name, M_Type=@M_Type, Address=@Address, Date=@Date, Expiry_Date=@Expiry_Date where M_Id=@M_Id  ", conn);
            cmd.Parameters.AddWithValue("@M_Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@M_Type", textBox3.Text);
            cmd.Parameters.AddWithValue("@Address", textBox4.Text);
            cmd.Parameters.AddWithValue("@Date", textBox5.Text);
            cmd.Parameters.AddWithValue("@Expiry_Date", textBox6.Text);
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Updated Successfully");
        }
    }
}
