﻿
namespace Tyuiu.IlyinME.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_IME = new System.Windows.Forms.PictureBox();
            this.labelInfo_IME = new System.Windows.Forms.Label();
            this.buttonOK_IME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_IME)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_IME
            // 
            this.pictureBoxAvatar_IME.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_IME.Image")));
            this.pictureBoxAvatar_IME.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar_IME.Name = "pictureBoxAvatar_IME";
            this.pictureBoxAvatar_IME.Size = new System.Drawing.Size(282, 279);
            this.pictureBoxAvatar_IME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_IME.TabIndex = 0;
            this.pictureBoxAvatar_IME.TabStop = false;
            // 
            // labelInfo_IME
            // 
            this.labelInfo_IME.AutoSize = true;
            this.labelInfo_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_IME.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelInfo_IME.Location = new System.Drawing.Point(316, 13);
            this.labelInfo_IME.Name = "labelInfo_IME";
            this.labelInfo_IME.Size = new System.Drawing.Size(384, 180);
            this.labelInfo_IME.TabIndex = 1;
            this.labelInfo_IME.Text = resources.GetString("labelInfo_IME.Text");
            // 
            // buttonOK_IME
            // 
            this.buttonOK_IME.BackColor = System.Drawing.Color.Cyan;
            this.buttonOK_IME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK_IME.Location = new System.Drawing.Point(626, 261);
            this.buttonOK_IME.Name = "buttonOK_IME";
            this.buttonOK_IME.Size = new System.Drawing.Size(88, 31);
            this.buttonOK_IME.TabIndex = 2;
            this.buttonOK_IME.Text = "Ок";
            this.buttonOK_IME.UseVisualStyleBackColor = false;
            this.buttonOK_IME.Click += new System.EventHandler(this.buttonOK_IME_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 304);
            this.Controls.Add(this.buttonOK_IME);
            this.Controls.Add(this.labelInfo_IME);
            this.Controls.Add(this.pictureBoxAvatar_IME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_IME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_IME;
        private System.Windows.Forms.Label labelInfo_IME;
        private System.Windows.Forms.Button buttonOK_IME;
    }
}