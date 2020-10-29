using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserModelSpace;

namespace TextFileChallenge
{



    public partial class Form1 : Form
    {
        BindingList<UserModel> users = new BindingList<UserModel>();

        public Form1()
        {
            InitializeComponent();

            LoadListfromFile();

            WireUpDropDown();
        }


        private void LoadListfromFile()
        {
            int firstNameOrder = 0;
            int lastNameOrder = 0;
            int ageOrder = 0;
            int isAliveOrder = 0;

            String[] lines = File.ReadAllLines("StandardDataSet.csv");

            string[] headers = lines[0].Split(',');

            for (int i = 0; i < headers.Length; i++)
            {
                if (headers[i] == "FirstName") firstNameOrder = i;
                else if (headers[i] == "LastName") lastNameOrder = i;
                else if (headers[i] == "Age") ageOrder = i;
                else if (headers[i] == "isAlive") isAliveOrder = i;
            }

            //i = 1 for avoid the atributes name of .csv
            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');
                bool isAlive = false;

                if (columns[isAliveOrder] == "1")
                {
                    isAlive = true;
                }

                users.Add(new UserModel
                {
                    FirstName = columns[firstNameOrder],
                    LastName = columns[lastNameOrder],
                    Age = int.Parse(columns[ageOrder]),
                    IsAlive = isAlive
                });
            }
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = users;
            usersListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserModel person = new UserModel();

            users.Add(new UserModel
            {
                FirstName = FirstNameTextbox.Text,
                LastName = LastNameTextBox.Text,
                Age = (int)AgenumericUpDown.Value,
                IsAlive = IsAliveCheckBox.Checked
            });

            FirstNameTextbox.Text = "";
            LastNameTextBox.Text = "";
            AgenumericUpDown.Value = 0;
            IsAliveCheckBox.Checked = false;
        }

        private void saveListButton_Click(object sender, EventArgs e) { 

            List<string> lines = new List<string>();

            lines.Add("FirstName,LastName,Age,IsAlive");

            foreach (UserModel user in users)
            {
                int isAliveValue = 0;

                if (user.IsAlive == true) isAliveValue = 1;
                lines.Add( $"{user.FirstName} , {user.LastName}, {user.Age}, {isAliveValue}");
            }

            File.WriteAllLines("StandardDataSet.csv", lines);
            MessageBox.Show("Save Completed");
        }
    }
 }

