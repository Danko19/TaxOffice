using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TaxOffice.Database;
using TaxOffice.Database.Models;

namespace TaxOffice
{
    public partial class Form1
    {
        private void LoadProfilePage()
        {
            profilePage_pictureBox.BackgroundImage = user.Picture ?? profilePage_pictureBox.BackgroundImage;
            profilePage_nameLabel.Text = user.FullName;
            profilePage_emailTextBox.Text = user.Email;
            profilePage_passwordTextBox.Text = user.Password;
            profilePage_emailChangeButton.Enabled = false;
            profilePage_passwordChangeButton.Enabled = false;
        }

        private void profilePage_emailTextBox_TextChanged(object sender, EventArgs e)
        {
            var email = profilePage_emailTextBox.Text;
            var enabled = !string.IsNullOrWhiteSpace(email) && email != user.Email;
            profilePage_emailChangeButton.Enabled = enabled;
        }

        private void profilePage_passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            var password = profilePage_passwordTextBox.Text;
            var enabled = !string.IsNullOrWhiteSpace(password) && password != user.Password;
            profilePage_passwordChangeButton.Enabled = enabled;
        }

        private void profilePage_emailChangeButton_Click(object sender, EventArgs e)
        {
            TaxOfficeDb.Update<User>(u => u.Id == user.Id, userOld =>
                new User {Email = profilePage_emailTextBox.Text});
            profilePage_emailChangeButton.Enabled = false;
        }

        private void profilePage_passwordChangeButton_Click(object sender, EventArgs e)
        {
            TaxOfficeDb.Update<User>(u => u.Id == user.Id, userOld =>
                new User {Password = profilePage_passwordTextBox.Text});
            profilePage_passwordChangeButton.Enabled = false;
        }

        private void profilePage_pictureBox_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Выберите новое изображение";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var newPicture = File.ReadAllBytes(dlg.FileName);
                    TaxOfficeDb.Update<User>(u => u.Id == user.Id, userOld =>
                        new User {PictureRaw = newPicture});
                    user.PictureRaw = newPicture;
                    profilePage_pictureBox.BackgroundImage = user.Picture;
                }
            }
        }
    }
}