﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PAV___Tracing_Form
{
    public partial class Form1 : Form
    {
        List<string> Details = new List<string>();
        List<string> fullDetails = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if (x.Name.EndsWith("TB"))
                    {
                        x.Text = "";
                    }
                }
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if(x is TextBox)
                {
                    if(x.Text == "")
                    {
                        String Title = "Contact Tracing Form";
                        Button confirm = (Button)sender;
                        confirm.DialogResult = DialogResult.OK;
                        MessageBox.Show("Please complete the form.", Title);
                        break;
                    }
                    else if(x.Text != "")
                    {
                        Details.Add(FirstnameTB.Text);
                        Details.Add(LastnameTB.Text);
                        Details.Add(StreetAddressTB.Text);
                        Details.Add(CityTB.Text);
                        Details.Add(ProvinceTB.Text);
                        Details.Add(PostalCodeTB.Text);
                        Details.Add(SexTB.Text);
                        Details.Add(DateOfBirthTB.Text);
                        fullDetails.AddRange(Details);
     
                        string data = String.Join(",", fullDetails); 
                        TextWriter txt = new StreamWriter("C:\\Users\\paula\\source\\repos\\PAV - Tracing Form\\Details.txt");
                        txt.Write(data, Environment.NewLine);
                        txt.Close();

                        String Title = "Contact Tracing Form";
                        Button confirm = (Button)sender;
                        confirm.DialogResult = DialogResult.OK;
                        MessageBox.Show("Thank you for your response!", Title);
                        break;
                    }
                    
                }
            }
        }
    }
}

