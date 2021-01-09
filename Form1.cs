using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaxOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddWaterMark(startInput_name, "ФИО");
            AddWaterMark(startInput_password, "Пароль");
        }

        private void authorizationButton_Click(object sender, EventArgs e)
        {
            startPanel.Visible = false;
            startPanel.Enabled = false;
            tabControl1.Enabled = true;
            tabControl1.Visible = true;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

        }

        private static void AddWaterMark(TextBox textBox, string watermarkText)
        {
            textBox.ForeColor = SystemColors.GrayText;
            textBox.Text = watermarkText;
            textBox.Leave += (o, e) =>
            {
                if (textBox.Text.Length == 0)
                {
                    textBox.Text = watermarkText;
                    textBox.ForeColor = SystemColors.GrayText;
                }
            };
            textBox.Enter += (o, e) =>
            {
                if (textBox.Text == watermarkText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };
        }
    }
}