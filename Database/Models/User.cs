using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace TaxOffice.Database.Models
{
    [TableName("users")]
    public class User
    {
        [PrimaryKey]
        [MapField("id")]
        public int Id { get; set; }
        
        [MapField("full_name")]
        public string FullName { get; set; }
        
        [MapField("password")]
        public string Password { get; set; }
        
        [MapField("email")]
        public string Email { get; set; }
        
        [MapField("role")]
        public Role Role { get; set; }
    }

    public enum Role
    {
        None = 0,
        Employee = 1,
        Admin = 2
    }
}