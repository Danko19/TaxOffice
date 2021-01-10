using System.Drawing;
using System.Windows.Forms;
using TaxOffice.Database.Models;

namespace TaxOffice
{
    public partial class Form1 : Form
    {
        private User user;

        public Form1()
        {
            InitializeComponent();
            AddWaterMark(startInput_name, "ФИО", false);
            AddWaterMark(startInput_password, "Пароль", true);
            startPanel.Select();
        }

        private static void AddWaterMark(TextBox textBox, string watermarkText, bool hidePassword)
        {
            textBox.ForeColor = SystemColors.GrayText;
            textBox.Text = watermarkText;
            textBox.Leave += (o, e) =>
            {
                if (textBox.Text.Length == 0)
                {
                    textBox.Text = watermarkText;
                    textBox.ForeColor = SystemColors.GrayText;
                    textBox.PasswordChar = '\0';
                }
            };
            textBox.Enter += (o, e) =>
            {
                if (textBox.Text == watermarkText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }

                if (hidePassword)
                    textBox.PasswordChar = '*';
            };
        }
    }
}