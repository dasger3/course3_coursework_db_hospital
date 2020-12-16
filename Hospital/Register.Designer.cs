
namespace Hospital
{
    partial class Register
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.panelP = new System.Windows.Forms.Panel();
            this.panelD = new System.Windows.Forms.Panel();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbSpecialization = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelP.SuspendLayout();
            this.panelD.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 167);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 29);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Введіть ім\'я";
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtName.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(125, 206);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(250, 29);
            this.txtSurname.TabIndex = 4;
            this.txtSurname.Text = "Введіть прізвище";
            this.txtSurname.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtSurname.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(150, 460);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 66);
            this.button2.TabIndex = 0;
            this.button2.Text = "Реєстрація";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Blue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(468, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Реєстрація";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(125, 245);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 29);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Text = "Введіть телефон";
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(125, 90);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 29);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Введіть пошту";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(125, 128);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Введіть пороль";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Location = new System.Drawing.Point(125, 294);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(87, 24);
            this.rb1.TabIndex = 11;
            this.rb1.TabStop = true;
            this.rb1.Text = "Пацієнт";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(307, 294);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(68, 24);
            this.rb2.TabIndex = 12;
            this.rb2.Text = "Лікар";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Blue;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.Color.White;
            this.txtAdress.Location = new System.Drawing.Point(0, 37);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(250, 29);
            this.txtAdress.TabIndex = 13;
            this.txtAdress.Text = "Введіть адресу";
            this.txtAdress.Enter += new System.EventHandler(this.textBox1_Enter_1);
            this.txtAdress.Leave += new System.EventHandler(this.txtAdress_Leave);
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(0, 76);
            this.txtPassport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassport.Multiline = true;
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(250, 29);
            this.txtPassport.TabIndex = 11;
            this.txtPassport.Text = "Введіть номер паспорта";
            this.txtPassport.Enter += new System.EventHandler(this.txtPassport_Enter);
            this.txtPassport.Leave += new System.EventHandler(this.txtPassport_Leave);
            // 
            // panelP
            // 
            this.panelP.Controls.Add(this.dateTimePicker1);
            this.panelP.Controls.Add(this.txtAdress);
            this.panelP.Controls.Add(this.txtPassport);
            this.panelP.Location = new System.Drawing.Point(125, 335);
            this.panelP.Name = "panelP";
            this.panelP.Size = new System.Drawing.Size(250, 105);
            this.panelP.TabIndex = 14;
            // 
            // panelD
            // 
            this.panelD.Controls.Add(this.cbSpecialization);
            this.panelD.Controls.Add(this.txtRoom);
            this.panelD.Location = new System.Drawing.Point(125, 335);
            this.panelD.Name = "panelD";
            this.panelD.Size = new System.Drawing.Size(250, 105);
            this.panelD.TabIndex = 15;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(0, 0);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoom.Multiline = true;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(250, 29);
            this.txtRoom.TabIndex = 6;
            this.txtRoom.Text = "Введіть номер кабінета";
            this.txtRoom.TextChanged += new System.EventHandler(this.txtRoom_TextChanged);
            this.txtRoom.Enter += new System.EventHandler(this.txtRoom_Enter);
            this.txtRoom.Leave += new System.EventHandler(this.txtRoom_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(4, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 29);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbSpecialization
            // 
            this.cbSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialization.FormattingEnabled = true;
            this.cbSpecialization.Items.AddRange(new object[] {
            "Хирург",
            "Терапевт",
            "Просто дурачек"});
            this.cbSpecialization.Location = new System.Drawing.Point(0, 38);
            this.cbSpecialization.Name = "cbSpecialization";
            this.cbSpecialization.Size = new System.Drawing.Size(250, 28);
            this.cbSpecialization.TabIndex = 16;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(500, 544);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panelP);
            this.Controls.Add(this.panelD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelP.ResumeLayout(false);
            this.panelP.PerformLayout();
            this.panelD.ResumeLayout(false);
            this.panelD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Panel panelP;
        private System.Windows.Forms.Panel panelD;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbSpecialization;
    }
}

