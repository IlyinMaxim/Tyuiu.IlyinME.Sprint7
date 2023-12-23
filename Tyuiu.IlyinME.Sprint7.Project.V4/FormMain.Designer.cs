
namespace Tyuiu.IlyinME.Sprint7.Project.V4
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenuUp_IME = new System.Windows.Forms.Panel();
            this.buttonClose_IME = new System.Windows.Forms.Button();
            this.panelMenu_IME = new System.Windows.Forms.Panel();
            this.buttonStats_IME = new System.Windows.Forms.Button();
            this.buttonInfo_IME = new System.Windows.Forms.Button();
            this.panelMenuUp_IME.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuUp_IME
            // 
            this.panelMenuUp_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMenuUp_IME.Controls.Add(this.buttonStats_IME);
            this.panelMenuUp_IME.Controls.Add(this.buttonClose_IME);
            this.panelMenuUp_IME.Controls.Add(this.buttonInfo_IME);
            this.panelMenuUp_IME.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuUp_IME.Location = new System.Drawing.Point(0, 0);
            this.panelMenuUp_IME.Name = "panelMenuUp_IME";
            this.panelMenuUp_IME.Size = new System.Drawing.Size(1212, 94);
            this.panelMenuUp_IME.TabIndex = 0;
            this.panelMenuUp_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuUp_IME_MouseDown);
            this.panelMenuUp_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenuUp_IME_MouseMove);
            // 
            // buttonClose_IME
            // 
            this.buttonClose_IME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose_IME.BackColor = System.Drawing.Color.Red;
            this.buttonClose_IME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose_IME.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClose_IME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose_IME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose_IME.ForeColor = System.Drawing.Color.White;
            this.buttonClose_IME.Location = new System.Drawing.Point(1137, 0);
            this.buttonClose_IME.Name = "buttonClose_IME";
            this.buttonClose_IME.Size = new System.Drawing.Size(75, 23);
            this.buttonClose_IME.TabIndex = 1;
            this.buttonClose_IME.Text = "X";
            this.buttonClose_IME.UseVisualStyleBackColor = false;
            this.buttonClose_IME.Click += new System.EventHandler(this.buttonClose_IME_Click);
            // 
            // panelMenu_IME
            // 
            this.panelMenu_IME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu_IME.Location = new System.Drawing.Point(0, 94);
            this.panelMenu_IME.Name = "panelMenu_IME";
            this.panelMenu_IME.Size = new System.Drawing.Size(1212, 563);
            this.panelMenu_IME.TabIndex = 1;
            this.panelMenu_IME.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_IME_MouseDown);
            this.panelMenu_IME.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMenu_IME_MouseMove);
            // 
            // buttonStats_IME
            // 
            this.buttonStats_IME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStats_IME.FlatAppearance.BorderSize = 0;
            this.buttonStats_IME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStats_IME.Image = ((System.Drawing.Image)(resources.GetObject("buttonStats_IME.Image")));
            this.buttonStats_IME.Location = new System.Drawing.Point(66, 21);
            this.buttonStats_IME.Name = "buttonStats_IME";
            this.buttonStats_IME.Size = new System.Drawing.Size(69, 56);
            this.buttonStats_IME.TabIndex = 2;
            this.buttonStats_IME.UseVisualStyleBackColor = true;
            this.buttonStats_IME.Click += new System.EventHandler(this.buttonStats_IME_Click);
            // 
            // buttonInfo_IME
            // 
            this.buttonInfo_IME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonInfo_IME.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_IME.FlatAppearance.BorderSize = 0;
            this.buttonInfo_IME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_IME.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_IME.Image")));
            this.buttonInfo_IME.Location = new System.Drawing.Point(0, 21);
            this.buttonInfo_IME.Name = "buttonInfo_IME";
            this.buttonInfo_IME.Size = new System.Drawing.Size(60, 56);
            this.buttonInfo_IME.TabIndex = 0;
            this.buttonInfo_IME.UseVisualStyleBackColor = false;
            this.buttonInfo_IME.Click += new System.EventHandler(this.buttonInfo_IME_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 657);
            this.Controls.Add(this.panelMenu_IME);
            this.Controls.Add(this.panelMenuUp_IME);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню ";
            this.panelMenuUp_IME.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuUp_IME;
        private System.Windows.Forms.Button buttonInfo_IME;
        private System.Windows.Forms.Button buttonClose_IME;
        private System.Windows.Forms.Panel panelMenu_IME;
        private System.Windows.Forms.Button buttonStats_IME;
    }
}