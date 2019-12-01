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

    public partial class MarkAttendenceForm : Form
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
        public MarkAttendenceForm()
        {
            InitializeComponent();
        }

        private void MarkAttendenceForm_Load(object sender, EventArgs e)
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
            idTextbox.Text = stdId[1].ToString();
            id1Textbox.Text = stdId[2].ToString();
            id2Textbox.Text = stdId[3].ToString();
            nameTextbox.Text = stdName[1];
            name1Textbox.Text = stdName[2];
            name2Textbox.Text = stdName[3];
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string str = "";
            str += idTextbox.Text + "\n" + nameTextbox.Text + "\n" + attndTextbox.Text + "\n";
            str += id1Textbox.Text + "\n" + name1Textbox.Text + "\n" + attnd1Textbox.Text + "\n";
            str += id2Textbox.Text + "\n" + name2Textbox.Text + "\n" + attnd2Textbox.Text + "\n";
            TextWriter txt = new StreamWriter("C:\\Users\\Arife\\Desktop\\vpass2attn.txt", true);
            txt.Write(str);
            txt.Close();
            MessageBox.Show("Successfully saved");
        }
    }
}
