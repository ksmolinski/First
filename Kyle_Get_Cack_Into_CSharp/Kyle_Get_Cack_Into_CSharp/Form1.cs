using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Kyle_Get_Cack_Into_CSharp
{
    public partial class Form1 : Form
    {

        public static List<string> passwordChoices = new List<string>();  
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {

                using (StreamReader sr = new StreamReader(textBox1.Text)) 
                {
                    string line; 
                    while ((line = sr.ReadLine()) != null) 
                    {
                        passwordChoices.Add(line);
                    }
                }
                foreach (string p in passwordChoices)
                {
                    listBox1.Items.Add(p);
                }
                Random kyle = new Random();
                int picker = kyle.Next(0, (passwordChoices.Count - 1));

                string one = passwordChoices[picker];
                picker = kyle.Next(0, (passwordChoices.Count - 1));
                string two = passwordChoices[picker];

                string password = one + two;
                label1.Text = password;
                password = null;
            }
        catch (Exception i) 
        {
            MessageBox.Show(i.Message);
        }



        }
    }
}
