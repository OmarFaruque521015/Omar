using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoWinApp
{
    public partial class PersonalInfo : Form
    {
        string firstName;
        string lastName;
        string fatherName;
        string motherName;
        string address;

        public PersonalInfo()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;
                fatherName = fatherNameTextBox.Text;
                motherName = motherNameTextBox.Text;
                address = addressTextBox.Text;

                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

            private void ShowButton_Click(object sender, EventArgs e)
            {
                MessageBox.Show("First Name: " +firstName +"\n"+ "Last Name: " + lastName + "\n" + "Father's Name: " +
                    fatherName + "\n" + "Mother's Name: " + motherName + "\n" + "Address: " + address);
            }

        private void NameButton_Click(object sender, EventArgs e)
        {
            string name = firstName +" "+ lastName;

            MessageBox.Show("Name: " + name);
        }

        private void ParentsNameButton_Click(object sender, EventArgs e)
        {
            string parentsName = "\n" + fatherName +"\n"+ motherName;

            MessageBox.Show("Parents Name: " + parentsName);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address: " + address);
        }
    }
}
