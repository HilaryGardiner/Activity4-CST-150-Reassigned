namespace Activity4App
{
    partial class Form1
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
            this.numberOfSecondsElapsedLabel = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.conversionOutputLabel = new System.Windows.Forms.Label();
            this.outputResultLabel = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberOfSecondsElapsedLabel
            // 
            this.numberOfSecondsElapsedLabel.AutoSize = true;
            this.numberOfSecondsElapsedLabel.Location = new System.Drawing.Point(40, 86);
            this.numberOfSecondsElapsedLabel.Name = "numberOfSecondsElapsedLabel";
            this.numberOfSecondsElapsedLabel.Size = new System.Drawing.Size(311, 25);
            this.numberOfSecondsElapsedLabel.TabIndex = 0;
            this.numberOfSecondsElapsedLabel.Text = "Enter the number of seconds elapsed:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(370, 83);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(192, 31);
            this.textBoxInput.TabIndex = 1;
            // 
            // conversionOutputLabel
            // 
            this.conversionOutputLabel.AutoSize = true;
            this.conversionOutputLabel.Location = new System.Drawing.Point(184, 166);
            this.conversionOutputLabel.Name = "conversionOutputLabel";
            this.conversionOutputLabel.Size = new System.Drawing.Size(167, 25);
            this.conversionOutputLabel.TabIndex = 2;
            this.conversionOutputLabel.Text = "Conversion Output:";
            // 
            // outputResultLabel
            // 
            this.outputResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputResultLabel.Location = new System.Drawing.Point(357, 166);
            this.outputResultLabel.Name = "outputResultLabel";
            this.outputResultLabel.Size = new System.Drawing.Size(230, 27);
            this.outputResultLabel.TabIndex = 3;
            this.outputResultLabel.Text = " ";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(370, 237);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(212, 56);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.outputResultLabel);
            this.Controls.Add(this.conversionOutputLabel);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.numberOfSecondsElapsedLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label numberOfSecondsElapsedLabel;
        private TextBox textBoxInput;
        private Label conversionOutputLabel;
        private Label outputResultLabel;
        private Button buttonConvert;
    }
}