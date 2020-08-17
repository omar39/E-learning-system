namespace e_learning_system
{
    partial class registeration
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
            this.register_btn = new System.Windows.Forms.Button();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usersTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumber_txt = new System.Windows.Forms.TextBox();
            this.years_lbl = new System.Windows.Forms.Label();
            this.years_exp_tb = new System.Windows.Forms.TextBox();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.des_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(275, 350);
            this.register_btn.Margin = new System.Windows.Forms.Padding(2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(116, 54);
            this.register_btn.TabIndex = 6;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(303, 72);
            this.username_txt.Margin = new System.Windows.Forms.Padding(2);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(130, 20);
            this.username_txt.TabIndex = 2;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(303, 102);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(130, 20);
            this.password_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // usersTypes
            // 
            this.usersTypes.FormattingEnabled = true;
            this.usersTypes.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.usersTypes.Location = new System.Drawing.Point(303, 185);
            this.usersTypes.Name = "usersTypes";
            this.usersTypes.Size = new System.Drawing.Size(121, 21);
            this.usersTypes.TabIndex = 26;
            this.usersTypes.SelectedIndexChanged += new System.EventHandler(this.usersTypes_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "User type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Phone number";
            // 
            // phoneNumber_txt
            // 
            this.phoneNumber_txt.Location = new System.Drawing.Point(303, 137);
            this.phoneNumber_txt.Name = "phoneNumber_txt";
            this.phoneNumber_txt.Size = new System.Drawing.Size(130, 20);
            this.phoneNumber_txt.TabIndex = 29;
            // 
            // years_lbl
            // 
            this.years_lbl.AutoSize = true;
            this.years_lbl.Location = new System.Drawing.Point(172, 249);
            this.years_lbl.Name = "years_lbl";
            this.years_lbl.Size = new System.Drawing.Size(105, 13);
            this.years_lbl.TabIndex = 30;
            this.years_lbl.Text = "Years Of Experience";
            this.years_lbl.Visible = false;
            // 
            // years_exp_tb
            // 
            this.years_exp_tb.Location = new System.Drawing.Point(294, 249);
            this.years_exp_tb.Name = "years_exp_tb";
            this.years_exp_tb.Size = new System.Drawing.Size(130, 20);
            this.years_exp_tb.TabIndex = 31;
            this.years_exp_tb.Visible = false;
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(294, 289);
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(130, 20);
            this.description_tb.TabIndex = 33;
            this.description_tb.Visible = false;
            this.description_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // des_lbl
            // 
            this.des_lbl.AutoSize = true;
            this.des_lbl.Location = new System.Drawing.Point(206, 292);
            this.des_lbl.Name = "des_lbl";
            this.des_lbl.Size = new System.Drawing.Size(60, 13);
            this.des_lbl.TabIndex = 32;
            this.des_lbl.Text = "Description";
            this.des_lbl.Visible = false;
            this.des_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // registeration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 448);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.des_lbl);
            this.Controls.Add(this.years_exp_tb);
            this.Controls.Add(this.years_lbl);
            this.Controls.Add(this.phoneNumber_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usersTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.register_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "registeration";
            this.Text = "Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registeration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox usersTypes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumber_txt;
        private System.Windows.Forms.Label years_lbl;
        private System.Windows.Forms.TextBox years_exp_tb;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.Label des_lbl;
    }
}