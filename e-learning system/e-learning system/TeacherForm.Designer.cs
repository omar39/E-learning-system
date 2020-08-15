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
            this.manageClassGroup = new System.Windows.Forms.GroupBox();
            this.MyClassesGroup = new System.Windows.Forms.GroupBox();
            this.chatView = new System.Windows.Forms.ListView();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip.SuspendLayout();
            this.MyClassesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // postEditor
            // 
            this.postEditor.Location = new System.Drawing.Point(12, 293);
            this.postEditor.Multiline = true;
            this.postEditor.Name = "postEditor";
            this.postEditor.Size = new System.Drawing.Size(294, 31);
            this.postEditor.TabIndex = 0;
            // 
            // post_btn
            // 
            this.post_btn.Location = new System.Drawing.Point(325, 301);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(75, 23);
            this.post_btn.TabIndex = 1;
            this.post_btn.Text = "Post";
            this.post_btn.UseVisualStyleBackColor = true;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripComboBox1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 27);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.fileToolStripMenuItem.Text = "Classes";
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.classesToolStripMenuItem.Text = "Classes";
            // 
            // manageClassGroup
            // 
            this.manageClassGroup.Location = new System.Drawing.Point(444, 50);
            this.manageClassGroup.Name = "manageClassGroup";
            this.manageClassGroup.Size = new System.Drawing.Size(278, 371);
            this.manageClassGroup.TabIndex = 3;
            this.manageClassGroup.TabStop = false;
            this.manageClassGroup.Text = "Manage classes";
            // 
            // MyClassesGroup
            // 
            this.MyClassesGroup.Controls.Add(this.chatView);
            this.MyClassesGroup.Controls.Add(this.postEditor);
            this.MyClassesGroup.Controls.Add(this.post_btn);
            this.MyClassesGroup.Location = new System.Drawing.Point(12, 50);
            this.MyClassesGroup.Name = "MyClassesGroup";
            this.MyClassesGroup.Size = new System.Drawing.Size(406, 371);
            this.MyClassesGroup.TabIndex = 4;
            this.MyClassesGroup.TabStop = false;
            this.MyClassesGroup.Text = "My Classes";
            // 
            // chatView
            // 
            this.chatView.HideSelection = false;
            this.chatView.Location = new System.Drawing.Point(12, 26);
            this.chatView.Name = "chatView";
            this.chatView.Size = new System.Drawing.Size(287, 256);
            this.chatView.TabIndex = 2;
            this.chatView.UseCompatibleStateImageBehavior = false;
            this.chatView.View = System.Windows.Forms.View.Tile;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyClassesGroup);
            this.Controls.Add(this.manageClassGroup);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ListView chatView;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}