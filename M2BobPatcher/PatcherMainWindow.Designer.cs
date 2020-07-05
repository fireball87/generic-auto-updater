﻿namespace M2BobPatcher {
    partial class PatcherMainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatcherMainWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.starter = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loggerDisplay = new System.Windows.Forms.Label();
            this.downloaderDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(588, 12);
            this.progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 194);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(588, 12);
            this.progressBar2.TabIndex = 2;
            // 
            // starter
            // 
            this.starter.Enabled = false;
            this.starter.Location = new System.Drawing.Point(523, 218);
            this.starter.Name = "starter";
            this.starter.Size = new System.Drawing.Size(77, 23);
            this.starter.TabIndex = 3;
            this.starter.Text = "Start M2Bob!";
            this.starter.UseVisualStyleBackColor = true;
            this.starter.Click += new System.EventHandler(this.starter_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 228);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "M2Bob Website";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // loggerDisplay
            // 
            this.loggerDisplay.AutoSize = true;
            this.loggerDisplay.Location = new System.Drawing.Point(9, 143);
            this.loggerDisplay.Name = "loggerDisplay";
            this.loggerDisplay.Size = new System.Drawing.Size(82, 13);
            this.loggerDisplay.TabIndex = 5;
            this.loggerDisplay.Text = "Starting patch...";
            // 
            // downloaderDisplay
            // 
            this.downloaderDisplay.AutoSize = true;
            this.downloaderDisplay.Location = new System.Drawing.Point(9, 178);
            this.downloaderDisplay.Name = "downloaderDisplay";
            this.downloaderDisplay.Size = new System.Drawing.Size(0, 13);
            this.downloaderDisplay.TabIndex = 6;
            // 
            // PatcherMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 253);
            this.Controls.Add(this.downloaderDisplay);
            this.Controls.Add(this.loggerDisplay);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.starter);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatcherMainWindow";
            this.Load += new System.EventHandler(this.loadWindow);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button starter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label loggerDisplay;
        private System.Windows.Forms.Label downloaderDisplay;
    }
}
