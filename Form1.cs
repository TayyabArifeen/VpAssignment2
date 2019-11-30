using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpAssignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createStudentForm click = new createStudentForm();
            click.Show();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            SearchForm click = new SearchForm();
            click.Show();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            deleteForm click = new deleteForm();
            click.Show();
        }
    }
}
