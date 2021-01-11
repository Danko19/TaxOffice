using System.Linq;
using System.Threading.Tasks;
using TaxOffice.Database;
using TaxOffice.Database.Models;

namespace TaxOffice
{
    public partial class Form1
    {
        private async Task LoadHistoryPageAsync()
        {
            var historyItems = await Task.Run(() => TaxOfficeDb
                .Select<HistoryItem>(hi => true)
                .OrderBy(hi => hi.TimestampTicks)
                .ToArray());
            foreach (var historyItem in historyItems)
                AddHistoryItem(historyItem);
        }

        private void AddHistoryItem(HistoryItem historyItem)
        {
            historyPage_listBox.Items.Insert(0, historyItem.ToPrettyString());
        }

        private void LogHistory(string action, bool add = true)
        {
            var historyItem = new HistoryItem
            {
                UserId = user.Id,
                Action = action
            };
            TaxOfficeDb.Insert(() => new HistoryItem
            {
                UserId = historyItem.UserId,
                Action = historyItem.Action,
                TimestampTicks = historyItem.Timestamp.Ticks
            });
            if (add)
                AddHistoryItem(historyItem);
        }
    }
}