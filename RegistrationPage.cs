using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxOffice.Database;
using TaxOffice.Database.Models;

namespace TaxOffice
{
    public partial class Form1
    {
        private async Task LoadRegistrationPageAsync()
        {
            var panels = await Task.Run(() =>
                TaxOfficeDb.Select<User>(u => u.Role == Role.None).Select(CreateRegistrationPanel).ToArray());
            foreach (var panel in panels)
                AddRegistrationPanel(panel);
        }

        private void AddRegistrationPanel(Panel panel)
        {
            registrationPage_registrationsPanel.RowCount++;
            registrationPage_registrationsPanel.RowStyles.Insert(registrationPage_registrationsPanel.RowCount - 2,
                new RowStyle(SizeType.AutoSize));
            registrationPage_registrationsPanel.Controls.Add(panel, 0,
                registrationPage_registrationsPanel.RowCount - 2);
        }

        private Panel CreateRegistrationPanel(User registeredUser)
        {
            var fullNameLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 8.25F, FontStyle.Regular,
                    GraphicsUnit.Point, 204),
                Location = new Point(194, 30),
                Text = "ФИО"
            };
            var emailLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Arial", 8.25F, FontStyle.Regular,
                    GraphicsUnit.Point, 204),
                Location = new Point(515, 30),
                Text = "Дата регистрации"
            };
            var fullNameTextBox = new Label
            {
                Location = new Point(10, 3),
                Size = new Size(400, 26),
                TabIndex = 1,
                Text = registeredUser.FullName,
                TextAlign = ContentAlignment.MiddleCenter
            };
            var dateTextBox = new Label
            {
                Location = new Point(420, 3),
                Size = new Size(290, 26),
                TabIndex = 2,
                Text = "26.11.1998",
                TextAlign = ContentAlignment.MiddleCenter
            };
            var acceptButton = new Button
            {
                Location = new Point(256, 47),
                Size = new Size(100, 25),
                TabIndex = 3,
                Text = "Принять",
                UseVisualStyleBackColor = true
            };
            var declineButton = new Button
            {
                Location = new Point(362, 47),
                Size = new Size(100, 25),
                TabIndex = 4,
                Text = "Отклонить",
                UseVisualStyleBackColor = true
            };

            var panel = new Panel {BorderStyle = BorderStyle.FixedSingle};
            panel.SuspendLayout();
            panel.Controls.Add(fullNameTextBox);
            panel.Controls.Add(dateTextBox);
            panel.Controls.Add(fullNameLabel);
            panel.Controls.Add(emailLabel);
            panel.Controls.Add(acceptButton);
            panel.Controls.Add(declineButton);
            panel.Location = new Point(5, 5);
            panel.Margin = new Padding(5);
            panel.Size = new Size(715, 75);

            acceptButton.Click += (sender, args) =>
            {
                TaxOfficeDb.Update<User>(u => u.Id == registeredUser.Id, u => new User {Role = Role.Employee});
                DeletePanel();
            };
            declineButton.Click += (sender, args) =>
            {
                TaxOfficeDb.Delete<User>(u => u.Id == registeredUser.Id);
                DeletePanel();
            };

            void DeletePanel()
            {
                var rowIndex = registrationPage_registrationsPanel.GetRow(panel);
                registrationPage_registrationsPanel.RowStyles.RemoveAt(rowIndex);
                registrationPage_registrationsPanel.Controls.Remove(panel);
                registrationPage_registrationsPanel.RowCount--;
            }

            panel.ResumeLayout(false);
            panel.PerformLayout();
            return panel;
        }
    }
}