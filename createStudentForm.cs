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
    public partial class createStudentForm : Form
    {
        string str = "";
        int id = 0;
        int op, count = 0, count1 = 0;
        int numb;
        int[] stdId = new int[50];
        string[] stdName = new string[50];
        string[] sem = new string[50];
        double[] cgpa = new double[50];
        string[] depart = new string[50];
        string[] uni = new string[50];
        string[] attnd = new string[50];
        public createStudentForm()
        {
            InitializeComponent();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void addstdntbtn_Click(object sender, EventArgs e)
        {
            id++;
            str +=id.ToString() + "\n"+ textBox1.Text + "\n" + semesterTextbox.Text + "\n" + (cgpaTextbox.Text.ToString()) + "\n" + deptTextbox.Text + "\n" + uniTextbox.Text + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\Arife\\Desktop\\vpass2.txt",true);
            txt.Write(str);
            txt.Close();
            MessageBox.Show("Successfully saved");
            textBox1.Text = semesterTextbox.Text = cgpaTextbox.Text = deptTextbox.Text = uniTextbox.Text = null;
        }

        private void semesterTextbox_TextChanged(object sender, EventArgs e)
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

        private void createStudentForm_Load(object sender, EventArgs e)
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
                            id = stdId[count1 + 1];
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
                //MessageBox.Show("File Could not be read");
            }
        }
    }
}
