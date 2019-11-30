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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searchIdbtn_Click(object sender, EventArgs e)
        {
            SearchByIdForm click = new SearchByIdForm();
            click.Show();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void searchNamebtn_Click(object sender, EventArgs e)
        {
            SearchbynameForm click = new SearchbynameForm();
            click.Show();
        }
    }
}
