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
            this.AddNewDocument.Location = new System.Drawing.Point(13, 13);
            this.AddNewDocument.Name = "AddNewDocument";
            this.AddNewDocument.Size = new System.Drawing.Size(181, 23);
            this.AddNewDocument.TabIndex = 1;
            this.AddNewDocument.Text = "Add New Document";
            this.AddNewDocument.UseVisualStyleBackColor = true;
            this.AddNewDocument.Click += new System.EventHandler(this.AddNewDocument_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 642);
            this.Controls.Add(this.AddNewDocument);
            this.Controls.Add(this.DocumentsList);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DocumentsList;
        private System.Windows.Forms.Button AddNewDocument;
    }
}

