
namespace Custom_Error
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errormsg = new System.Windows.Forms.Label();
            this.imagename = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.rightbtnform2 = new System.Windows.Forms.Button();
            this.centerbtnform2 = new System.Windows.Forms.Button();
            this.leftbtnform2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagename)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.errormsg);
            this.panel1.Controls.Add(this.imagename);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 120);
            this.panel1.TabIndex = 0;
            // 
            // errormsg
            // 
            this.errormsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.errormsg.AutoEllipsis = true;
            this.errormsg.AutoSize = true;
            this.errormsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errormsg.Location = new System.Drawing.Point(98, 30);
            this.errormsg.MaximumSize = new System.Drawing.Size(420, 60);
            this.errormsg.Name = "errormsg";
            this.errormsg.Size = new System.Drawing.Size(403, 60);
            this.errormsg.TabIndex = 0;
            this.errormsg.Text = "The program can`t start because vcruntime140.dll is missing from your computer. T" +
    "ry reinstalling the program to fix this problem.";
            this.errormsg.Click += new System.EventHandler(this.Form2_Load);
            // 
            // imagename
            // 
            this.imagename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imagename.ErrorImage = null;
            this.imagename.InitialImage = null;
            this.imagename.Location = new System.Drawing.Point(44, 34);
            this.imagename.Name = "imagename";
            this.imagename.Size = new System.Drawing.Size(46, 41);
            this.imagename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagename.TabIndex = 2;
            this.imagename.TabStop = false;
            this.imagename.Click += new System.EventHandler(this.icon_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 131);
            this.panel2.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // rightbtnform2
            // 
            this.rightbtnform2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightbtnform2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rightbtnform2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.rightbtnform2.FlatAppearance.BorderSize = 2;
            this.rightbtnform2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightbtnform2.ForeColor = System.Drawing.Color.Black;
            this.rightbtnform2.Location = new System.Drawing.Point(263, 8);
            this.rightbtnform2.Name = "rightbtnform2";
            this.rightbtnform2.Size = new System.Drawing.Size(96, 35);
            this.rightbtnform2.TabIndex = 1;
            this.rightbtnform2.Text = "RightBtn";
            this.rightbtnform2.UseVisualStyleBackColor = true;
            this.rightbtnform2.Click += new System.EventHandler(this.button1_Click);
            // 
            // centerbtnform2
            // 
            this.centerbtnform2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.centerbtnform2.FlatAppearance.BorderSize = 2;
            this.centerbtnform2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.centerbtnform2.Location = new System.Drawing.Point(152, 7);
            this.centerbtnform2.Name = "centerbtnform2";
            this.centerbtnform2.Size = new System.Drawing.Size(87, 35);
            this.centerbtnform2.TabIndex = 2;
            this.centerbtnform2.Text = "CenterBtn";
            this.centerbtnform2.UseVisualStyleBackColor = true;
            // 
            // leftbtnform2
            // 
            this.leftbtnform2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftbtnform2.CausesValidation = false;
            this.leftbtnform2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.leftbtnform2.FlatAppearance.BorderSize = 8;
            this.leftbtnform2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.leftbtnform2.Location = new System.Drawing.Point(33, 7);
            this.leftbtnform2.Name = "leftbtnform2";
            this.leftbtnform2.Size = new System.Drawing.Size(93, 35);
            this.leftbtnform2.TabIndex = 3;
            this.leftbtnform2.Text = "LeftBtn";
            this.leftbtnform2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.leftbtnform2);
            this.panel3.Controls.Add(this.rightbtnform2);
            this.panel3.Controls.Add(this.centerbtnform2);
            this.panel3.Location = new System.Drawing.Point(143, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 46);
            this.panel3.TabIndex = 4;
            // 
            // Form2
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(530, 193);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagename)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imagename;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button rightbtnform2;
        private System.Windows.Forms.Button centerbtnform2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button leftbtnform2;
        protected System.Windows.Forms.Label errormsg;
    }
}