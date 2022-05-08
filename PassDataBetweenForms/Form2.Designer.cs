
namespace PassDataBetweenForms
{
    partial class Form2
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
            this.sendToForm1Button = new System.Windows.Forms.Button();
            this.textBoxForm2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendToForm1Button
            // 
            this.sendToForm1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendToForm1Button.Location = new System.Drawing.Point(201, 188);
            this.sendToForm1Button.Name = "sendToForm1Button";
            this.sendToForm1Button.Size = new System.Drawing.Size(426, 44);
            this.sendToForm1Button.TabIndex = 3;
            this.sendToForm1Button.Text = "Send To Form 1";
            this.sendToForm1Button.UseVisualStyleBackColor = true;
            this.sendToForm1Button.Click += new System.EventHandler(this.sendToForm1Button_Click);
            // 
            // textBoxForm2
            // 
            this.textBoxForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForm2.Location = new System.Drawing.Point(201, 104);
            this.textBoxForm2.Name = "textBoxForm2";
            this.textBoxForm2.Size = new System.Drawing.Size(426, 35);
            this.textBoxForm2.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendToForm1Button);
            this.Controls.Add(this.textBoxForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendToForm1Button;
        private System.Windows.Forms.TextBox textBoxForm2;
    }
}