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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Contact_List
{

    public partial class MainForm : Form
    {
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private const string FilePath = "entries.txt";  
        private List<Entry> entries = new List<Entry>();
       
        public MainForm()
        {
            InitializeComponent();
            LoadEntries();
            UpdateEntriesListBox();

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {   

            // Convert the entries to lines of text
            string[] lines = entries.Select(entry => $"{entry.Name}-{entry.Address}-{entry.PhoneNumber}-{entry.BirthDate:yyyy-MM-dd}").ToArray();

            // Write the lines to the file
            File.WriteAllLines(FilePath, lines);

            DialogResult dialogResult = MessageBox.Show("Are you sure, you want to exit ?                  ", "Application Name", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (Application.OpenForms.Count == 0)
                    Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text;

            // Filter the list of entries based on the search criteria
            if (!string.IsNullOrEmpty(searchText))
            {
                entriesListBox.Items.Clear();
                foreach (var entry in entries)
                {
                    if (entry.Name.Contains(searchText) || entry.PhoneNumber.Contains(searchText))
                    {
                        entriesListBox.Items.Add(entry.Name);
                    }
                }
            }
            else
            {
                // If the search bar is left empty, display all entries
                entriesListBox.Items.Clear();
                foreach (var entry in entries)
                {
                    entriesListBox.Items.Add(entry.Name);
                }
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addEntryButton_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the AddEntry form
            using (var form = new AddEntryForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Add the new entry to the list
                    entries.Add(form.Entry);

                    // Update the entriesListBox with the new entry
                    entriesListBox.Items.Add(form.Entry.Name);
                }
            }
            
        }

        private void updateEntryButton_Click(object sender, EventArgs e)
        {
            // Check that an item is selected in the list
            if (entriesListBox.SelectedItems.Count > 0)
            {
                // Get the selected item
                var selectedItem = entriesListBox.SelectedItems[0];

                // Get the index of the selected item
                var selectedIndex = selectedItem.Index;

                // Check that the index is within the valid range for the entries array
                if (selectedIndex >= 0 && selectedIndex < entries.Count)
                {
                    // Get the selected entry
                    var selectedEntry = entries[selectedIndex];

                    // Open the form for updating the entry
                    using (var form = new UpdateEntryForm())
                    {
                        form.nameTextBox.Text = selectedEntry.Name;
                        form.addressTextBox.Text = selectedEntry.Address;
                        form.phoneNumberTextBox.Text = selectedEntry.PhoneNumber;
                        form.birthDatePicker.Value = selectedEntry.BirthDate;

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            // Update the entry with the new data
                            selectedEntry.Name = form.nameTextBox.Text;
                            selectedEntry.Address = form.addressTextBox.Text;
                            selectedEntry.PhoneNumber = form.phoneNumberTextBox.Text;
                            selectedEntry.BirthDate = form.birthDatePicker.Value;

                            // Update the entriesListView with the updated entry
                            selectedItem.SubItems[0].Text = selectedEntry.Name;
                            //selectedItem.SubItems[1].Text = selectedEntry.Address;
                            //selectedItem.SubItems[2].Text = selectedEntry.PhoneNumber;
                            //selectedItem.SubItems[3].Text = selectedEntry.BirthDate.ToShortDateString();
                        }
                    }
                }
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Check that an item is selected in the list
            if (entriesListBox.SelectedIndices.Count > 0)
            {
                // Get the index of the selected item
                var selectedIndex = entriesListBox.SelectedIndices[0];

                // Remove the selected entry from the list
                entries.RemoveAt(selectedIndex);

                // Update the entriesListBox
                entriesListBox.Items.RemoveAt(selectedIndex);
            }
        }

        private void sortByNameButton_Click_1(object sender, EventArgs e)
        {
            // Sort the list of entries by name
            entries.Sort((a, b) => a.Name.CompareTo(b.Name));

            // Update the entriesListBox with the sorted list of entries
            UpdateEntriesListBox();
        }

        private void sortByBirthDateButton_Click_1(object sender, EventArgs e)
        {
            // Sort the list of entries by birth date
            entries.Sort((a, b) => a.BirthDate.CompareTo(b.BirthDate));

            // Update the entriesListBox with the sorted list of entries
            UpdateEntriesListBox();
        }

        private void sortByBirthDateDescButton_Click(object sender, EventArgs e)
        {
            // Sort the list of entries by age in descending order
            entries.Sort((a, b) => -a.BirthDate.CompareTo(b.BirthDate));

            // Update the entriesListBox with the sorted list of entries
            UpdateEntriesListBox();
        }

        private void LoadEntries()
        {
            // Check if the file exists
            if (File.Exists(FilePath))
            {
                // Read the lines from the file
                string[] lines = File.ReadAllLines(FilePath);

                // Parse the lines into Entry objects
                entries = lines.Select(line =>
                {
                    string[] parts = line.Split('-');
                    string dateString = parts[3].Trim() + "-" + parts[4].Trim() + "-" + parts[5].Trim();
                    return new Entry
                    {
                        Name = parts[0].Trim(),
                        Address = parts[1].Trim(),
                        PhoneNumber = parts[2].Trim(),
                        BirthDate = DateTime.Parse(dateString)
                };
                }).ToList();
            }
        }
        private void UpdateEntriesListBox()
        {
            entriesListBox.Items.Clear();
            foreach (var entry in entries)
            {
                entriesListBox.Items.Add(entry.Name);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            // Show the save file dialog
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path selected by the user
                string filePath = saveFileDialog.FileName;

                // Convert the entries to lines of text
                string[] lines = entries.Select(entry => $"{entry.Name}-{entry.Address}-{entry.PhoneNumber}-{entry.BirthDate:yyyy-MM-dd}").ToArray();

                // Write the lines to the file
                File.WriteAllLines(filePath, lines);
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void entriesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (entriesListBox.SelectedItems.Count > 0)
            {
                // Get the selected item
                var selectedItem = entriesListBox.SelectedItems[0];

                // Get the index of the selected item
                var selectedIndex = selectedItem.Index;

                // Check that the index is within the valid range for the entries array
                if (selectedIndex >= 0 && selectedIndex < entries.Count)
                {
                    // Get the selected entry
                    var selectedEntry = entries[selectedIndex];

                    // Autocomplete the data to the textboxes and date time picker
                    nameTextBox.Text = selectedEntry.Name;
                    addressTextBox.Text = selectedEntry.Address;
                    phoneNumberTextBox.Text = selectedEntry.PhoneNumber;
                    if (birthDatePicker.MinDate <= selectedEntry.BirthDate && selectedEntry.BirthDate <= birthDatePicker.MaxDate)
                    {
                        birthDatePicker.Value = selectedEntry.BirthDate;
                    }
                    else
                    {
                        // Display an error message or take some other action
                        MessageBox.Show("Invalid date!");
                    }
                }
            }
        }
    }
}