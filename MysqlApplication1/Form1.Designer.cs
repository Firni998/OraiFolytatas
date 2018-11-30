namespace MysqlApplication1
{
    partial class Form1
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
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.jelszoTextBox = new System.Windows.Forms.TextBox();
            this.szuletesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.regButton = new System.Windows.Forms.Button();
            this.regUserLabel = new System.Windows.Forms.Label();
            this.felhasznalokListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(13, 13);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(259, 20);
            this.nevTextBox.TabIndex = 0;
            // 
            // jelszoTextBox
            // 
            this.jelszoTextBox.Location = new System.Drawing.Point(13, 40);
            this.jelszoTextBox.Name = "jelszoTextBox";
            this.jelszoTextBox.PasswordChar = '*';
            this.jelszoTextBox.Size = new System.Drawing.Size(259, 20);
            this.jelszoTextBox.TabIndex = 1;
            // 
            // szuletesDateTimePicker
            // 
            this.szuletesDateTimePicker.Location = new System.Drawing.Point(13, 67);
            this.szuletesDateTimePicker.Name = "szuletesDateTimePicker";
            this.szuletesDateTimePicker.Size = new System.Drawing.Size(259, 20);
            this.szuletesDateTimePicker.TabIndex = 2;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(98, 93);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 3;
            this.regButton.Text = "Regisztracio";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // regUserLabel
            // 
            this.regUserLabel.AutoSize = true;
            this.regUserLabel.Location = new System.Drawing.Point(95, 161);
            this.regUserLabel.Name = "regUserLabel";
            this.regUserLabel.Size = new System.Drawing.Size(83, 13);
            this.regUserLabel.TabIndex = 5;
            this.regUserLabel.Text = "Reg_User_label";
            // 
            // felhasznalokListBox
            // 
            this.felhasznalokListBox.FormattingEnabled = true;
            this.felhasznalokListBox.Location = new System.Drawing.Point(52, 177);
            this.felhasznalokListBox.Name = "felhasznalokListBox";
            this.felhasznalokListBox.Size = new System.Drawing.Size(174, 199);
            this.felhasznalokListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 504);
            this.Controls.Add(this.felhasznalokListBox);
            this.Controls.Add(this.regUserLabel);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.szuletesDateTimePicker);
            this.Controls.Add(this.jelszoTextBox);
            this.Controls.Add(this.nevTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox jelszoTextBox;
        private System.Windows.Forms.DateTimePicker szuletesDateTimePicker;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label regUserLabel;
        private System.Windows.Forms.ListBox felhasznalokListBox;
    }
}

