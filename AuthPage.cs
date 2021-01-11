using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxOffice.Database;
using TaxOffice.Database.Models;

namespace TaxOffice
{
    public partial class Form1
    {
        private async void authorizationButton_Click(object sender, EventArgs e)
        {
            var fullName = startInput_name.Text;
            var password = startInput_password.Text;
            if (fullName == "ФИО" || password == "Пароль")
            {
                MessageBox.Show("Поля ФИО и Пароль должны быть заполнены");
                return;
            }

            var selectedUser = TaxOfficeDb.Select<User>(u => u.FullName == fullName)
                .SingleOrDefault();
            if (selectedUser == null)
            {
                MessageBox.Show($"Пользователь {fullName} не зарегистрирован в системе");
                return;
            }

            if (selectedUser.Password != password)
            {
                MessageBox.Show($"Введён неверный пароль для пользователя {fullName}");
                return;
            }

            if (selectedUser.Role == Role.None)
            {
                MessageBox.Show($"Учётная запись пользователя {fullName} ожидает подтверждения администратора");
                return;
            }

            tabControl1.Controls.Clear();
            tabControl1.Controls.Add(profilePage);
            tabControl1.Controls.Add(ticketsPage);
            if (selectedUser.Role == Role.Admin)
            {
                tabControl1.Controls.Add(registrationPage);
                tabControl1.Controls.Add(historyPage);
                tabControl1.Controls.Add(employeesPage);
            }

            user = selectedUser;
            LoadProfilePage();
            startPanel.Visible = false;
            startPanel.Enabled = false;
            tabControl1.Enabled = true;
            tabControl1.Visible = true;
            LogHistory(HistoryActions.Authorize, false);
            await Task.WhenAll(
                LoadTicketPageAsync(),
                LoadRegistrationPageAsync(),
                LoadHistoryPageAsync()
            );
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            var fullName = startInput_name.Text;
            var password = startInput_password.Text;
            if (fullName == "ФИО" || password == "Пароль")
            {
                MessageBox.Show("Поля ФИО и Пароль должны быть заполнены");
                return;
            }

            var alreadyExists = TaxOfficeDb.Select<User>(u => u.FullName == fullName && u.Password == password)
                .Any();
            if (alreadyExists)
            {
                MessageBox.Show($"Пользователь {fullName} уже существует");
                return;
            }

            TaxOfficeDb.Insert(() => new User {FullName = fullName, Password = password, Role = Role.None});
            user = TaxOfficeDb.Select<User>(u => u.FullName == fullName).Single();
            LogHistory(HistoryActions.Register, false);
            MessageBox.Show($"Пользователь {fullName} зарегистрирован, дождитесь подтверждения администратора");
        }
    }
}