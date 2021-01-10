using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace TaxOffice.Database.Models
{
    [TableName("tickets")]
    public class Ticket
    {
        [PrimaryKey]
        [MapField("id")]
        public string Id { get; set; }
        
        [MapField("full_name")]
        public string FullName { get; set; }
        
        [MapField("email")]
        public string Email { get; set; }
        
        [MapField("address")]
        public string Address { get; set; }
        
        [MapField("indebtedness")]
        public decimal? Indebtedness { get; set; }
    }
}