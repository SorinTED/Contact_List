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
    public partial class UpdateEntryForm : Form
    {
        public Entry Entry { get; set; }

        public UpdateEntryForm()
        {
            InitializeComponent();
        }

        public void UpdateEntryForm_Load(object sender, EventArgs e)
        {

        }


        public void saveButton_Click(object sender, EventArgs e)
        {
            Entry = new Entry
            {
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                BirthDate = birthDatePicker.Value
            };

            DialogResult = DialogResult.OK;
        }

        public void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void birthDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
