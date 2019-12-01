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
    public partial class ViewAttendenceForm : Form
    {
        int counta = 0, countb = 0;
        int[] stdId = new int[50];
        string[] stdName = new string[50];
        string[] attnd = new string[50];
        public ViewAttendenceForm()
        {
            InitializeComponent();
        }

        private void ViewAttendenceForm_Load(object sender, EventArgs e)
        {
            try
            {

                using (StreamReader sr = new StreamReader("C:\\Users\\Arife\\Desktop\\vpass2attn.txt"))
                {

                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {

                        //Console.WriteLine(line);
                        if (counta == 0)
                        {
                            stdId[countb + 1] = Convert.ToInt32(line);
                            counta++;
                        }
                        else if (counta == 1)
                        {
                            stdName[countb + 1] = line;
                            counta++;
                        }
                        else if (counta == 2)
                        {
                            attnd[countb + 1] = line;
                            counta = 0;
                            countb++;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show("Error reading file");
            }
            string str1 = "", str2 = "", str3 = "";
             for (int i = 1; i <= countb; i++)
             {
                 str1+= stdId[i].ToString()+"\n";
                 str2+= stdName[i]+"\n";
                 str3+= attnd[i]+"\n";
             }
             idTextbox.Text = str1;
             nameTextbox.Text = str2;
             attndTextbox.Text = str3;
        }
    }
}
