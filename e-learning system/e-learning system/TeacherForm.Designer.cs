namespace e_learning_system
{
    partial class TeacherForm
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
            this.postEditor = new System.Windows.Forms.TextBox();
            this.post_btn = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classes_strip = new System.Windows.Forms.ToolStripComboBox();
            this.manageClassGroup = new System.Windows.Forms.GroupBox();
            this.join_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.other_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update_grade_btn = new System.Windows.Forms.Button();
            this.students_cmb = new System.Windows.Forms.ComboBox();
            this.grade_box = new System.Windows.Forms.TextBox();
            this.MyClassesGroup = new System.Windows.Forms.GroupBox();
            this.posts_view = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.subject_lbl = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.manageClassGroup.SuspendLayout();
            this.MyClassesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // postEditor
            // 
            this.postEditor.Location = new System.Drawing.Point(16, 361);
            this.postEditor.Margin = new System.Windows.Forms.Padding(4);
            this.postEditor.Multiline = true;
            this.postEditor.Name = "postEditor";
            this.postEditor.Size = new System.Drawing.Size(391, 37);
            this.postEditor.TabIndex = 0;
            // 
            // post_btn
            // 
            this.post_btn.Location = new System.Drawing.Point(433, 370);
            this.post_btn.Margin = new System.Windows.Forms.Padding(4);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(100, 28);
            this.post_btn.TabIndex = 1;
            this.post_btn.Text = "Post";
            this.post_btn.UseVisualStyleBackColor = true;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.classes_strip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1067, 32);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
            this.fileToolStripMenuItem.Text = "Classes";
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // classes_strip
            // 
            this.classes_strip.Name = "classes_strip";
            this.classes_strip.Size = new System.Drawing.Size(160, 28);
            this.classes_strip.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // manageClassGroup
            // 
            this.manageClassGroup.Controls.Add(this.join_btn);
            this.manageClassGroup.Controls.Add(this.label3);
            this.manageClassGroup.Controls.Add(this.other_cmb);
            this.manageClassGroup.Controls.Add(this.label2);
            this.manageClassGroup.Controls.Add(this.label1);
            this.manageClassGroup.Controls.Add(this.update_grade_btn);
            this.manageClassGroup.Controls.Add(this.students_cmb);
            this.manageClassGroup.Controls.Add(this.grade_box);
            this.manageClassGroup.Location = new System.Drawing.Point(592, 62);
            this.manageClassGroup.Margin = new System.Windows.Forms.Padding(4);
            this.manageClassGroup.Name = "manageClassGroup";
            this.manageClassGroup.Padding = new System.Windows.Forms.Padding(4);
            this.manageClassGroup.Size = new System.Drawing.Size(371, 457);
            this.manageClassGroup.TabIndex = 3;
            this.manageClassGroup.TabStop = false;
            this.manageClassGroup.Text = "Manage classes";
            // 
            // join_btn
            // 
            this.join_btn.Location = new System.Drawing.Point(120, 262);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(121, 32);
            this.join_btn.TabIndex = 7;
            this.join_btn.Text = "Join class";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Classes";
            // 
            // other_cmb
            // 
            this.other_cmb.FormattingEnabled = true;
            this.other_cmb.Location = new System.Drawing.Point(120, 216);
            this.other_cmb.Name = "other_cmb";
            this.other_cmb.Size = new System.Drawing.Size(121, 24);
            this.other_cmb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Class students";
            // 
            // update_grade_btn
            // 
            this.update_grade_btn.Location = new System.Drawing.Point(258, 98);
            this.update_grade_btn.Name = "update_grade_btn";
            this.update_grade_btn.Size = new System.Drawing.Size(106, 32);
            this.update_grade_btn.TabIndex = 2;
            this.update_grade_btn.Text = "Update grade";
            this.update_grade_btn.UseVisualStyleBackColor = true;
            this.update_grade_btn.Click += new System.EventHandler(this.update_grade_btn_Click);
            // 
            // students_cmb
            // 
            this.students_cmb.FormattingEnabled = true;
            this.students_cmb.Location = new System.Drawing.Point(120, 47);
            this.students_cmb.Name = "students_cmb";
            this.students_cmb.Size = new System.Drawing.Size(121, 24);
            this.students_cmb.TabIndex = 1;
            this.students_cmb.SelectedIndexChanged += new System.EventHandler(this.students_cmb_SelectedIndexChanged);
            // 
            // grade_box
            // 
            this.grade_box.Location = new System.Drawing.Point(120, 103);
            this.grade_box.Name = "grade_box";
            this.grade_box.Size = new System.Drawing.Size(121, 22);
            this.grade_box.TabIndex = 0;
            // 
            // MyClassesGroup
            // 
            this.MyClassesGroup.Controls.Add(this.posts_view);
            this.MyClassesGroup.Controls.Add(this.postEditor);
            this.MyClassesGroup.Controls.Add(this.post_btn);
            this.MyClassesGroup.Location = new System.Drawing.Point(16, 62);
            this.MyClassesGroup.Margin = new System.Windows.Forms.Padding(4);
            this.MyClassesGroup.Name = "MyClassesGroup";
            this.MyClassesGroup.Padding = new System.Windows.Forms.Padding(4);
            this.MyClassesGroup.Size = new System.Drawing.Size(541, 457);
            this.MyClassesGroup.TabIndex = 4;
            this.MyClassesGroup.TabStop = false;
            this.MyClassesGroup.Text = "Posts";
            // 
            // posts_view
            // 
            this.posts_view.HideSelection = false;
            this.posts_view.Location = new System.Drawing.Point(16, 32);
            this.posts_view.Margin = new System.Windows.Forms.Padding(4);
            this.posts_view.Name = "posts_view";
            this.posts_view.Size = new System.Drawing.Size(381, 314);
            this.posts_view.TabIndex = 2;
            this.posts_view.UseCompatibleStateImageBehavior = false;
            this.posts_view.View = System.Windows.Forms.View.Tile;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject:";
            // 
            // subject_lbl
            // 
            this.subject_lbl.AutoSize = true;
            this.subject_lbl.Location = new System.Drawing.Point(457, 38);
            this.subject_lbl.Name = "subject_lbl";
            this.subject_lbl.Size = new System.Drawing.Size(39, 17);
            this.subject_lbl.TabIndex = 6;
            this.subject_lbl.Text = "temp";
            this.subject_lbl.Visible = false;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.subject_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MyClassesGroup);
            this.Controls.Add(this.manageClassGroup);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherForm_FormClosed);
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.manageClassGroup.ResumeLayout(false);
            this.manageClassGroup.PerformLayout();
            this.MyClassesGroup.ResumeLayout(false);
            this.MyClassesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox postEditor;
        private System.Windows.Forms.Button post_btn;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.GroupBox manageClassGroup;
        private System.Windows.Forms.GroupBox MyClassesGroup;
        private System.Windows.Forms.ListView posts_view;
        private System.Windows.Forms.ToolStripComboBox classes_strip;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox other_cmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_grade_btn;
        private System.Windows.Forms.ComboBox students_cmb;
        private System.Windows.Forms.TextBox grade_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label subject_lbl;
    }
}