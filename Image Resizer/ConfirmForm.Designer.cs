namespace Image_Resizer
{
    partial class ConfirmForm
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
            this.lblDecPanel2 = new System.Windows.Forms.Label();
            this.lblDecPanel1 = new System.Windows.Forms.Label();
            this.lblThumbTitle = new System.Windows.Forms.Label();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.tbDestinationThumb = new System.Windows.Forms.TextBox();
            this.btnGetThumbDestination = new System.Windows.Forms.Button();
            this.btnGetMainDestination = new System.Windows.Forms.Button();
            this.tbDestinationMain = new System.Windows.Forms.TextBox();
            this.tbTargetSizeThumb = new System.Windows.Forms.TextBox();
            this.lblThumbTargetTitle = new System.Windows.Forms.Label();
            this.tbTargetSizeMain = new System.Windows.Forms.TextBox();
            this.lblMainTargetTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMainDestTitle = new System.Windows.Forms.Label();
            this.lblThumbDestTitle = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblProcessed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDecPanel2
            // 
            this.lblDecPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDecPanel2.Location = new System.Drawing.Point(210, 9);
            this.lblDecPanel2.Name = "lblDecPanel2";
            this.lblDecPanel2.Size = new System.Drawing.Size(186, 108);
            this.lblDecPanel2.TabIndex = 8;
            // 
            // lblDecPanel1
            // 
            this.lblDecPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDecPanel1.Location = new System.Drawing.Point(12, 9);
            this.lblDecPanel1.Name = "lblDecPanel1";
            this.lblDecPanel1.Size = new System.Drawing.Size(186, 108);
            this.lblDecPanel1.TabIndex = 8;
            // 
            // lblThumbTitle
            // 
            this.lblThumbTitle.AutoSize = true;
            this.lblThumbTitle.Location = new System.Drawing.Point(76, 14);
            this.lblThumbTitle.Name = "lblThumbTitle";
            this.lblThumbTitle.Size = new System.Drawing.Size(56, 13);
            this.lblThumbTitle.TabIndex = 9;
            this.lblThumbTitle.Text = "Thumbnail";
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Location = new System.Drawing.Point(289, 14);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(30, 13);
            this.lblMainTitle.TabIndex = 9;
            this.lblMainTitle.Text = "Main";
            // 
            // tbDestinationThumb
            // 
            this.tbDestinationThumb.Location = new System.Drawing.Point(16, 57);
            this.tbDestinationThumb.Name = "tbDestinationThumb";
            this.tbDestinationThumb.ReadOnly = true;
            this.tbDestinationThumb.Size = new System.Drawing.Size(148, 20);
            this.tbDestinationThumb.TabIndex = 19;
            // 
            // btnGetThumbDestination
            // 
            this.btnGetThumbDestination.Location = new System.Drawing.Point(170, 57);
            this.btnGetThumbDestination.Name = "btnGetThumbDestination";
            this.btnGetThumbDestination.Size = new System.Drawing.Size(24, 20);
            this.btnGetThumbDestination.TabIndex = 11;
            this.btnGetThumbDestination.Text = "...";
            this.btnGetThumbDestination.UseVisualStyleBackColor = true;
            this.btnGetThumbDestination.Click += new System.EventHandler(this.BtnGetThumbDestination_Click);
            // 
            // btnGetMainDestination
            // 
            this.btnGetMainDestination.Location = new System.Drawing.Point(368, 57);
            this.btnGetMainDestination.Name = "btnGetMainDestination";
            this.btnGetMainDestination.Size = new System.Drawing.Size(24, 20);
            this.btnGetMainDestination.TabIndex = 13;
            this.btnGetMainDestination.Text = "...";
            this.btnGetMainDestination.UseVisualStyleBackColor = true;
            this.btnGetMainDestination.Click += new System.EventHandler(this.BtnGetMainDestination_Click);
            // 
            // tbDestinationMain
            // 
            this.tbDestinationMain.Location = new System.Drawing.Point(214, 57);
            this.tbDestinationMain.Name = "tbDestinationMain";
            this.tbDestinationMain.ReadOnly = true;
            this.tbDestinationMain.Size = new System.Drawing.Size(148, 20);
            this.tbDestinationMain.TabIndex = 18;
            // 
            // tbTargetSizeThumb
            // 
            this.tbTargetSizeThumb.Location = new System.Drawing.Point(96, 88);
            this.tbTargetSizeThumb.MaxLength = 5;
            this.tbTargetSizeThumb.Name = "tbTargetSizeThumb";
            this.tbTargetSizeThumb.Size = new System.Drawing.Size(98, 20);
            this.tbTargetSizeThumb.TabIndex = 14;
            this.tbTargetSizeThumb.Text = "120";
            this.tbTargetSizeThumb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTargetSizeThumb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTargetSizeThumb_KeyPress);
            // 
            // lblThumbTargetTitle
            // 
            this.lblThumbTargetTitle.AutoSize = true;
            this.lblThumbTargetTitle.Location = new System.Drawing.Point(13, 91);
            this.lblThumbTargetTitle.Name = "lblThumbTargetTitle";
            this.lblThumbTargetTitle.Size = new System.Drawing.Size(79, 13);
            this.lblThumbTargetTitle.TabIndex = 9;
            this.lblThumbTargetTitle.Text = "Target size (px)";
            // 
            // tbTargetSizeMain
            // 
            this.tbTargetSizeMain.Location = new System.Drawing.Point(294, 88);
            this.tbTargetSizeMain.MaxLength = 5;
            this.tbTargetSizeMain.Name = "tbTargetSizeMain";
            this.tbTargetSizeMain.Size = new System.Drawing.Size(98, 20);
            this.tbTargetSizeMain.TabIndex = 16;
            this.tbTargetSizeMain.Text = "800";
            this.tbTargetSizeMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTargetSizeMain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTargetSizeMain_KeyPress);
            // 
            // lblMainTargetTitle
            // 
            this.lblMainTargetTitle.AutoSize = true;
            this.lblMainTargetTitle.Location = new System.Drawing.Point(211, 91);
            this.lblMainTargetTitle.Name = "lblMainTargetTitle";
            this.lblMainTargetTitle.Size = new System.Drawing.Size(79, 13);
            this.lblMainTargetTitle.TabIndex = 15;
            this.lblMainTargetTitle.Text = "Target size (px)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 120);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 44);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblMainDestTitle
            // 
            this.lblMainDestTitle.AutoSize = true;
            this.lblMainDestTitle.Location = new System.Drawing.Point(212, 39);
            this.lblMainDestTitle.Name = "lblMainDestTitle";
            this.lblMainDestTitle.Size = new System.Drawing.Size(123, 13);
            this.lblMainDestTitle.TabIndex = 15;
            this.lblMainDestTitle.Text = "Select destination folder:";
            // 
            // lblThumbDestTitle
            // 
            this.lblThumbDestTitle.AutoSize = true;
            this.lblThumbDestTitle.Location = new System.Drawing.Point(13, 39);
            this.lblThumbDestTitle.Name = "lblThumbDestTitle";
            this.lblThumbDestTitle.Size = new System.Drawing.Size(123, 13);
            this.lblThumbDestTitle.TabIndex = 15;
            this.lblThumbDestTitle.Text = "Select destination folder:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(207, 124);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(73, 13);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "Image Count :";
            // 
            // lblProcessed
            // 
            this.lblProcessed.AutoSize = true;
            this.lblProcessed.Location = new System.Drawing.Point(207, 147);
            this.lblProcessed.Name = "lblProcessed";
            this.lblProcessed.Size = new System.Drawing.Size(109, 13);
            this.lblProcessed.TabIndex = 17;
            this.lblProcessed.Text = "Images Processed : 0";
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 167);
            this.Controls.Add(this.lblProcessed);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.tbTargetSizeMain);
            this.Controls.Add(this.lblThumbDestTitle);
            this.Controls.Add(this.lblMainDestTitle);
            this.Controls.Add(this.lblMainTargetTitle);
            this.Controls.Add(this.tbTargetSizeThumb);
            this.Controls.Add(this.btnGetMainDestination);
            this.Controls.Add(this.tbDestinationMain);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnGetThumbDestination);
            this.Controls.Add(this.tbDestinationThumb);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lblThumbTargetTitle);
            this.Controls.Add(this.lblThumbTitle);
            this.Controls.Add(this.lblDecPanel1);
            this.Controls.Add(this.lblDecPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Define Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecPanel2;
        private System.Windows.Forms.Label lblDecPanel1;
        private System.Windows.Forms.Label lblThumbTitle;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.TextBox tbDestinationThumb;
        private System.Windows.Forms.Button btnGetThumbDestination;
        private System.Windows.Forms.Button btnGetMainDestination;
        private System.Windows.Forms.TextBox tbDestinationMain;
        private System.Windows.Forms.TextBox tbTargetSizeThumb;
        private System.Windows.Forms.Label lblThumbTargetTitle;
        private System.Windows.Forms.TextBox tbTargetSizeMain;
        private System.Windows.Forms.Label lblMainTargetTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMainDestTitle;
        private System.Windows.Forms.Label lblThumbDestTitle;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblProcessed;
    }

    
}