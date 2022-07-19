using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Add Books
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        //Add Publisher
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        //Add Member
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        //Add BorrowBy
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        //Update Books
        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }

        //Update Publisher
        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }

        //Update Members
        private void button7_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
        }

        //Update BorrowBy
        private void button8_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();
        }

        //Delete Books
        private void button9_Click(object sender, EventArgs e)
        {
            Form10 form = new Form10();
            form.Show();
        }

        //Delete Publisher
        private void button10_Click(object sender, EventArgs e)
        {
            Form11 form = new Form11();
            form.Show();
        }

        //Delete Memeber
        private void button11_Click(object sender, EventArgs e)
        {
            Form12 form = new Form12();
            form.Show();
        }

        //Delete Borrow By
        private void button12_Click(object sender, EventArgs e)
        {
            Form13 form = new Form13();
            form.Show();
        }

        //Show Books
        private void button13_Click(object sender, EventArgs e)
        {
            Form14 form = new Form14();
            form.Show();
        }

        //Show Publisher
        private void button14_Click(object sender, EventArgs e)
        {
            Form15 form = new Form15();
            form.Show();
        }

        //Show Members
        private void button15_Click(object sender, EventArgs e)
        {
            Form16 form = new Form16();
            form.Show();
        }

        //Show BorrowBy
        private void button16_Click(object sender, EventArgs e)
        {
            Form17 form = new Form17();
            form.Show();
        }
    }
}
