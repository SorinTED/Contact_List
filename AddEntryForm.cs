using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_List
{
    public partial class AddEntryForm : Form
    {
        public Entry Entry { get; set; }

        public AddEntryForm()
        {
            InitializeComponent();
        }

        private void AddEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void createEntry_Click(object sender, EventArgs e)
        {

            Entry = new Entry
            {
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                BirthDate = birthDatePicker.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
