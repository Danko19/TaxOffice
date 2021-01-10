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
            this.ticketsPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registrationPage = new System.Windows.Forms.TabPage();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.startPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ticketsPage.SuspendLayout();
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
            this.startPanel.TabIndex = 0;
            // 
            // startInput_password
            // 
            this.startInput_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.startInput_password.Location = new System.Drawing.Point(0, 75);
            this.startInput_password.Margin = new System.Windows.Forms.Padding(6);
            this.startInput_password.Name = "startInput_password";
            this.startInput_password.Size = new System.Drawing.Size(276, 26);
            this.startInput_password.TabIndex = 2;
            // 
            // startInput_name
            // 
            this.startInput_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.startInput_name.Location = new System.Drawing.Point(0, 37);
            this.startInput_name.Margin = new System.Windows.Forms.Padding(6);
            this.startInput_name.Name = "startInput_name";
            this.startInput_name.Size = new System.Drawing.Size(276, 26);
            this.startInput_name.TabIndex = 1;
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.registrationButton.Location = new System.Drawing.Point(146, 110);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(130, 30);
            this.registrationButton.TabIndex = 4;
            this.registrationButton.Text = "Регистрация";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // authorizationButton
            // 
            this.authorizationButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.authorizationButton.Location = new System.Drawing.Point(0, 110);
            this.authorizationButton.Name = "authorizationButton";
            this.authorizationButton.Size = new System.Drawing.Size(130, 30);
            this.authorizationButton.TabIndex = 3;
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
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
            this.profilePage.Location = new System.Drawing.Point(4, 27);
            this.profilePage.Name = "profilePage";
            this.profilePage.Padding = new System.Windows.Forms.Padding(3);
            this.profilePage.Size = new System.Drawing.Size(752, 506);
            this.profilePage.TabIndex = 0;
            this.profilePage.Text = "Профиль";
            this.profilePage.UseVisualStyleBackColor = true;
            // 
            // ticketsPage
            // 
            this.ticketsPage.Controls.Add(this.panel1);
            this.ticketsPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ticketsPage.Location = new System.Drawing.Point(4, 27);
            this.ticketsPage.Name = "ticketsPage";
            this.ticketsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ticketsPage.Size = new System.Drawing.Size(752, 506);
            this.ticketsPage.TabIndex = 1;
            this.ticketsPage.Text = "Тикеты";
            this.ticketsPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 108);
            this.panel1.TabIndex = 0;
            // 
            // registrationPage
            // 
            this.registrationPage.Location = new System.Drawing.Point(4, 27);
            this.registrationPage.Name = "registrationPage";
            this.registrationPage.Size = new System.Drawing.Size(752, 506);
            this.registrationPage.TabIndex = 2;
            this.registrationPage.Text = "Заявки на регистрацию";
            this.registrationPage.UseVisualStyleBackColor = true;
            // 
            // historyPage
            // 
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
            this.ticketsPage.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
    }
}