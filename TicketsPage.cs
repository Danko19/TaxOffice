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
        private async Task LoadTicketPageAsync()
        {
            var panels = await Task.Run(() => TaxOfficeDb.Select<Ticket>(t => true).Select(CreateTicketPanel).ToArray());
            foreach (var panel in panels)
                AddTicketPanel(panel);
        }

        private void ticketsPage_addButton_Click(object sender, EventArgs e)
        {
            var panel = CreateTicketPanel(null);
            AddTicketPanel(panel);
        }

        private void AddTicketPanel(Panel panel)
        {
            ticketsPage_ticketsPanel.RowCount++;
            ticketsPage_ticketsPanel.RowStyles.Insert(ticketsPage_ticketsPanel.RowCount - 2,
                new RowStyle(SizeType.AutoSize));
            ticketsPage_ticketsPanel.SetRow(ticketsPage_addButtonPanel, ticketsPage_ticketsPanel.RowCount - 1);
            ticketsPage_ticketsPanel.Controls.Add(panel, 0, ticketsPage_ticketsPanel.RowCount - 2);
        }

        private Panel CreateTicketPanel(Ticket ticket)
        {
            var fullNameLabel = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, 204),
                Location = new System.Drawing.Point(112, 30),
                Size = new System.Drawing.Size(32, 14),
                Text = "ФИО"
            };
            var emailLabel = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, 204),
                Location = new System.Drawing.Point(314, 30),
                Size = new System.Drawing.Size(35, 14),
                Text = "E-mail"
            };
            var addressLabel = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, 204),
                Location = new System.Drawing.Point(509, 30),
                Size = new System.Drawing.Size(39, 14),
                Text = "Адрес"
            };
            var indebtednessLabel = new Label
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, 204),
                Location = new System.Drawing.Point(627, 30),
                Size = new System.Drawing.Size(88, 14),
                Text = "Задолженность"
            };
            var fullNameTextBox = new TextBox
            {
                Location = new System.Drawing.Point(3, 3),
                Size = new System.Drawing.Size(250, 26),
                TabIndex = 1,
                Text = ticket?.FullName 
            };
            var emailTextBox = new TextBox
            {
                Location = new System.Drawing.Point(256, 3),
                Size = new System.Drawing.Size(150, 26),
                TabIndex = 2,
                Text = ticket?.Email
            };
            var addressTextBox = new TextBox
            {
                Location = new System.Drawing.Point(409, 3),
                Size = new System.Drawing.Size(220, 26),
                TabIndex = 3,
                Text = ticket?.Address
            };
            var indebtednessTextBox = new TextBox
            {
                Location = new System.Drawing.Point(632, 3),
                Size = new System.Drawing.Size(78, 26),
                TabIndex = 4,
                Text = ticket?.Indebtedness?.ToString()
            };
            var editButton = new Button
            {
                Location = new System.Drawing.Point(256, 47),
                Size = new System.Drawing.Size(100, 25),
                TabIndex = 5,
                Text = ticket != null ? "Изменить" : "Сохранить",
                UseVisualStyleBackColor = true,
                Enabled = false
            };
            var deleteButton = new Button
            {
                Location = new System.Drawing.Point(362, 47),
                Size = new System.Drawing.Size(100, 25),
                TabIndex = 6,
                Text = "Удалить",
                UseVisualStyleBackColor = true
            };

            var panel = new Panel {BorderStyle = BorderStyle.FixedSingle};
            panel.SuspendLayout();
            panel.Controls.Add(fullNameTextBox);
            panel.Controls.Add(emailTextBox);
            panel.Controls.Add(addressTextBox);
            panel.Controls.Add(indebtednessTextBox);
            panel.Controls.Add(fullNameLabel);
            panel.Controls.Add(emailLabel);
            panel.Controls.Add(addressLabel);
            panel.Controls.Add(indebtednessLabel);
            panel.Controls.Add(deleteButton);
            panel.Controls.Add(editButton);
            panel.Location = new System.Drawing.Point(5, 5);
            panel.Margin = new Padding(5);
            panel.Size = new System.Drawing.Size(715, 75);

            fullNameTextBox.TextChanged += ValidateInput;
            emailTextBox.TextChanged += ValidateInput;
            addressTextBox.TextChanged += ValidateInput;
            indebtednessTextBox.TextChanged += ValidateInput;

            void ValidateInput(object sender, EventArgs e)
            {
                var fullName = fullNameTextBox.Text;
                var email = emailTextBox.Text;
                var address = addressTextBox.Text;
                var indebtedness = indebtednessTextBox.Text;
                var enabled = !string.IsNullOrWhiteSpace(fullName)
                              && !string.IsNullOrWhiteSpace(address)
                              && decimal.TryParse(indebtedness, out var indebtednessDecimal)
                              && (fullName != ticket?.FullName || email != ticket?.Email ||
                                  address != ticket?.Address ||
                                  indebtednessDecimal != ticket?.Indebtedness);
                editButton.Enabled = enabled;
            }

            editButton.Click += (sender, args) =>
            {
                if (ticket == null)
                {
                    ticket = new Ticket
                    {
                        Id = Guid.NewGuid().ToString(),
                        FullName = fullNameTextBox.Text,
                        Email = emailTextBox.Text,
                        Address = addressTextBox.Text,
                        Indebtedness = decimal.Parse(indebtednessTextBox.Text)
                    };
                    TaxOfficeDb.Insert(() => new Ticket
                    {
                        Id = ticket.Id,
                        FullName = ticket.FullName,
                        Email = ticket.Email,
                        Address = ticket.Address,
                        Indebtedness = ticket.Indebtedness
                    });
                    LogHistory(HistoryActions.TicketCreated(ticket));
                    editButton.Text = "Изменить";
                }
                else
                {
                    TaxOfficeDb.Update<Ticket>(t => t.Id == ticket.Id, t => ticket);
                    LogHistory(HistoryActions.TicketEdited(ticket));
                }
            };

            deleteButton.Click += (sender, args) =>
            {
                if (ticket != null)
                {
                    TaxOfficeDb.Delete<Ticket>(t => t.Id == ticket.Id);
                    LogHistory(HistoryActions.TicketDeleted(ticket));
                }
                var rowIndex = ticketsPage_ticketsPanel.GetRow(panel);
                ticketsPage_ticketsPanel.RowStyles.RemoveAt(rowIndex);
                ticketsPage_ticketsPanel.Controls.Remove(panel);
                ticketsPage_ticketsPanel.RowCount--;
            };

            panel.ResumeLayout(false);
            panel.PerformLayout();
            return panel;
        }
    }
}