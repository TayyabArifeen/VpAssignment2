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
    public partial class Top3Form : Form
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
        public Top3Form()
        {
            InitializeComponent();
        }

        private void Top3Form_Load(object sender, EventArgs e)
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
            //Sort
            int[] sortId = new int[50];
            string[] sortName = new string[50];
            string[] sortSem = new string[50];
            double[] sortCgpa = new double[50];
            string[] sortDepart = new string[50];
            string[] sortUni = new string[50];
            string[] sortAttnd = new string[50];
            for (int i = 1; i <= count1; i++)
            {
                sortId[i] = stdId[i];
                sortName[i] = stdName[i];
                sortSem[i] = sem[i];
                sortCgpa[i] = cgpa[i];
                sortDepart[i] = depart[i];
                sortUni[i] = uni[i];
            }
            double t = 0;
            for (int p = 2; p <= count1 - 1; p++)
            {
                for (int i = 1; i <= count1; i++)
                {
                    if (sortCgpa[i] < sortCgpa[i + 1])
                    {
                        t = sortCgpa[i + 1];
                        sortCgpa[i + 1] = sortCgpa[i];
                        sortCgpa[i] = t;
                    }
                }
            }
            for (int i = 1; i <= count1; i++)
            {
                if (sortCgpa[1] == cgpa[i])
                {
                    idTextbox.Text = stdId[i].ToString();
                    nameTextbox.Text = stdName[i];
                    semTextbox.Text = sem[i];
                    cgpaTextbox.Text = cgpa[i].ToString();
                    deptTextbox.Text = depart[i];
                    uniTextbox.Text = uni[i];
                }
                else if (sortCgpa[2] == cgpa[i])
                {
                    id2Textbox.Text = stdId[i].ToString();
                    name2Textbox.Text = stdName[i];
                    sem2Textbox.Text = sem[i];
                    cgpa2Textbox.Text = cgpa[i].ToString();
                    dept2Textbox.Text = depart[i];
                    uni2Textbox.Text = uni[i];
                }
                else if (sortCgpa[3] == cgpa[i])
                {
                    id3Textbox.Text = stdId[i].ToString();
                    name3Textbox.Text = stdName[i];
                    sem3Textbox.Text = sem[i];
                    cgpa3Textbox.Text = cgpa[i].ToString();
                    dept3Textbox.Text = depart[i];
                    uni3Textbox.Text = uni[i];
                }
                else
                {

                }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
