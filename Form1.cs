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
    public partial class Form1 : Form
    {
        int op, count = 0,count1=0;
                int numb ;
                int[] stdId = new int[50];
                string[] stdName = new string[50];
                string[] sem = new string[50];
                double[] cgpa = new double[50];
                string[] depart = new string[50];
                string[] uni = new string[50];
                string[] attnd = new string[50];
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

        private void Form1_Load(object sender, EventArgs e)
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

        private void markattndbtn_Click(object sender, EventArgs e)
        {
            MarkAttendenceForm click = new MarkAttendenceForm();
            click.Show();
        }

        private void viewattndbtn_Click(object sender, EventArgs e)
        {
            ViewAttendenceForm click = new ViewAttendenceForm();
            click.Show();
        }

        private void top3btn_Click(object sender, EventArgs e)
        {
            Top3Form click = new Top3Form();
            click.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
