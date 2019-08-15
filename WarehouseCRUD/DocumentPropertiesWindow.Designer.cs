namespace WarehouseCRUD
{
    partial class DocumentPropertiesWindow
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
            this.ClientNumberTextBox = new System.Windows.Forms.TextBox();
            this.DocumenNameTextBox = new System.Windows.Forms.TextBox();
            this.CreatedDataLabel = new System.Windows.Forms.Label();
            this.SumNettoDataLabel = new System.Windows.Forms.Label();
            this.SumBruttoDataLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreatedTextLabel = new System.Windows.Forms.Label();
            this.ClientNumberTextLabel = new System.Windows.Forms.Label();
            this.DocumentNameTextLabel = new System.Windows.Forms.Label();
            this.SumNettoTextLabel = new System.Windows.Forms.Label();
            this.SumBruttoTextLabel = new System.Windows.Forms.Label();
            this.ItemsTextLabel = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientNumberTextBox
            // 
            this.ClientNumberTextBox.Location = new System.Drawing.Point(100, 47);
            this.ClientNumberTextBox.Name = "ClientNumberTextBox";
            this.ClientNumberTextBox.Size = new System.Drawing.Size(370, 20);
            this.ClientNumberTextBox.TabIndex = 1;
            // 
            // DocumenNameTextBox
            // 
            this.DocumenNameTextBox.Location = new System.Drawing.Point(100, 74);
            this.DocumenNameTextBox.Name = "DocumenNameTextBox";
            this.DocumenNameTextBox.Size = new System.Drawing.Size(370, 20);
            this.DocumenNameTextBox.TabIndex = 2;
            // 
            // CreatedDataLabel
            // 
            this.CreatedDataLabel.AutoSize = true;
            this.CreatedDataLabel.Location = new System.Drawing.Point(100, 21);
            this.CreatedDataLabel.Name = "CreatedDataLabel";
            this.CreatedDataLabel.Size = new System.Drawing.Size(35, 13);
            this.CreatedDataLabel.TabIndex = 4;
            this.CreatedDataLabel.Text = "label1";
            // 
            // SumNettoDataLabel
            // 
            this.SumNettoDataLabel.AutoSize = true;
            this.SumNettoDataLabel.Location = new System.Drawing.Point(100, 101);
            this.SumNettoDataLabel.Name = "SumNettoDataLabel";
            this.SumNettoDataLabel.Size = new System.Drawing.Size(35, 13);
            this.SumNettoDataLabel.TabIndex = 5;
            this.SumNettoDataLabel.Text = "label2";
            // 
            // SumBruttoDataLabel
            // 
            this.SumBruttoDataLabel.AutoSize = true;
            this.SumBruttoDataLabel.Location = new System.Drawing.Point(100, 118);
            this.SumBruttoDataLabel.Name = "SumBruttoDataLabel";
            this.SumBruttoDataLabel.Size = new System.Drawing.Size(35, 13);
            this.SumBruttoDataLabel.TabIndex = 6;
            this.SumBruttoDataLabel.Text = "label3";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(100, 200);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(370, 238);
            this.ItemsListBox.TabIndex = 7;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(542, 47);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(103, 23);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(542, 113);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(103, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreatedTextLabel
            // 
            this.CreatedTextLabel.AutoSize = true;
            this.CreatedTextLabel.Location = new System.Drawing.Point(13, 21);
            this.CreatedTextLabel.Name = "CreatedTextLabel";
            this.CreatedTextLabel.Size = new System.Drawing.Size(44, 13);
            this.CreatedTextLabel.TabIndex = 10;
            this.CreatedTextLabel.Text = "Created";
            // 
            // ClientNumberTextLabel
            // 
            this.ClientNumberTextLabel.AutoSize = true;
            this.ClientNumberTextLabel.Location = new System.Drawing.Point(12, 54);
            this.ClientNumberTextLabel.Name = "ClientNumberTextLabel";
            this.ClientNumberTextLabel.Size = new System.Drawing.Size(73, 13);
            this.ClientNumberTextLabel.TabIndex = 11;
            this.ClientNumberTextLabel.Text = "Client Number";
            // 
            // DocumentNameTextLabel
            // 
            this.DocumentNameTextLabel.AutoSize = true;
            this.DocumentNameTextLabel.Location = new System.Drawing.Point(12, 81);
            this.DocumentNameTextLabel.Name = "DocumentNameTextLabel";
            this.DocumentNameTextLabel.Size = new System.Drawing.Size(87, 13);
            this.DocumentNameTextLabel.TabIndex = 12;
            this.DocumentNameTextLabel.Text = "Document Name";
            // 
            // SumNettoTextLabel
            // 
            this.SumNettoTextLabel.AutoSize = true;
            this.SumNettoTextLabel.Location = new System.Drawing.Point(13, 101);
            this.SumNettoTextLabel.Name = "SumNettoTextLabel";
            this.SumNettoTextLabel.Size = new System.Drawing.Size(57, 13);
            this.SumNettoTextLabel.TabIndex = 13;
            this.SumNettoTextLabel.Text = "Sum Netto";
            // 
            // SumBruttoTextLabel
            // 
            this.SumBruttoTextLabel.AutoSize = true;
            this.SumBruttoTextLabel.Location = new System.Drawing.Point(13, 118);
            this.SumBruttoTextLabel.Name = "SumBruttoTextLabel";
            this.SumBruttoTextLabel.Size = new System.Drawing.Size(59, 13);
            this.SumBruttoTextLabel.TabIndex = 14;
            this.SumBruttoTextLabel.Text = "Sum Brutto";
            // 
            // ItemsTextLabel
            // 
            this.ItemsTextLabel.AutoSize = true;
            this.ItemsTextLabel.Location = new System.Drawing.Point(103, 181);
            this.ItemsTextLabel.Name = "ItemsTextLabel";
            this.ItemsTextLabel.Size = new System.Drawing.Size(32, 13);
            this.ItemsTextLabel.TabIndex = 15;
            this.ItemsTextLabel.Text = "Items";
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(542, 200);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(103, 23);
            this.AddItemButton.TabIndex = 16;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(542, 81);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(103, 23);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Double click to delete item";
            // 
            // DocumentPropertiesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ItemsTextLabel);
            this.Controls.Add(this.SumBruttoTextLabel);
            this.Controls.Add(this.SumNettoTextLabel);
            this.Controls.Add(this.DocumentNameTextLabel);
            this.Controls.Add(this.ClientNumberTextLabel);
            this.Controls.Add(this.CreatedTextLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.SumBruttoDataLabel);
            this.Controls.Add(this.SumNettoDataLabel);
            this.Controls.Add(this.CreatedDataLabel);
            this.Controls.Add(this.DocumenNameTextBox);
            this.Controls.Add(this.ClientNumberTextBox);
            this.Name = "DocumentPropertiesWindow";
            this.Text = "PropertiesWindow";
            this.Load += new System.EventHandler(this.PropertiesWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ClientNumberTextBox;
        private System.Windows.Forms.TextBox DocumenNameTextBox;
        private System.Windows.Forms.Label CreatedDataLabel;
        private System.Windows.Forms.Label SumNettoDataLabel;
        private System.Windows.Forms.Label SumBruttoDataLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label CreatedTextLabel;
        private System.Windows.Forms.Label ClientNumberTextLabel;
        private System.Windows.Forms.Label DocumentNameTextLabel;
        private System.Windows.Forms.Label SumNettoTextLabel;
        private System.Windows.Forms.Label SumBruttoTextLabel;
        private System.Windows.Forms.Label ItemsTextLabel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
    }
}