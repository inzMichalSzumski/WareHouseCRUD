namespace WarehouseCRUD
{
    partial class ItemProperties
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NettoPriceTextLabel = new System.Windows.Forms.Label();
            this.BruttoPriceTextLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NettoPriceTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.BruttoPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(123, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // NettoPriceTextLabel
            // 
            this.NettoPriceTextLabel.AutoSize = true;
            this.NettoPriceTextLabel.Location = new System.Drawing.Point(12, 35);
            this.NettoPriceTextLabel.Name = "NettoPriceTextLabel";
            this.NettoPriceTextLabel.Size = new System.Drawing.Size(60, 13);
            this.NettoPriceTextLabel.TabIndex = 2;
            this.NettoPriceTextLabel.Text = "Netto Price";
            // 
            // BruttoPriceTextLabel
            // 
            this.BruttoPriceTextLabel.AutoSize = true;
            this.BruttoPriceTextLabel.Location = new System.Drawing.Point(12, 61);
            this.BruttoPriceTextLabel.Name = "BruttoPriceTextLabel";
            this.BruttoPriceTextLabel.Size = new System.Drawing.Size(62, 13);
            this.BruttoPriceTextLabel.TabIndex = 3;
            this.BruttoPriceTextLabel.Text = "Brutto Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount";
            // 
            // NettoPriceTextBox
            // 
            this.NettoPriceTextBox.Location = new System.Drawing.Point(123, 35);
            this.NettoPriceTextBox.Name = "NettoPriceTextBox";
            this.NettoPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.NettoPriceTextBox.TabIndex = 5;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(123, 89);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountTextBox.TabIndex = 12;
            // 
            // BruttoPriceTextBox
            // 
            this.BruttoPriceTextBox.Location = new System.Drawing.Point(123, 61);
            this.BruttoPriceTextBox.Name = "BruttoPriceTextBox";
            this.BruttoPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BruttoPriceTextBox.TabIndex = 9;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(89, 123);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddItemButton.TabIndex = 20;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ItemProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 158);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.BruttoPriceTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.NettoPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BruttoPriceTextLabel);
            this.Controls.Add(this.NettoPriceTextLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Name = "ItemProperties";
            this.Text = "ItemProperties";
            this.Load += new System.EventHandler(this.ItemProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NettoPriceTextLabel;
        private System.Windows.Forms.Label BruttoPriceTextLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NettoPriceTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox BruttoPriceTextBox;
        private System.Windows.Forms.Button AddItemButton;
    }
}