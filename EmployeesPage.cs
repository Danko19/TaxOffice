using System;
using System.Linq;
using System.Threading.Tasks;
using TaxOffice.Database;
using TaxOffice.Database.Models;

namespace TaxOffice
{
    public partial class Form1
    {
        private async void employeesPage_searchTextBox_TextChanged(object sender, EventArgs e)
        {
            await UpdateEmployeesList();
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == employeesPage)
                await UpdateEmployeesList();
        }

        private async Task UpdateEmployeesList()
        {
            employeesPage_listBox.Items.Clear();
            employeesPage_listBox.Items.Add("Загрузка...");
            var searchString = employeesPage_searchTextBox.Text;
            object[] userInfos = await Task.Run(() =>
            {
                return TaxOfficeDb.Select<User>(u => true)
                    .Select(u => u.ToString())
                    .Where(ui => string.IsNullOrWhiteSpace(searchString) || searchString == "Поиск" || ui.ToLower().Contains(searchString.ToLower()))
                    .ToArray();
            });
            employeesPage_listBox.Items.Clear();
            employeesPage_listBox.Items.AddRange(userInfos);
        }
    }
}