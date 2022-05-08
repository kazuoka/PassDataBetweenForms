using System;
using System.Windows.Forms;

namespace PassDataBetweenForms
{
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
            textBoxForm2.Text = text;
        }

        private void sendToForm1Button_Click(object sender, EventArgs e)
        {

            Form1.value = textBoxForm2.Text;
            this.Close();

        }
    }
}
