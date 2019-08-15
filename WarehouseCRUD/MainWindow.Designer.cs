namespace WarehouseCRUD
{
    partial class MainWindow
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
            this.DocumentsList = new System.Windows.Forms.ListBox();
            this.AddNewDocument = new System.Windows.Forms.Button();
            this.RepositoryNameLabel = new System.Windows.Forms.Label();
            this.RepositoryCreatedLabel = new System.Windows.Forms.Label();
            this.RepositoryCloneUrlLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DocumentsList
            // 
            this.DocumentsList.FormattingEnabled = true;
            this.DocumentsList.Location = new System.Drawing.Point(12, 277);
            this.DocumentsList.Name = "DocumentsList";
            this.DocumentsList.Size = new System.Drawing.Size(1019, 355);
            this.DocumentsList.TabIndex = 0;
            this.DocumentsList.SelectedIndexChanged += new System.EventHandler(this.DocumentsList_SelectedIndexChanged);
            // 
            // AddNewDocument
            // 
            this.AddNewDocument.Location = new System.Drawing.Point(12, 248);
            this.AddNewDocument.Name = "AddNewDocument";
            this.AddNewDocument.Size = new System.Drawing.Size(181, 23);
            this.AddNewDocument.TabIndex = 1;
            this.AddNewDocument.Text = "Add New Document";
            this.AddNewDocument.UseVisualStyleBackColor = true;
            this.AddNewDocument.Click += new System.EventHandler(this.AddNewDocument_Click);
            // 
            // RepositoryNameLabel
            // 
            this.RepositoryNameLabel.AutoSize = true;
            this.RepositoryNameLabel.Location = new System.Drawing.Point(110, 9);
            this.RepositoryNameLabel.Name = "RepositoryNameLabel";
            this.RepositoryNameLabel.Size = new System.Drawing.Size(0, 13);
            this.RepositoryNameLabel.TabIndex = 2;
            // 
            // RepositoryCreatedLabel
            // 
            this.RepositoryCreatedLabel.AutoSize = true;
            this.RepositoryCreatedLabel.Location = new System.Drawing.Point(110, 50);
            this.RepositoryCreatedLabel.Name = "RepositoryCreatedLabel";
            this.RepositoryCreatedLabel.Size = new System.Drawing.Size(0, 13);
            this.RepositoryCreatedLabel.TabIndex = 3;
            // 
            // RepositoryCloneUrlLabel
            // 
            this.RepositoryCloneUrlLabel.AutoSize = true;
            this.RepositoryCloneUrlLabel.Location = new System.Drawing.Point(110, 95);
            this.RepositoryCloneUrlLabel.Name = "RepositoryCloneUrlLabel";
            this.RepositoryCloneUrlLabel.Size = new System.Drawing.Size(0, 13);
            this.RepositoryCloneUrlLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Repository name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Created at:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clone URL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Double click to edit document";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 642);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RepositoryCloneUrlLabel);
            this.Controls.Add(this.RepositoryCreatedLabel);
            this.Controls.Add(this.RepositoryNameLabel);
            this.Controls.Add(this.AddNewDocument);
            this.Controls.Add(this.DocumentsList);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DocumentsList;
        private System.Windows.Forms.Button AddNewDocument;
        private System.Windows.Forms.Label RepositoryNameLabel;
        private System.Windows.Forms.Label RepositoryCreatedLabel;
        private System.Windows.Forms.Label RepositoryCloneUrlLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

