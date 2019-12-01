using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vpAssignment2
{
    public partial class SearchByIdForm : Form
    {
        int op, count = 0, count1 = 0;
        int numb;
        int[] stdId = new int[50];
        string[] stdName = new string[50];
        string[] sem = new string[50];
        double[] cgpa = new double[50];
        string[] depart = new string[50];
        string[] uni = new string[50];
        string[] attnd = new string[50];
        public SearchByIdForm()
        {
            InitializeComponent();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            for (int i = 1; i <= count1; i++)
            {
                int id = Convert.ToInt32(enteridTextbox.Text);
                if (stdId[i] == id)
                {
                    idTextbox.Text = stdId[i].ToString();
                    nameTextbox.Text = stdName[i];
                    semTextbox.Text = sem[i];
                    cgpaTextbox.Text = cgpa[i].ToString();
                    deptTextbox.Text = depart[i];
                    uniTextbox.Text = uni[i];
                    break;
                }
            }
        }

        private void SearchByIdForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("C:\\Users\\Arife\\Desktop\\vpass2.txt", true))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {

                        //Console.WriteLine(line);
                        if (count == 0)
                        {
                            stdId[count1 + 1] = Convert.ToInt32(line);
                            count++;
                        }
                        else if (count == 1)
                        {
                            stdName[count1 + 1] = line;
                            count++;
                        }
                        else if (count == 2)
                        {
                            sem[count1 + 1] = line;
                            count++;
                        }
                        else if (count == 3)
                        {
                            cgpa[count1 + 1] = Convert.ToDouble(line);
                            count++;
                        }
                        else if (count == 4)
                        {
                            depart[count1 + 1] = line;
                            count++;
                        }
                        else if (count == 5)
                        {
                            uni[count1 + 1] = line;
                            count = 0;
                            count1++;
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File Could not be read");
            }
        }

        private void idTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nameTextbox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void semTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cgpaTextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void deptTextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void uniTextbox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
