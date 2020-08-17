namespace e_learning_system
{
    partial class AdminForm
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
            this.pendingRequestsLabel = new System.Windows.Forms.Label();
            this.pendingList = new System.Windows.Forms.ListBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.Approve_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.searchResultsList = new System.Windows.Forms.ListBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pendingRequestsLabel
            // 
            this.pendingRequestsLabel.AutoSize = true;
            this.pendingRequestsLabel.Location = new System.Drawing.Point(55, 104);
            this.pendingRequestsLabel.Name = "pendingRequestsLabel";
            this.pendingRequestsLabel.Size = new System.Drawing.Size(90, 13);
            this.pendingRequestsLabel.TabIndex = 0;
            this.pendingRequestsLabel.Text = "Pending requests";
            // 
            // pendingList
            // 
            this.pendingList.FormattingEnabled = true;
            this.pendingList.Location = new System.Drawing.Point(58, 143);
            this.pendingList.Name = "pendingList";
            this.pendingList.Size = new System.Drawing.Size(168, 134);
            this.pendingList.TabIndex = 1;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(281, 40);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(197, 25);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Admin control page";
            // 
            // Approve_btn
            // 
            this.Approve_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Approve_btn.Location = new System.Drawing.Point(96, 293);
            this.Approve_btn.Name = "Approve_btn";
            this.Approve_btn.Size = new System.Drawing.Size(75, 23);
            this.Approve_btn.TabIndex = 3;
            this.Approve_btn.Text = "Approve";
            this.Approve_btn.UseVisualStyleBackColor = true;
            this.Approve_btn.Click += new System.EventHandler(this.Approve_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delete user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search for user name";
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(575, 130);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(100, 20);
            this.searchBar.TabIndex = 6;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(479, 182);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            // 
            // searchResultsList
            // 
            this.searchResultsList.FormattingEnabled = true;
            this.searchResultsList.Location = new System.Drawing.Point(575, 182);
            this.searchResultsList.Name = "searchResultsList";
            this.searchResultsList.Size = new System.Drawing.Size(149, 95);
            this.searchResultsList.TabIndex = 8;
            this.searchResultsList.SelectedIndexChanged += new System.EventHandler(this.searchResultsList_SelectedIndexChanged);
            // 
            // delete_btn
            // 
            this.delete_btn.Enabled = false;
            this.delete_btn.Location = new System.Drawing.Point(478, 254);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 9;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.searchResultsList);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Approve_btn);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.pendingList);
            this.Controls.Add(this.pendingRequestsLabel);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pendingRequestsLabel;
        private System.Windows.Forms.ListBox pendingList;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button Approve_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ListBox searchResultsList;
        private System.Windows.Forms.Button delete_btn;
    }
}