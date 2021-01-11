using System;
using System.Linq;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace TaxOffice.Database.Models
{
    [TableName("history")]
    public class HistoryItem
    {
        public HistoryItem()
        {
            Timestamp = DateTime.Now;
        }
        
        [PrimaryKey]
        [MapField("id")]
        public int Id { get; set; }
        
        [MapField("timestamp")]
        public long TimestampTicks { get; set; }

        [MapIgnore]
        public DateTime Timestamp
        {
            get => new DateTime(TimestampTicks); 
            set => TimestampTicks = value.Ticks;
        }
        
        [MapField("user_id")]
        public int UserId { get; set; }
        
        [MapField("action")]
        public string Action { get; set; }

        public string ToPrettyString()
        {
            return
                $"{Timestamp:dd.MM.yyy HH:mm:ss} Пользователь {TaxOfficeDb.Select<User>(u => u.Id == UserId).Single().FullName} {Action}";
        }
    }

    public static class HistoryActions
    {
        public const string Authorize = "авторизовался";
        public const string Register = "зарегистрировался";
        public const string AvatarEdited = "изменил автар";
        public const string EmailEdited = "изменил e-mail";
        public const string PasswordEdited = "изменил пароль";
        public static string TicketDeleted(Ticket ticket) => $"удалил тикет налогоплательщика {ticket.FullName}";
        public static string TicketCreated(Ticket ticket) => $"создал тикет налогоплательщика {ticket.FullName}";
        public static string TicketEdited(Ticket ticket) => $"изменил тикет налогоплательщика {ticket.FullName}";
        public static string UserAccepted(User user) => $"подтвердил учётную запись пользователя {user.FullName}";
        public static string UserDeclined(User user) => $"отклонил учётную запись пользователя {user.FullName}";
    }
}