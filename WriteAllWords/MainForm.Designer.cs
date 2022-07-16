namespace WriteAllWords
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContainsBox = new System.Windows.Forms.Label();
            this.StartsWithBox = new System.Windows.Forms.Label();
            this.LengthBox = new System.Windows.Forms.Label();
            this.StartInput = new System.Windows.Forms.TextBox();
            this.ContainsInput = new System.Windows.Forms.TextBox();
            this.LengthInput = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContainsBox
            // 
            this.ContainsBox.AutoSize = true;
            this.ContainsBox.Location = new System.Drawing.Point(141, 34);
            this.ContainsBox.Name = "ContainsBox";
            this.ContainsBox.Size = new System.Drawing.Size(54, 15);
            this.ContainsBox.TabIndex = 0;
            this.ContainsBox.Text = "Contains";
            // 
            // StartsWithBox
            // 
            this.StartsWithBox.AutoSize = true;
            this.StartsWithBox.Location = new System.Drawing.Point(33, 34);
            this.StartsWithBox.Name = "StartsWithBox";
            this.StartsWithBox.Size = new System.Drawing.Size(66, 15);
            this.StartsWithBox.TabIndex = 1;
            this.StartsWithBox.Text = "Starts With";
            // 
            // LengthBox
            // 
            this.LengthBox.AutoSize = true;
            this.LengthBox.Location = new System.Drawing.Point(250, 34);
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(44, 15);
            this.LengthBox.TabIndex = 2;
            this.LengthBox.Text = "Length";
            // 
            // StartInput
            // 
            this.StartInput.Location = new System.Drawing.Point(33, 65);
            this.StartInput.Name = "StartInput";
            this.StartInput.Size = new System.Drawing.Size(100, 23);
            this.StartInput.TabIndex = 3;
            this.StartInput.TextChanged += new System.EventHandler(this.StartInput_TextChanged);
            // 
            // ContainsInput
            // 
            this.ContainsInput.Location = new System.Drawing.Point(141, 65);
            this.ContainsInput.Name = "ContainsInput";
            this.ContainsInput.Size = new System.Drawing.Size(100, 23);
            this.ContainsInput.TabIndex = 4;
            this.ContainsInput.TextChanged += new System.EventHandler(this.ContainsInput_TextChanged);
            // 
            // LengthInput
            // 
            this.LengthInput.Location = new System.Drawing.Point(250, 65);
            this.LengthInput.Name = "LengthInput";
            this.LengthInput.Size = new System.Drawing.Size(100, 23);
            this.LengthInput.TabIndex = 5;
            this.LengthInput.TextChanged += new System.EventHandler(this.LengthInput_TextChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(418, 65);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 6;
            this.PrintButton.Text = "Print All";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(530, 138);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.LengthInput);
            this.Controls.Add(this.ContainsInput);
            this.Controls.Add(this.StartInput);
            this.Controls.Add(this.LengthBox);
            this.Controls.Add(this.StartsWithBox);
            this.Controls.Add(this.ContainsBox);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private Label ContainsBox;
        private Label StartsWithBox;
        private Label LengthBox;
        private TextBox StartInput;
        private TextBox ContainsInput;
        private TextBox LengthInput;
        private Button PrintButton;
    }
}