using System;
using System.IO;
using System.Windows.Forms;

namespace BankParser
{
    public partial class Modal : Form
    {
        public string selectedText { get; set; } 

        public Modal(string transaction, string value)
        {
            InitializeComponent();
            this.CenterToScreen();
            setupForm(transaction, value);
        }

        public void setupForm(string transaction, string value)
        {
            name.Text = transaction;
            amount.Text = value;
            string[] lines = File.ReadAllLines(@"catagories.db");

            dropDown.Items.Add("");
            foreach (String line in lines) 
            {
                dropDown.Items.Add(line);
            }
        }

        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDown.Text.Length > 0)
            {
                other.Enabled = false;
            } else
            {
                other.Enabled = true;
            }
        }

        private void other_TextChanged(object sender, EventArgs e)
        {
            if (other.Text.Length > 0)
            {
                dropDown.Enabled = false;
            } else
            {
                dropDown.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (other.Enabled == true)
            {
                selectedText = other.Text;
            } else
            {
                selectedText = dropDown.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}