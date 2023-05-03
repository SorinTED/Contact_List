using System;

namespace Contact_List
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addEntryButton = new System.Windows.Forms.Button();
            this.updateEntryButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.sortByNameButton = new System.Windows.Forms.Button();
            this.sortByBirthDateButton = new System.Windows.Forms.Button();
            this.sortByBirthDateDescButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.entriesListBox = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(73, 51);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(284, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // addEntryButton
            // 
            this.addEntryButton.Location = new System.Drawing.Point(55, 418);
            this.addEntryButton.Name = "addEntryButton";
            this.addEntryButton.Size = new System.Drawing.Size(100, 45);
            this.addEntryButton.TabIndex = 3;
            this.addEntryButton.Text = "Add";
            this.addEntryButton.UseVisualStyleBackColor = true;
            this.addEntryButton.Click += new System.EventHandler(this.addEntryButton_Click_1);
            // 
            // updateEntryButton
            // 
            this.updateEntryButton.Location = new System.Drawing.Point(161, 418);
            this.updateEntryButton.Name = "updateEntryButton";
            this.updateEntryButton.Size = new System.Drawing.Size(100, 45);
            this.updateEntryButton.TabIndex = 4;
            this.updateEntryButton.Text = "Update";
            this.updateEntryButton.UseVisualStyleBackColor = true;
            this.updateEntryButton.Click += new System.EventHandler(this.updateEntryButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(267, 418);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 45);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.birthDatePicker);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(438, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 170);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(112, 54);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(210, 20);
            this.birthDatePicker.TabIndex = 41;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(112, 107);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(210, 20);
            this.addressTextBox.TabIndex = 40;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(112, 81);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(210, 20);
            this.phoneNumberTextBox.TabIndex = 39;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(112, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(210, 20);
            this.nameTextBox.TabIndex = 38;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date of Birth";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Location = new System.Drawing.Point(55, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(227, 56);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // sortByNameButton
            // 
            this.sortByNameButton.Location = new System.Drawing.Point(506, 212);
            this.sortByNameButton.Name = "sortByNameButton";
            this.sortByNameButton.Size = new System.Drawing.Size(274, 30);
            this.sortByNameButton.TabIndex = 15;
            this.sortByNameButton.Text = "Order by name";
            this.sortByNameButton.UseVisualStyleBackColor = true;
            this.sortByNameButton.Click += new System.EventHandler(this.sortByNameButton_Click_1);
            // 
            // sortByBirthDateButton
            // 
            this.sortByBirthDateButton.Location = new System.Drawing.Point(506, 266);
            this.sortByBirthDateButton.Name = "sortByBirthDateButton";
            this.sortByBirthDateButton.Size = new System.Drawing.Size(274, 30);
            this.sortByBirthDateButton.TabIndex = 16;
            this.sortByBirthDateButton.Text = "Order by Age(Ascending)";
            this.sortByBirthDateButton.UseVisualStyleBackColor = true;
            this.sortByBirthDateButton.Click += new System.EventHandler(this.sortByBirthDateButton_Click_1);
            // 
            // sortByBirthDateDescButton
            // 
            this.sortByBirthDateDescButton.Location = new System.Drawing.Point(506, 326);
            this.sortByBirthDateDescButton.Name = "sortByBirthDateDescButton";
            this.sortByBirthDateDescButton.Size = new System.Drawing.Size(274, 31);
            this.sortByBirthDateDescButton.TabIndex = 19;
            this.sortByBirthDateDescButton.Text = "Order by Age(Descending)";
            this.sortByBirthDateDescButton.Click += new System.EventHandler(this.sortByBirthDateDescButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(506, 418);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(274, 45);
            this.exportButton.TabIndex = 18;
            this.exportButton.Text = "Export as .txt";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // entriesListBox
            // 
            this.entriesListBox.HideSelection = false;
            this.entriesListBox.Location = new System.Drawing.Point(55, 145);
            this.entriesListBox.Name = "entriesListBox";
            this.entriesListBox.Size = new System.Drawing.Size(312, 243);
            this.entriesListBox.TabIndex = 20;
            this.entriesListBox.UseCompatibleStateImageBehavior = false;
            this.entriesListBox.SelectedIndexChanged += new System.EventHandler(this.entriesListBox_SelectedIndexChanged_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 506);
            this.Controls.Add(this.entriesListBox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.sortByBirthDateDescButton);
            this.Controls.Add(this.sortByBirthDateButton);
            this.Controls.Add(this.sortByNameButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateEntryButton);
            this.Controls.Add(this.addEntryButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addEntryButton;
        private System.Windows.Forms.Button updateEntryButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sortByNameButton;
        private System.Windows.Forms.Button sortByBirthDateButton;
        private System.Windows.Forms.Button sortByBirthDateDescButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button searchButton;
        private EventHandler searchTextBox_TextChanged;
        private System.Windows.Forms.ListView entriesListBox;
    }
}

