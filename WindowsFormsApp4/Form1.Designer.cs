namespace WindowsFormsApp4
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gLogin = new System.Windows.Forms.GroupBox();
            this.tLogin = new System.Windows.Forms.TextBox();
            this.gPass = new System.Windows.Forms.GroupBox();
            this.tPass = new System.Windows.Forms.TextBox();
            this.gMail = new System.Windows.Forms.GroupBox();
            this.tMail = new System.Windows.Forms.TextBox();
            this.gName = new System.Windows.Forms.GroupBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.gPhone = new System.Windows.Forms.GroupBox();
            this.tPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gLogin.SuspendLayout();
            this.gPass.SuspendLayout();
            this.gMail.SuspendLayout();
            this.gName.SuspendLayout();
            this.gPhone.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gPhone);
            this.groupBox1.Controls.Add(this.gName);
            this.groupBox1.Controls.Add(this.gMail);
            this.groupBox1.Controls.Add(this.gPass);
            this.groupBox1.Controls.Add(this.gLogin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 475);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            // 
            // gLogin
            // 
            this.gLogin.Controls.Add(this.tLogin);
            this.gLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gLogin.Location = new System.Drawing.Point(6, 25);
            this.gLogin.Name = "gLogin";
            this.gLogin.Size = new System.Drawing.Size(428, 65);
            this.gLogin.TabIndex = 2;
            this.gLogin.TabStop = false;
            this.gLogin.Text = "Логин";
            // 
            // tLogin
            // 
            this.tLogin.Location = new System.Drawing.Point(7, 26);
            this.tLogin.Name = "tLogin";
            this.tLogin.Size = new System.Drawing.Size(415, 26);
            this.tLogin.TabIndex = 0;
            // 
            // gPass
            // 
            this.gPass.Controls.Add(this.tPass);
            this.gPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gPass.Location = new System.Drawing.Point(6, 96);
            this.gPass.Name = "gPass";
            this.gPass.Size = new System.Drawing.Size(428, 65);
            this.gPass.TabIndex = 3;
            this.gPass.TabStop = false;
            this.gPass.Text = "Пароль";
            // 
            // tPass
            // 
            this.tPass.Location = new System.Drawing.Point(7, 26);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(415, 26);
            this.tPass.TabIndex = 0;
            // 
            // gMail
            // 
            this.gMail.Controls.Add(this.tMail);
            this.gMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gMail.Location = new System.Drawing.Point(6, 167);
            this.gMail.Name = "gMail";
            this.gMail.Size = new System.Drawing.Size(428, 65);
            this.gMail.TabIndex = 3;
            this.gMail.TabStop = false;
            this.gMail.Text = "E-Mail";
            // 
            // tMail
            // 
            this.tMail.Location = new System.Drawing.Point(7, 26);
            this.tMail.Name = "tMail";
            this.tMail.Size = new System.Drawing.Size(415, 26);
            this.tMail.TabIndex = 0;
            // 
            // gName
            // 
            this.gName.Controls.Add(this.tName);
            this.gName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gName.Location = new System.Drawing.Point(6, 238);
            this.gName.Name = "gName";
            this.gName.Size = new System.Drawing.Size(428, 65);
            this.gName.TabIndex = 4;
            this.gName.TabStop = false;
            this.gName.Text = "Имя";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(7, 26);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(415, 26);
            this.tName.TabIndex = 0;
            // 
            // gPhone
            // 
            this.gPhone.Controls.Add(this.tPhone);
            this.gPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gPhone.Location = new System.Drawing.Point(6, 309);
            this.gPhone.Name = "gPhone";
            this.gPhone.Size = new System.Drawing.Size(428, 65);
            this.gPhone.TabIndex = 5;
            this.gPhone.TabStop = false;
            this.gPhone.Text = "Номер телефона";
            // 
            // tPhone
            // 
            this.tPhone.Location = new System.Drawing.Point(7, 26);
            this.tPhone.Name = "tPhone";
            this.tPhone.Size = new System.Drawing.Size(415, 26);
            this.tPhone.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 499);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gLogin.ResumeLayout(false);
            this.gLogin.PerformLayout();
            this.gPass.ResumeLayout(false);
            this.gPass.PerformLayout();
            this.gMail.ResumeLayout(false);
            this.gMail.PerformLayout();
            this.gName.ResumeLayout(false);
            this.gName.PerformLayout();
            this.gPhone.ResumeLayout(false);
            this.gPhone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gPhone;
        private System.Windows.Forms.TextBox tPhone;
        private System.Windows.Forms.GroupBox gName;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.GroupBox gMail;
        private System.Windows.Forms.TextBox tMail;
        private System.Windows.Forms.GroupBox gPass;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.GroupBox gLogin;
        private System.Windows.Forms.TextBox tLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

