namespace TaxOffice
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startPanel = new System.Windows.Forms.Panel();
            this.startInput_password = new System.Windows.Forms.TextBox();
            this.startInput_name = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.authorizationButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.profilePage = new System.Windows.Forms.TabPage();
            this.profilePage_passwordChangeButton = new System.Windows.Forms.Button();
            this.profilePage_emailChangeButton = new System.Windows.Forms.Button();
            this.profilePage_passwordTextBox = new System.Windows.Forms.TextBox();
            this.profilePage_emailTextBox = new System.Windows.Forms.TextBox();
            this.profilePage_emailLabel = new System.Windows.Forms.Label();
            this.profilePage_passwordLabel = new System.Windows.Forms.Label();
            this.profilePage_nameLabel = new System.Windows.Forms.Label();
            this.profilePage_pictureBox = new System.Windows.Forms.PictureBox();
            this.ticketsPage = new System.Windows.Forms.TabPage();
            this.ticketsPage_ticketsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ticketsPage_addButtonPanel = new System.Windows.Forms.Panel();
            this.ticketsPage_addButton = new System.Windows.Forms.Button();
            this.registrationPage = new System.Windows.Forms.TabPage();
            this.registrationPage_registrationsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.historyPage_listBox = new System.Windows.Forms.ListBox();
            this.startPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.profilePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePage_pictureBox)).BeginInit();
            this.ticketsPage.SuspendLayout();
            this.ticketsPage_ticketsPanel.SuspendLayout();
            this.ticketsPage_addButtonPanel.SuspendLayout();
            this.registrationPage.SuspendLayout();
            this.historyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.startInput_password);
            this.startPanel.Controls.Add(this.startInput_name);
            this.startPanel.Controls.Add(this.registrationButton);
            this.startPanel.Controls.Add(this.authorizationButton);
            this.startPanel.Location = new System.Drawing.Point(262, 150);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(276, 158);
            this.startPanel.TabIndex = 1;
            // 
            // startInput_password
            // 
            this.startInput_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startInput_password.Location = new System.Drawing.Point(0, 75);
            this.startInput_password.Margin = new System.Windows.Forms.Padding(6);
            this.startInput_password.Name = "startInput_password";
            this.startInput_password.Size = new System.Drawing.Size(276, 26);
            this.startInput_password.TabIndex = 3;
            // 
            // startInput_name
            // 
            this.startInput_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startInput_name.Location = new System.Drawing.Point(0, 37);
            this.startInput_name.Margin = new System.Windows.Forms.Padding(6);
            this.startInput_name.Name = "startInput_name";
            this.startInput_name.Size = new System.Drawing.Size(276, 26);
            this.startInput_name.TabIndex = 2;
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationButton.Location = new System.Drawing.Point(146, 110);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(130, 30);
            this.registrationButton.TabIndex = 5;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // authorizationButton
            // 
            this.authorizationButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizationButton.Location = new System.Drawing.Point(0, 110);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(130, 30);
            this.authorizationButton.TabIndex = 4;
            this.authorizationButton.Text = "Авторизация";
            this.authorizationButton.UseVisualStyleBackColor = true;
            this.authorizationButton.Click += new System.EventHandler(this.authorizationButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.profilePage);
            this.tabControl1.Controls.Add(this.ticketsPage);
            this.tabControl1.Controls.Add(this.registrationPage);
            this.tabControl1.Controls.Add(this.historyPage);
            this.tabControl1.Controls.Add(this.employeesPage);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 537);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabStop = false;
            this.tabControl1.Visible = false;
            // 
            // profilePage
            // 
            this.profilePage.Controls.Add(this.profilePage_passwordChangeButton);
            this.profilePage.Controls.Add(this.profilePage_emailChangeButton);
            this.profilePage.Controls.Add(this.profilePage_passwordTextBox);
            this.profilePage.Controls.Add(this.profilePage_emailTextBox);
            this.profilePage.Controls.Add(this.profilePage_emailLabel);
            this.profilePage.Controls.Add(this.profilePage_passwordLabel);
            this.profilePage.Controls.Add(this.profilePage_nameLabel);
            this.profilePage.Controls.Add(this.profilePage_pictureBox);
            this.profilePage.Location = new System.Drawing.Point(4, 27);
            this.profilePage.Name = "profilePage";
            this.profilePage.Padding = new System.Windows.Forms.Padding(3);
            this.profilePage.Size = new System.Drawing.Size(752, 506);
            this.profilePage.TabIndex = 0;
            this.profilePage.Text = "Профиль";
            this.profilePage.UseVisualStyleBackColor = true;
            // 
            // profilePage_passwordChangeButton
            // 
            this.profilePage_passwordChangeButton.Location = new System.Drawing.Point(392, 237);
            this.profilePage_passwordChangeButton.Name = "profilePage_passwordChangeButton";
            this.profilePage_passwordChangeButton.Size = new System.Drawing.Size(90, 28);
            this.profilePage_passwordChangeButton.TabIndex = 7;
            this.profilePage_passwordChangeButton.Text = "Изменить";
            this.profilePage_passwordChangeButton.UseVisualStyleBackColor = true;
            this.profilePage_passwordChangeButton.Click += new System.EventHandler(this.profilePage_passwordChangeButton_Click);
            // 
            // profilePage_emailChangeButton
            // 
            this.profilePage_emailChangeButton.Location = new System.Drawing.Point(392, 199);
            this.profilePage_emailChangeButton.Name = "profilePage_emailChangeButton";
            this.profilePage_emailChangeButton.Size = new System.Drawing.Size(90, 28);
            this.profilePage_emailChangeButton.TabIndex = 6;
            this.profilePage_emailChangeButton.Text = "Изменить";
            this.profilePage_emailChangeButton.UseVisualStyleBackColor = true;
            this.profilePage_emailChangeButton.Click += new System.EventHandler(this.profilePage_emailChangeButton_Click);
            // 
            // profilePage_passwordTextBox
            // 
            this.profilePage_passwordTextBox.Location = new System.Drawing.Point(96, 238);
            this.profilePage_passwordTextBox.Name = "profilePage_passwordTextBox";
            this.profilePage_passwordTextBox.PasswordChar = '*';
            this.profilePage_passwordTextBox.Size = new System.Drawing.Size(280, 26);
            this.profilePage_passwordTextBox.TabIndex = 5;
            this.profilePage_passwordTextBox.TextChanged += new System.EventHandler(this.profilePage_passwordTextBox_TextChanged);
            // 
            // profilePage_emailTextBox
            // 
            this.profilePage_emailTextBox.Location = new System.Drawing.Point(96, 200);
            this.profilePage_emailTextBox.Name = "profilePage_emailTextBox";
            this.profilePage_emailTextBox.Size = new System.Drawing.Size(280, 26);
            this.profilePage_emailTextBox.TabIndex = 4;
            this.profilePage_emailTextBox.TextChanged += new System.EventHandler(this.profilePage_emailTextBox_TextChanged);
            // 
            // profilePage_emailLabel
            // 
            this.profilePage_emailLabel.AutoSize = true;
            this.profilePage_emailLabel.Location = new System.Drawing.Point(30, 203);
            this.profilePage_emailLabel.Margin = new System.Windows.Forms.Padding(10);
            this.profilePage_emailLabel.Name = "profilePage_emailLabel";
            this.profilePage_emailLabel.Size = new System.Drawing.Size(53, 18);
            this.profilePage_emailLabel.TabIndex = 3;
            this.profilePage_emailLabel.Text = "E-mail";
            // 
            // profilePage_passwordLabel
            // 
            this.profilePage_passwordLabel.AutoSize = true;
            this.profilePage_passwordLabel.Location = new System.Drawing.Point(20, 241);
            this.profilePage_passwordLabel.Margin = new System.Windows.Forms.Padding(10);
            this.profilePage_passwordLabel.Name = "profilePage_passwordLabel";
            this.profilePage_passwordLabel.Size = new System.Drawing.Size(63, 18);
            this.profilePage_passwordLabel.TabIndex = 2;
            this.profilePage_passwordLabel.Text = "Пароль";
            // 
            // profilePage_nameLabel
            // 
            this.profilePage_nameLabel.AutoSize = true;
            this.profilePage_nameLabel.Location = new System.Drawing.Point(203, 23);
            this.profilePage_nameLabel.Margin = new System.Windows.Forms.Padding(10);
            this.profilePage_nameLabel.Name = "profilePage_nameLabel";
            this.profilePage_nameLabel.Size = new System.Drawing.Size(0, 18);
            this.profilePage_nameLabel.TabIndex = 1;
            // 
            // profilePage_pictureBox
            // 
            this.profilePage_pictureBox.BackgroundImage = global::TaxOffice.Properties.Resources.avatar_placeholder1;
            this.profilePage_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profilePage_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePage_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePage_pictureBox.InitialImage = null;
            this.profilePage_pictureBox.Location = new System.Drawing.Point(23, 23);
            this.profilePage_pictureBox.Margin = new System.Windows.Forms.Padding(20);
            this.profilePage_pictureBox.Name = "profilePage_pictureBox";
            this.profilePage_pictureBox.Size = new System.Drawing.Size(150, 150);
            this.profilePage_pictureBox.TabIndex = 0;
            this.profilePage_pictureBox.TabStop = false;
            this.profilePage_pictureBox.Click += new System.EventHandler(this.profilePage_pictureBox_Click);
            // 
            // ticketsPage
            // 
            this.ticketsPage.AutoScroll = true;
            this.ticketsPage.Controls.Add(this.ticketsPage_ticketsPanel);
            this.ticketsPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketsPage.Location = new System.Drawing.Point(4, 27);
            this.ticketsPage.Name = "ticketsPage";
            this.ticketsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ticketsPage.Size = new System.Drawing.Size(752, 506);
            this.ticketsPage.TabIndex = 1;
            this.ticketsPage.Text = "Тикеты";
            this.ticketsPage.UseVisualStyleBackColor = true;
            // 
            // ticketsPage_ticketsPanel
            // 
            this.ticketsPage_ticketsPanel.AutoSize = true;
            this.ticketsPage_ticketsPanel.ColumnCount = 1;
            this.ticketsPage_ticketsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ticketsPage_ticketsPanel.Controls.Add(this.ticketsPage_addButtonPanel, 0, 0);
            this.ticketsPage_ticketsPanel.Location = new System.Drawing.Point(7, 7);
            this.ticketsPage_ticketsPanel.Name = "ticketsPage_ticketsPanel";
            this.ticketsPage_ticketsPanel.RowCount = 1;
            this.ticketsPage_ticketsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ticketsPage_ticketsPanel.Size = new System.Drawing.Size(720, 36);
            this.ticketsPage_ticketsPanel.TabIndex = 0;
            // 
            // ticketsPage_addButtonPanel
            // 
            this.ticketsPage_addButtonPanel.Controls.Add(this.ticketsPage_addButton);
            this.ticketsPage_addButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.ticketsPage_addButtonPanel.Name = "ticketsPage_addButtonPanel";
            this.ticketsPage_addButtonPanel.Size = new System.Drawing.Size(714, 30);
            this.ticketsPage_addButtonPanel.TabIndex = 0;
            // 
            // ticketsPage_addButton
            // 
            this.ticketsPage_addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ticketsPage_addButton.Location = new System.Drawing.Point(0, 0);
            this.ticketsPage_addButton.Name = "ticketsPage_addButton";
            this.ticketsPage_addButton.Size = new System.Drawing.Size(714, 30);
            this.ticketsPage_addButton.TabIndex = 0;
            this.ticketsPage_addButton.Text = "Добавить";
            this.ticketsPage_addButton.UseVisualStyleBackColor = true;
            this.ticketsPage_addButton.Click += new System.EventHandler(this.ticketsPage_addButton_Click);
            // 
            // registrationPage
            // 
            this.registrationPage.AutoScroll = true;
            this.registrationPage.Controls.Add(this.registrationPage_registrationsPanel);
            this.registrationPage.Location = new System.Drawing.Point(4, 27);
            this.registrationPage.Name = "registrationPage";
            this.registrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.registrationPage.Size = new System.Drawing.Size(752, 506);
            this.registrationPage.TabIndex = 2;
            this.registrationPage.Text = "Заявки на регистрацию";
            this.registrationPage.UseVisualStyleBackColor = true;
            // 
            // registrationPage_registrationsPanel
            // 
            this.registrationPage_registrationsPanel.AutoSize = true;
            this.registrationPage_registrationsPanel.ColumnCount = 1;
            this.registrationPage_registrationsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.registrationPage_registrationsPanel.Location = new System.Drawing.Point(7, 7);
            this.registrationPage_registrationsPanel.Name = "registrationPage_registrationsPanel";
            this.registrationPage_registrationsPanel.RowCount = 1;
            this.registrationPage_registrationsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.registrationPage_registrationsPanel.Size = new System.Drawing.Size(720, 1);
            this.registrationPage_registrationsPanel.TabIndex = 0;
            // 
            // historyPage
            // 
            this.historyPage.Controls.Add(this.historyPage_listBox);
            this.historyPage.Location = new System.Drawing.Point(4, 27);
            this.historyPage.Name = "historyPage";
            this.historyPage.Size = new System.Drawing.Size(752, 506);
            this.historyPage.TabIndex = 3;
            this.historyPage.Text = "История";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // employeesPage
            // 
            this.employeesPage.Location = new System.Drawing.Point(4, 27);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Size = new System.Drawing.Size(752, 506);
            this.employeesPage.TabIndex = 4;
            this.employeesPage.Text = "Сотрудники";
            this.employeesPage.UseVisualStyleBackColor = true;
            // 
            // historyPage_listBox
            // 
            this.historyPage_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historyPage_listBox.FormattingEnabled = true;
            this.historyPage_listBox.ItemHeight = 18;
            this.historyPage_listBox.Location = new System.Drawing.Point(10, 10);
            this.historyPage_listBox.Margin = new System.Windows.Forms.Padding(10);
            this.historyPage_listBox.Name = "historyPage_listBox";
            this.historyPage_listBox.Size = new System.Drawing.Size(732, 488);
            this.historyPage_listBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.startPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.profilePage.ResumeLayout(false);
            this.profilePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePage_pictureBox)).EndInit();
            this.ticketsPage.ResumeLayout(false);
            this.ticketsPage.PerformLayout();
            this.ticketsPage_ticketsPanel.ResumeLayout(false);
            this.ticketsPage_addButtonPanel.ResumeLayout(false);
            this.registrationPage.ResumeLayout(false);
            this.registrationPage.PerformLayout();
            this.historyPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.Button authorizationButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox startInput_name;
        private System.Windows.Forms.TextBox startInput_password;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage profilePage;
        private System.Windows.Forms.TabPage ticketsPage;
        private System.Windows.Forms.TabPage registrationPage;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.TabPage employeesPage;
        private System.Windows.Forms.PictureBox profilePage_pictureBox;
        private System.Windows.Forms.Label profilePage_nameLabel;
        private System.Windows.Forms.TextBox profilePage_passwordTextBox;
        private System.Windows.Forms.TextBox profilePage_emailTextBox;
        private System.Windows.Forms.Label profilePage_emailLabel;
        private System.Windows.Forms.Label profilePage_passwordLabel;
        private System.Windows.Forms.Button profilePage_emailChangeButton;
        private System.Windows.Forms.Button profilePage_passwordChangeButton;
        private System.Windows.Forms.TableLayoutPanel ticketsPage_ticketsPanel;
        private System.Windows.Forms.Panel ticketsPage_addButtonPanel;
        private System.Windows.Forms.Button ticketsPage_addButton;
        private System.Windows.Forms.TableLayoutPanel registrationPage_registrationsPanel;
        private System.Windows.Forms.ListBox historyPage_listBox;
    }
}