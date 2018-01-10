namespace Image_Resizer
{
    partial class formMain
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
            this.clbItemList = new System.Windows.Forms.CheckedListBox();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnImportImages = new System.Windows.Forms.Button();
            this.btnProcessImages = new System.Windows.Forms.Button();
            this.verticalDivider3 = new System.Windows.Forms.Label();
            this.verticalDivider2 = new System.Windows.Forms.Label();
            this.horizontalDivider1 = new System.Windows.Forms.Label();
            this.lblMemoryUsage = new System.Windows.Forms.Label();
            this.lblProcessorUsage = new System.Windows.Forms.Label();
            this.lblImagesProcessed = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.verticalDivider1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbItemList
            // 
            this.clbItemList.AllowDrop = true;
            this.clbItemList.CheckOnClick = true;
            this.clbItemList.ColumnWidth = 200;
            this.clbItemList.FormattingEnabled = true;
            this.clbItemList.Location = new System.Drawing.Point(13, 13);
            this.clbItemList.MultiColumn = true;
            this.clbItemList.Name = "clbItemList";
            this.clbItemList.Size = new System.Drawing.Size(400, 454);
            this.clbItemList.TabIndex = 0;
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(423, 25);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(150, 23);
            this.btnInstructions.TabIndex = 1;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(423, 92);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(423, 161);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(150, 50);
            this.btnClearList.TabIndex = 3;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // btnImportImages
            // 
            this.btnImportImages.Location = new System.Drawing.Point(423, 262);
            this.btnImportImages.Name = "btnImportImages";
            this.btnImportImages.Size = new System.Drawing.Size(150, 50);
            this.btnImportImages.TabIndex = 4;
            this.btnImportImages.Text = "Import Images From Folder";
            this.btnImportImages.UseVisualStyleBackColor = true;
            this.btnImportImages.Click += new System.EventHandler(this.btnImportImages_Click);
            // 
            // btnProcessImages
            // 
            this.btnProcessImages.Location = new System.Drawing.Point(423, 367);
            this.btnProcessImages.Name = "btnProcessImages";
            this.btnProcessImages.Size = new System.Drawing.Size(150, 100);
            this.btnProcessImages.TabIndex = 5;
            this.btnProcessImages.Text = "Process Image List";
            this.btnProcessImages.UseVisualStyleBackColor = true;
            this.btnProcessImages.Click += new System.EventHandler(this.btnProcessImages_Click);
            // 
            // verticalDivider3
            // 
            this.verticalDivider3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalDivider3.Location = new System.Drawing.Point(423, 341);
            this.verticalDivider3.Name = "verticalDivider3";
            this.verticalDivider3.Size = new System.Drawing.Size(150, 2);
            this.verticalDivider3.TabIndex = 6;
            // 
            // verticalDivider2
            // 
            this.verticalDivider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalDivider2.Location = new System.Drawing.Point(423, 236);
            this.verticalDivider2.Name = "verticalDivider2";
            this.verticalDivider2.Size = new System.Drawing.Size(150, 2);
            this.verticalDivider2.TabIndex = 7;
            // 
            // horizontalDivider1
            // 
            this.horizontalDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalDivider1.Location = new System.Drawing.Point(423, 68);
            this.horizontalDivider1.Name = "horizontalDivider1";
            this.horizontalDivider1.Size = new System.Drawing.Size(150, 2);
            this.horizontalDivider1.TabIndex = 8;
            // 
            // lblMemoryUsage
            // 
            this.lblMemoryUsage.AutoSize = true;
            this.lblMemoryUsage.Location = new System.Drawing.Point(25, 480);
            this.lblMemoryUsage.Name = "lblMemoryUsage";
            this.lblMemoryUsage.Size = new System.Drawing.Size(84, 13);
            this.lblMemoryUsage.TabIndex = 9;
            this.lblMemoryUsage.Text = "Memory Usage :";
            // 
            // lblProcessorUsage
            // 
            this.lblProcessorUsage.AutoSize = true;
            this.lblProcessorUsage.Location = new System.Drawing.Point(18, 503);
            this.lblProcessorUsage.Name = "lblProcessorUsage";
            this.lblProcessorUsage.Size = new System.Drawing.Size(91, 13);
            this.lblProcessorUsage.TabIndex = 10;
            this.lblProcessorUsage.Text = "Processor Usage:";
            // 
            // lblImagesProcessed
            // 
            this.lblImagesProcessed.AutoSize = true;
            this.lblImagesProcessed.Location = new System.Drawing.Point(298, 480);
            this.lblImagesProcessed.Name = "lblImagesProcessed";
            this.lblImagesProcessed.Size = new System.Drawing.Size(100, 13);
            this.lblImagesProcessed.TabIndex = 11;
            this.lblImagesProcessed.Text = "Images Processed :";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(321, 503);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(77, 13);
            this.lblTimeElapsed.TabIndex = 12;
            this.lblTimeElapsed.Text = "Time Elapsed :";
            // 
            // verticalDivider1
            // 
            this.verticalDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalDivider1.Location = new System.Drawing.Point(293, 479);
            this.verticalDivider1.Name = "verticalDivider1";
            this.verticalDivider1.Size = new System.Drawing.Size(2, 44);
            this.verticalDivider1.TabIndex = 13;
            // 
            // formMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 532);
            this.Controls.Add(this.horizontalDivider1);
            this.Controls.Add(this.verticalDivider1);
            this.Controls.Add(this.verticalDivider2);
            this.Controls.Add(this.verticalDivider3);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblImagesProcessed);
            this.Controls.Add(this.lblProcessorUsage);
            this.Controls.Add(this.lblMemoryUsage);
            this.Controls.Add(this.btnProcessImages);
            this.Controls.Add(this.btnImportImages);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.clbItemList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.Text = "Image Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbItemList;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnImportImages;
        private System.Windows.Forms.Button btnProcessImages;
        private System.Windows.Forms.Label verticalDivider3;
        private System.Windows.Forms.Label verticalDivider2;
        private System.Windows.Forms.Label horizontalDivider1;
        private System.Windows.Forms.Label lblMemoryUsage;
        private System.Windows.Forms.Label lblProcessorUsage;
        private System.Windows.Forms.Label lblImagesProcessed;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label verticalDivider1;
    }
}

