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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.profilePage = new System.Windows.Forms.TabPage();
            this.ticketsPage = new System.Windows.Forms.TabPage();
            this.registrationPage = new System.Windows.Forms.TabPage();
            this.historyPage = new System.Windows.Forms.TabPage();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.Visible = false;
            // 
            // profilePage
            // 
            this.profilePage.Location = new System.Drawing.Point(4, 27);
            this.profilePage.Name = "profilePage";
            this.profilePage.Padding = new System.Windows.Forms.Padding(3);
            this.profilePage.Size = new System.Drawing.Size(768, 395);
            this.profilePage.TabIndex = 0;
            this.profilePage.Text = "Профиль";
            this.profilePage.UseVisualStyleBackColor = true;
            // 
            // ticketsPage
            // 
            this.ticketsPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketsPage.Location = new System.Drawing.Point(4, 27);
            this.ticketsPage.Name = "ticketsPage";
            this.ticketsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ticketsPage.Size = new System.Drawing.Size(768, 395);
            this.ticketsPage.TabIndex = 1;
            this.ticketsPage.Text = "Тикеты";
            this.ticketsPage.UseVisualStyleBackColor = true;
            // 
            // registrationPage
            // 
            this.registrationPage.Location = new System.Drawing.Point(4, 27);
            this.registrationPage.Name = "registrationPage";
            this.registrationPage.Size = new System.Drawing.Size(768, 395);
            this.registrationPage.TabIndex = 2;
            this.registrationPage.Text = "Заявки на регистрацию";
            this.registrationPage.UseVisualStyleBackColor = true;
            // 
            // historyPage
            // 
            this.historyPage.Location = new System.Drawing.Point(4, 27);
            this.historyPage.Name = "historyPage";
            this.historyPage.Size = new System.Drawing.Size(768, 395);
            this.historyPage.TabIndex = 3;
            this.historyPage.Text = "История";
            this.historyPage.UseVisualStyleBackColor = true;
            // 
            // employeesPage
            // 
            this.employeesPage.Location = new System.Drawing.Point(4, 27);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Size = new System.Drawing.Size(768, 395);
            this.employeesPage.TabIndex = 4;
            this.employeesPage.Text = "Сотрудники";
            this.employeesPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage profilePage;
        private System.Windows.Forms.TabPage ticketsPage;
        private System.Windows.Forms.TabPage registrationPage;
        private System.Windows.Forms.TabPage historyPage;
        private System.Windows.Forms.TabPage employeesPage;
    }
}