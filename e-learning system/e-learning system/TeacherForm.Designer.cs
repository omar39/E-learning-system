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
            this.search_btn = new System.Windows.Forms.Button();
            this.searchResultsList = new System.Windows.Forms.ListBox();
            this.join_btn = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MyClassesGroup = new System.Windows.Forms.GroupBox();
            this.posts_view = new System.Windows.Forms.ListView();
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
            this.manageClassGroup.Controls.Add(this.search_btn);
            this.manageClassGroup.Controls.Add(this.searchResultsList);
            this.manageClassGroup.Controls.Add(this.join_btn);
            this.manageClassGroup.Controls.Add(this.searchBar);
            this.manageClassGroup.Controls.Add(this.label1);
            this.manageClassGroup.Location = new System.Drawing.Point(592, 62);
            this.manageClassGroup.Margin = new System.Windows.Forms.Padding(4);
            this.manageClassGroup.Name = "manageClassGroup";
            this.manageClassGroup.Padding = new System.Windows.Forms.Padding(4);
            this.manageClassGroup.Size = new System.Drawing.Size(371, 457);
            this.manageClassGroup.TabIndex = 3;
            this.manageClassGroup.TabStop = false;
            this.manageClassGroup.Text = "Manage classes";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(28, 114);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(100, 28);
            this.search_btn.TabIndex = 5;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // searchResultsList
            // 
            this.searchResultsList.FormattingEnabled = true;
            this.searchResultsList.ItemHeight = 16;
            this.searchResultsList.Location = new System.Drawing.Point(28, 175);
            this.searchResultsList.Margin = new System.Windows.Forms.Padding(4);
            this.searchResultsList.Name = "searchResultsList";
            this.searchResultsList.Size = new System.Drawing.Size(256, 116);
            this.searchResultsList.TabIndex = 4;
            this.searchResultsList.SelectedIndexChanged += new System.EventHandler(this.searchResultsList_SelectedIndexChanged);
            // 
            // join_btn
            // 
            this.join_btn.Location = new System.Drawing.Point(185, 319);
            this.join_btn.Margin = new System.Windows.Forms.Padding(4);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(100, 28);
            this.join_btn.TabIndex = 3;
            this.join_btn.Text = "Join";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Visible = false;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(133, 64);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(151, 22);
            this.searchBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Join a class";
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
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.ListBox searchResultsList;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ToolStripComboBox classes_strip;
    }
}