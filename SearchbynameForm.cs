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
    public partial class SearchbynameForm : Form
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
        public SearchbynameForm()
        {
            InitializeComponent();
        }

        private void SearchbynameForm_Load(object sender, EventArgs e)
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

        private void searchbtn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            string strId = "", strName = "", strsem = "", strcgpa = "", strdept = "", struni = "";
            for (int i = 1; i <= count1; i++)
            {
                if (stdName[i] == enternameTextbox.Text)
                {
                    strId += stdId[i].ToString() + "\n";
                    strName += stdName[i] + "\n";
                    strsem += sem[i] + "\n";
                    strcgpa += cgpa[i].ToString() + "\n";
                    strdept += depart[i] + "\n";
                    struni += uni[i] + "\n";
                }
            }
            idTextbox.Text = strId;
            nameTextbox.Text = strName;
            semTextbox.Text = strsem;
            cgpaTextbox.Text = strcgpa;
            deptTextbox.Text = strdept;
            uniTextbox.Text = struni;
        }
    }
}
