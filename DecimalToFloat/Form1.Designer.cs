
namespace DecimalToFloat
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
            this.redText = new System.Windows.Forms.TextBox();
            this.greenText = new System.Windows.Forms.TextBox();
            this.blueText = new System.Windows.Forms.TextBox();
            this.alphaText = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.alphaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redText
            // 
            this.redText.Location = new System.Drawing.Point(53, 104);
            this.redText.Name = "redText";
            this.redText.Size = new System.Drawing.Size(100, 23);
            this.redText.TabIndex = 0;
            // 
            // greenText
            // 
            this.greenText.Location = new System.Drawing.Point(159, 104);
            this.greenText.Name = "greenText";
            this.greenText.Size = new System.Drawing.Size(100, 23);
            this.greenText.TabIndex = 1;
            // 
            // blueText
            // 
            this.blueText.Location = new System.Drawing.Point(265, 104);
            this.blueText.Name = "blueText";
            this.blueText.Size = new System.Drawing.Size(100, 23);
            this.blueText.TabIndex = 2;
            // 
            // alphaText
            // 
            this.alphaText.Location = new System.Drawing.Point(371, 104);
            this.alphaText.Name = "alphaText";
            this.alphaText.Size = new System.Drawing.Size(100, 23);
            this.alphaText.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(196, 188);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(136, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert!";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(53, 83);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(27, 15);
            this.redLabel.TabIndex = 5;
            this.redLabel.Text = "Red";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(159, 83);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(38, 15);
            this.greenLabel.TabIndex = 6;
            this.greenLabel.Text = "Green";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(265, 86);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(30, 15);
            this.blueLabel.TabIndex = 7;
            this.blueLabel.Text = "Blue";
            // 
            // alphaLabel
            // 
            this.alphaLabel.AutoSize = true;
            this.alphaLabel.Location = new System.Drawing.Point(371, 86);
            this.alphaLabel.Name = "alphaLabel";
            this.alphaLabel.Size = new System.Drawing.Size(38, 15);
            this.alphaLabel.TabIndex = 8;
            this.alphaLabel.Text = "Alpha";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 282);
            this.Controls.Add(this.alphaLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.alphaText);
            this.Controls.Add(this.blueText);
            this.Controls.Add(this.greenText);
            this.Controls.Add(this.redText);
            this.Name = "MainForm";
            this.Text = "RGB Float To PPC Hex value converter.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox redText;
        private System.Windows.Forms.TextBox greenText;
        private System.Windows.Forms.TextBox blueText;
        private System.Windows.Forms.TextBox alphaText;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label alphaLabel;
    }
}

