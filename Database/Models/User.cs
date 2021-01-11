using System;
using System.Drawing;
using System.IO;
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
        
        [MapField("picture")]
        public byte[] PictureRaw { get; set; }
        
        public Image Picture
        {
            get
            {
                if (PictureRaw == null)
                    return null;
                using (var stream = new MemoryStream(PictureRaw))
                {
                    return Image.FromStream(stream);
                }
            }
        }

        public override string ToString() => $"{FullName} ({Role.ToRussian()})";
    }

    public enum Role
    {
        None = 0,
        Employee = 1,
        Admin = 2
    }
    
    public static class RoleExtensions
    {
        public static string ToRussian(this Role role)
        {
            if (role == Role.Admin)
                return "Администратор";
            if (role == Role.Employee)
                return "Подтвержденный пользователь";
            if (role == Role.None)
                return "Неподтвержденный пользователь";

            throw new ArgumentOutOfRangeException();
        }
    
    }
}