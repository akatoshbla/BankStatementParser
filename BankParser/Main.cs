using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace BankParser
{
    public partial class Main : Form
    {
        private Dictionary<string, string> dictionary;
        private Dictionary<string, decimal> catagories;
        private decimal credit;
        private decimal debit;

        public Main()
        {
            InitializeComponent();
            this.CenterToScreen();
            catagories = new Dictionary<string, decimal>();
            dictionary = new Dictionary<string, string>();
            savedDataSetup();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();
            browser.DefaultExt = ".csv";
            browser.Filter = "CSV Files| *.csv;";

            DialogResult result = browser.ShowDialog();

            if (result == DialogResult.OK)
            {
                selectedText.Text = browser.FileName;
                parseBtn.Visible = true;
            }

        }

        private void parseBtn_Click(object sender, EventArgs e)
        {
            string file = selectedText.Text;
            credit = 0;
            debit = 0;
            listView.Clear();
            creditLabel.Text = "Credit =";
            debitLabel.Text = "Debit =";
            resetValues();


            if (System.IO.Path.GetExtension(file).Equals(".csv") || System.IO.Path.GetExtension(file).Equals(".CSV"))
            {
                // Code to accept file in selectedText
                progressBar.Visible = true;
                percentText.Visible = true;
                readFile(file);
            } else
            {
                MessageBox.Show("The file selected is not the correct format. Please download the correct comma seperated values file and try again.", "Selected File Error");
            }
        }

        // Details,Posting Date,"Description",Amount,Type,Balance,Check or Slip #
        private void readFile(String file)
        {
            string[] lines = File.ReadAllLines(file);
            progressBar.Value = 0;
            percentText.Text = "0%";
            int progressPerLine = (int) (100 / (lines.Length - 1));
            int percent = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                percentText.Refresh();
                string[] line = lines[i].Split(',');
                int progress = progressBar.Value + progressPerLine;

                if (line[0].ToLower().Equals("debit"))
                {
                    //string[] lineDescription = line[2].Split(' ');
                    string temp = Regex.Replace(line[2].Trim('"'), "[^a-zA-Z_.]+", " "); //lineDescription[0].Trim('"');
                    if (!dictionary.ContainsKey(temp))
                    {
                        // Add to dictionary and add to database.db
                        using (Modal modal = new Modal(temp, line[3].TrimStart('-')))
                        {
                            if (modal.ShowDialog() == DialogResult.OK)
                            {
                                addCatagory(modal.selectedText, Decimal.Parse(line[3].TrimStart('-')));
                                addSavedData(temp, modal.selectedText);
                                decimal value = Decimal.Parse(line[3].TrimStart('-'));
                                catagories[dictionary[temp]] += value;
                                debit += value;
                            }
                        }
                    } else
                    {
                        // Add to catagory total
                        decimal value = Decimal.Parse(line[3].TrimStart('-'));
                        catagories[dictionary[temp]] += value;
                        debit += value;
                    }
                } else if (line[0].ToLower().Equals("credit"))
                {
                    decimal value = Decimal.Parse(line[3]);
                    credit += value;
                }

                if (i > 0)
                {
                    percent = progressPerLine * i;
                }

                if (progress >= 100)
                {
                    progressBar.Value = 100;
                    percentText.Text = "100%";
                } else
                {
                    progressBar.Value = progress;
                    percentText.Text = Convert.ToString(percent) + "%";
                }
                //System.Threading.Thread.Sleep(1000);
            }
            progressBar.Value = 100;
            percentText.Text = "100%";
            showResults();
        }

        private void savedDataSetup()
        {
            string[] cats = File.ReadAllLines(@"catagories.db");
            string[] savedData = File.ReadAllLines(@"database.db");
            
            foreach (string line in cats)
            {
                catagories.Add(line, 0);
                Label label = new Label();
            }

            foreach (string line in savedData)
            {
                string[] temp = line.Split(',');
                dictionary.Add(temp[0], temp[1]);
            }
        }

        private void addCatagory(string name, decimal value)
        {
            if (!catagories.ContainsKey(name))
            {
                catagories.Add(name, value);
                File.AppendAllText(@"catagories.db", Environment.NewLine + name);
            }
        }

        private void addSavedData(string key, string value)
        {
            dictionary.Add(key, value);
            if (File.ReadAllLines(@"database.db").Length == 0)
            {
                File.AppendAllText(@"database.db", key + ',' + value);
            } else
            {
                File.AppendAllText(@"database.db", Environment.NewLine + key + ',' + value);
            }
        }

        private void showResults()
        {
            creditLabel.Visible = true;
            debitLabel.Visible = true;
            listView.Visible = true;

            creditLabel.Text = creditLabel.Text + credit.ToString("C2");
            debitLabel.Text = debitLabel.Text + debit.ToString("C2");
            creditLabel.Refresh();
            debitLabel.Refresh();

            foreach (KeyValuePair<string, decimal> pair in catagories)
            {
                listView.Items.Add(pair.Key.ToString() + " = " + pair.Value.ToString("C2"));
            }
        }

        private void resetValues()
        {
            List<string> keys = new List<string>(catagories.Keys);
            foreach (string key in keys)
            {
                catagories[key] = 0;
            }
        }
    }
}