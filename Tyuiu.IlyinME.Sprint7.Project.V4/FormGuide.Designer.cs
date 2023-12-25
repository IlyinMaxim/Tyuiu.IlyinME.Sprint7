
namespace Tyuiu.IlyinME.Sprint7.Project.V4
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.pictureBoxGuide_IME = new System.Windows.Forms.PictureBox();
            this.textBoxInstructions_IME = new System.Windows.Forms.TextBox();
            this.buttonOK_IME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide_IME)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGuide_IME
            // 
            this.pictureBoxGuide_IME.Image = global::Tyuiu.IlyinME.Sprint7.Project.V4.Properties.Resources.instructions;
            this.pictureBoxGuide_IME.Location = new System.Drawing.Point(12, 21);
            this.pictureBoxGuide_IME.Name = "pictureBoxGuide_IME";
            this.pictureBoxGuide_IME.Size = new System.Drawing.Size(286, 332);
            this.pictureBoxGuide_IME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuide_IME.TabIndex = 0;
            this.pictureBoxGuide_IME.TabStop = false;
            // 
            // textBoxInstructions_IME
            // 
            this.textBoxInstructions_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInstructions_IME.Location = new System.Drawing.Point(334, 21);
            this.textBoxInstructions_IME.Multiline = true;
            this.textBoxInstructions_IME.Name = "textBoxInstructions_IME";
            this.textBoxInstructions_IME.ReadOnly = true;
            this.textBoxInstructions_IME.Size = new System.Drawing.Size(486, 332);
            this.textBoxInstructions_IME.TabIndex = 1;
            this.textBoxInstructions_IME.Text = resources.GetString("textBoxInstructions_IME.Text");
            // 
            // buttonOK_IME
            // 
            this.buttonOK_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK_IME.Location = new System.Drawing.Point(706, 395);
            this.buttonOK_IME.Name = "buttonOK_IME";
            this.buttonOK_IME.Size = new System.Drawing.Size(114, 35);
            this.buttonOK_IME.TabIndex = 2;
            this.buttonOK_IME.Text = "Ок";
            this.buttonOK_IME.UseVisualStyleBackColor = true;
            this.buttonOK_IME.Click += new System.EventHandler(this.buttonOK_IME_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 442);
            this.Controls.Add(this.buttonOK_IME);
            this.Controls.Add(this.textBoxInstructions_IME);
            this.Controls.Add(this.pictureBoxGuide_IME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuide_IME)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGuide_IME;
        private System.Windows.Forms.TextBox textBoxInstructions_IME;
        private System.Windows.Forms.Button buttonOK_IME;
    }
}