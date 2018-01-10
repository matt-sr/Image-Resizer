namespace Image_Resizer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnImportImages = new System.Windows.Forms.Button();
            this.btnProcessImages = new System.Windows.Forms.Button();
            this.lblDecPanel3 = new System.Windows.Forms.Label();
            this.lvItemList = new System.Windows.Forms.ListView();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(423, 40);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.BtnDeleteSelected_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(423, 96);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(150, 50);
            this.btnClearList.TabIndex = 3;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // btnImportImages
            // 
            this.btnImportImages.Location = new System.Drawing.Point(423, 171);
            this.btnImportImages.Name = "btnImportImages";
            this.btnImportImages.Size = new System.Drawing.Size(150, 50);
            this.btnImportImages.TabIndex = 4;
            this.btnImportImages.Text = "Import Images From Folder";
            this.btnImportImages.UseVisualStyleBackColor = true;
            this.btnImportImages.Click += new System.EventHandler(this.BtnImportImages_Click);
            // 
            // btnProcessImages
            // 
            this.btnProcessImages.Location = new System.Drawing.Point(423, 245);
            this.btnProcessImages.Name = "btnProcessImages";
            this.btnProcessImages.Size = new System.Drawing.Size(150, 91);
            this.btnProcessImages.TabIndex = 5;
            this.btnProcessImages.Text = "Process Image List";
            this.btnProcessImages.UseVisualStyleBackColor = true;
            this.btnProcessImages.Click += new System.EventHandler(this.BtnProcessImages_Click);
            // 
            // lblDecPanel3
            // 
            this.lblDecPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDecPanel3.Location = new System.Drawing.Point(419, 7);
            this.lblDecPanel3.Name = "lblDecPanel3";
            this.lblDecPanel3.Size = new System.Drawing.Size(158, 433);
            this.lblDecPanel3.TabIndex = 7;
            // 
            // lvItemList
            // 
            this.lvItemList.Location = new System.Drawing.Point(12, 7);
            this.lvItemList.Name = "lvItemList";
            this.lvItemList.Size = new System.Drawing.Size(400, 433);
            this.lvItemList.TabIndex = 15;
            this.lvItemList.UseCompatibleStateImageBehavior = false;
            this.lvItemList.View = System.Windows.Forms.View.List;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(432, 366);
            this.lblInstructions.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(133, 48);
            this.lblInstructions.TabIndex = 16;
            this.lblInstructions.Text = "Drag and Drop Images Here";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lvItemList);
            this.Controls.Add(this.btnProcessImages);
            this.Controls.Add(this.btnImportImages);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.lblDecPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Image Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnImportImages;
        private System.Windows.Forms.Button btnProcessImages;
        private System.Windows.Forms.Label lblDecPanel3;
        private System.Windows.Forms.ListView lvItemList;
        private System.Windows.Forms.Label lblInstructions;
    }
}

