﻿namespace e_learning_system
{
    partial class StudentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label_subject = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.student_comment_btn = new System.Windows.Forms.Button();
            this.student_comment_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.student_post_tb = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classes_cmb = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpa_tb = new System.Windows.Forms.TextBox();
            this.calc_gpa_btn = new System.Windows.Forms.Button();
            this.choose_class_btn = new System.Windows.Forms.Button();
            this.register_class_btn = new System.Windows.Forms.Button();
            this.other_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label_subject);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.student_comment_btn);
            this.panel1.Controls.Add(this.student_comment_tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.student_post_tb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 414);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Class id:";
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subject.Location = new System.Drawing.Point(100, 14);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(45, 19);
            this.label_subject.TabIndex = 8;
            this.label_subject.Text = "temp";
            this.label_subject.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(322, 14);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(45, 19);
            this.label_id.TabIndex = 7;
            this.label_id.Text = "temp";
            this.label_id.Visible = false;
            // 
            // student_comment_btn
            // 
            this.student_comment_btn.Location = new System.Drawing.Point(7, 379);
            this.student_comment_btn.Name = "student_comment_btn";
            this.student_comment_btn.Size = new System.Drawing.Size(75, 23);
            this.student_comment_btn.TabIndex = 6;
            this.student_comment_btn.Text = "Add Comment";
            this.student_comment_btn.UseVisualStyleBackColor = true;
            // 
            // student_comment_tb
            // 
            this.student_comment_tb.Location = new System.Drawing.Point(127, 339);
            this.student_comment_tb.Name = "student_comment_tb";
            this.student_comment_tb.Size = new System.Drawing.Size(306, 20);
            this.student_comment_tb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add Comments:";
            // 
            // student_post_tb
            // 
            this.student_post_tb.HideSelection = false;
            this.student_post_tb.Location = new System.Drawing.Point(7, 71);
            this.student_post_tb.Name = "student_post_tb";
            this.student_post_tb.Size = new System.Drawing.Size(287, 240);
            this.student_post_tb.TabIndex = 3;
            this.student_post_tb.UseCompatibleStateImageBehavior = false;
            this.student_post_tb.View = System.Windows.Forms.View.Tile;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher Posts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "class subject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "My classes";
            // 
            // classes_cmb
            // 
            this.classes_cmb.FormattingEnabled = true;
            this.classes_cmb.Location = new System.Drawing.Point(101, 24);
            this.classes_cmb.Name = "classes_cmb";
            this.classes_cmb.Size = new System.Drawing.Size(121, 21);
            this.classes_cmb.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gpa_tb);
            this.panel2.Controls.Add(this.calc_gpa_btn);
            this.panel2.Location = new System.Drawing.Point(525, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 414);
            this.panel2.TabIndex = 3;
            // 
            // gpa_tb
            // 
            this.gpa_tb.Location = new System.Drawing.Point(60, 138);
            this.gpa_tb.Name = "gpa_tb";
            this.gpa_tb.ReadOnly = true;
            this.gpa_tb.Size = new System.Drawing.Size(121, 20);
            this.gpa_tb.TabIndex = 2;
            // 
            // calc_gpa_btn
            // 
            this.calc_gpa_btn.Location = new System.Drawing.Point(60, 226);
            this.calc_gpa_btn.Name = "calc_gpa_btn";
            this.calc_gpa_btn.Size = new System.Drawing.Size(121, 30);
            this.calc_gpa_btn.TabIndex = 0;
            this.calc_gpa_btn.Text = "Calculate GPA ";
            this.calc_gpa_btn.UseVisualStyleBackColor = true;
            this.calc_gpa_btn.Click += new System.EventHandler(this.calc_gpa_btn_Click);
            // 
            // choose_class_btn
            // 
            this.choose_class_btn.Location = new System.Drawing.Point(101, 68);
            this.choose_class_btn.Name = "choose_class_btn";
            this.choose_class_btn.Size = new System.Drawing.Size(89, 23);
            this.choose_class_btn.TabIndex = 4;
            this.choose_class_btn.Text = "Choose class";
            this.choose_class_btn.UseVisualStyleBackColor = true;
            this.choose_class_btn.Click += new System.EventHandler(this.choose_class_btn_Click);
            // 
            // register_class_btn
            // 
            this.register_class_btn.Location = new System.Drawing.Point(444, 68);
            this.register_class_btn.Name = "register_class_btn";
            this.register_class_btn.Size = new System.Drawing.Size(94, 23);
            this.register_class_btn.TabIndex = 5;
            this.register_class_btn.Text = "Register to class";
            this.register_class_btn.UseVisualStyleBackColor = true;
            this.register_class_btn.Click += new System.EventHandler(this.register_class_btn_Click);
            // 
            // other_cmb
            // 
            this.other_cmb.FormattingEnabled = true;
            this.other_cmb.Location = new System.Drawing.Point(444, 24);
            this.other_cmb.Name = "other_cmb";
            this.other_cmb.Size = new System.Drawing.Size(121, 21);
            this.other_cmb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Other classes";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.other_cmb);
            this.Controls.Add(this.register_class_btn);
            this.Controls.Add(this.choose_class_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.classes_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox classes_cmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button student_comment_btn;
        private System.Windows.Forms.TextBox student_comment_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView student_post_tb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox gpa_tb;
        private System.Windows.Forms.Button calc_gpa_btn;
        private System.Windows.Forms.Button choose_class_btn;
        private System.Windows.Forms.Button register_class_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ComboBox other_cmb;
        private System.Windows.Forms.Label label5;
    }
}