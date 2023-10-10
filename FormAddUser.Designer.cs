namespace SvetlanaS
{
    partial class FormAddUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label roleIDLabel;
            System.Windows.Forms.Label second_NameLabel;
            System.Windows.Forms.Label passwordLabel2;
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.roleIDComboBox = new System.Windows.Forms.ComboBox();
            this.BindingSourceRole = new System.Windows.Forms.BindingSource(this.components);
            this.second_NameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.radioButtonWomen = new System.Windows.Forms.RadioButton();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            emailLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            roleIDLabel = new System.Windows.Forms.Label();
            second_NameLabel = new System.Windows.Forms.Label();
            passwordLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceRole)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(113, 266);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(76, 25);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Почта:";
            // 
            // first_NameLabel
            // 
            first_NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            first_NameLabel.AutoSize = true;
            first_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            first_NameLabel.Location = new System.Drawing.Point(544, 120);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 25);
            first_NameLabel.TabIndex = 2;
            first_NameLabel.Text = "Имя:";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            genderLabel.Location = new System.Drawing.Point(549, 299);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(55, 25);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "Пол:";
            // 
            // loginLabel
            // 
            loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            loginLabel.Location = new System.Drawing.Point(113, 122);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(74, 25);
            loginLabel.TabIndex = 8;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel.Location = new System.Drawing.Point(101, 158);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(86, 25);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Пароль:";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(84, 302);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(105, 25);
            phoneLabel.TabIndex = 12;
            phoneLabel.Text = "Телефон:";
            // 
            // roleIDLabel
            // 
            roleIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            roleIDLabel.AutoSize = true;
            roleIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            roleIDLabel.Location = new System.Drawing.Point(541, 261);
            roleIDLabel.Name = "roleIDLabel";
            roleIDLabel.Size = new System.Drawing.Size(63, 25);
            roleIDLabel.TabIndex = 16;
            roleIDLabel.Text = "Роль:";
            // 
            // second_NameLabel
            // 
            second_NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            second_NameLabel.AutoSize = true;
            second_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            second_NameLabel.Location = new System.Drawing.Point(495, 156);
            second_NameLabel.Name = "second_NameLabel";
            second_NameLabel.Size = new System.Drawing.Size(109, 25);
            second_NameLabel.TabIndex = 18;
            second_NameLabel.Text = "Фамилия:";
            // 
            // passwordLabel2
            // 
            passwordLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            passwordLabel2.AutoSize = true;
            passwordLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel2.Location = new System.Drawing.Point(29, 194);
            passwordLabel2.Name = "passwordLabel2";
            passwordLabel2.Size = new System.Drawing.Size(158, 25);
            passwordLabel2.TabIndex = 20;
            passwordLabel2.Text = "Повтор пароля:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(193, 263);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(244, 30);
            this.emailTextBox.TabIndex = 1;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.first_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_NameTextBox.Location = new System.Drawing.Point(622, 117);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(244, 30);
            this.first_NameTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(193, 119);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(244, 30);
            this.loginTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(193, 155);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(244, 30);
            this.passwordTextBox.TabIndex = 11;
            // 
            // roleIDComboBox
            // 
            this.roleIDComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleIDComboBox.DataSource = this.BindingSourceRole;
            this.roleIDComboBox.DisplayMember = "Name";
            this.roleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleIDComboBox.FormattingEnabled = true;
            this.roleIDComboBox.Location = new System.Drawing.Point(622, 258);
            this.roleIDComboBox.Name = "roleIDComboBox";
            this.roleIDComboBox.Size = new System.Drawing.Size(244, 33);
            this.roleIDComboBox.TabIndex = 17;
            this.roleIDComboBox.ValueMember = "ID";
            // 
            // BindingSourceRole
            // 
            this.BindingSourceRole.DataSource = typeof(SvetlanaS.DBContext.Roles);
            // 
            // second_NameTextBox
            // 
            this.second_NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.second_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_NameTextBox.Location = new System.Drawing.Point(622, 153);
            this.second_NameTextBox.Name = "second_NameTextBox";
            this.second_NameTextBox.Size = new System.Drawing.Size(244, 30);
            this.second_NameTextBox.TabIndex = 19;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox2.Location = new System.Drawing.Point(193, 191);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(244, 30);
            this.passwordTextBox2.TabIndex = 21;
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Checked = true;
            this.radioButtonMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMen.Location = new System.Drawing.Point(622, 301);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(106, 24);
            this.radioButtonMen.TabIndex = 22;
            this.radioButtonMen.TabStop = true;
            this.radioButtonMen.Text = "Мужчины";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            // 
            // radioButtonWomen
            // 
            this.radioButtonWomen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonWomen.AutoSize = true;
            this.radioButtonWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWomen.Location = new System.Drawing.Point(756, 305);
            this.radioButtonWomen.Name = "radioButtonWomen";
            this.radioButtonWomen.Size = new System.Drawing.Size(110, 24);
            this.radioButtonWomen.TabIndex = 23;
            this.radioButtonWomen.Text = "Женщины";
            this.radioButtonWomen.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(55, 31);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(134, 44);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(695, 379);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(171, 47);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(193, 300);
            this.phoneMaskedTextBox.Mask = "+7(000)000-00-00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(241, 30);
            this.phoneMaskedTextBox.TabIndex = 26;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.radioButtonWomen);
            this.Controls.Add(this.radioButtonMen);
            this.Controls.Add(passwordLabel2);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(roleIDLabel);
            this.Controls.Add(this.roleIDComboBox);
            this.Controls.Add(second_NameLabel);
            this.Controls.Add(this.second_NameTextBox);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.ComboBox roleIDComboBox;
        private System.Windows.Forms.TextBox second_NameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.RadioButton radioButtonWomen;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.BindingSource BindingSourceRole;
    }
}