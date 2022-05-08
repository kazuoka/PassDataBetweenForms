
namespace PassDataBetweenForms
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
            this.textBoxForm1 = new System.Windows.Forms.TextBox();
            this.sendToForm2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxForm1
            // 
            this.textBoxForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxForm1.Location = new System.Drawing.Point(196, 112);
            this.textBoxForm1.Name = "textBoxForm1";
            this.textBoxForm1.Size = new System.Drawing.Size(426, 35);
            this.textBoxForm1.TabIndex = 0;
            // 
            // sendToForm2Button
            // 
            this.sendToForm2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendToForm2Button.Location = new System.Drawing.Point(196, 196);
            this.sendToForm2Button.Name = "sendToForm2Button";
            this.sendToForm2Button.Size = new System.Drawing.Size(426, 44);
            this.sendToForm2Button.TabIndex = 1;
            this.sendToForm2Button.Text = "Send To Form 2";
            this.sendToForm2Button.UseVisualStyleBackColor = true;
            this.sendToForm2Button.Click += new System.EventHandler(this.sendToForm2Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendToForm2Button);
            this.Controls.Add(this.textBoxForm1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForm1;
        private System.Windows.Forms.Button sendToForm2Button;
    }
}

