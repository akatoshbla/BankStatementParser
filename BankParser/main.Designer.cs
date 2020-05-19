namespace BankParser
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectedText = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.parseBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.percentText = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.debitLabel = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank File (.csv)";
            // 
            // selectedText
            // 
            this.selectedText.Location = new System.Drawing.Point(100, 13);
            this.selectedText.Name = "selectedText";
            this.selectedText.ReadOnly = true;
            this.selectedText.Size = new System.Drawing.Size(329, 20);
            this.selectedText.TabIndex = 1;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(435, 12);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // parseBtn
            // 
            this.parseBtn.Location = new System.Drawing.Point(196, 55);
            this.parseBtn.Name = "parseBtn";
            this.parseBtn.Size = new System.Drawing.Size(121, 36);
            this.parseBtn.TabIndex = 3;
            this.parseBtn.Text = "Begin Parse";
            this.parseBtn.UseVisualStyleBackColor = true;
            this.parseBtn.Visible = false;
            this.parseBtn.Click += new System.EventHandler(this.parseBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(100, 98);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(329, 23);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            // 
            // percentText
            // 
            this.percentText.AutoSize = true;
            this.percentText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentText.Location = new System.Drawing.Point(431, 101);
            this.percentText.Name = "percentText";
            this.percentText.Size = new System.Drawing.Size(32, 20);
            this.percentText.TabIndex = 5;
            this.percentText.Text = "0%";
            this.percentText.Visible = false;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.Color.Green;
            this.creditLabel.Location = new System.Drawing.Point(96, 136);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(72, 20);
            this.creditLabel.TabIndex = 6;
            this.creditLabel.Text = "Credit =";
            this.creditLabel.Visible = false;
            // 
            // debitLabel
            // 
            this.debitLabel.AutoSize = true;
            this.debitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitLabel.ForeColor = System.Drawing.Color.Red;
            this.debitLabel.Location = new System.Drawing.Point(362, 136);
            this.debitLabel.Name = "debitLabel";
            this.debitLabel.Size = new System.Drawing.Size(67, 20);
            this.debitLabel.TabIndex = 7;
            this.debitLabel.Text = "Debit =";
            this.debitLabel.Visible = false;
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(100, 159);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(329, 246);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.Visible = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 417);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.debitLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.percentText);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.parseBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.selectedText);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "Bank File Parser v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedText;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button parseBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label percentText;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label debitLabel;
        private System.Windows.Forms.ListView listView;
    }
}

