
namespace Custom_Error
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rightcombo = new System.Windows.Forms.ComboBox();
            this.centercombo = new System.Windows.Forms.ComboBox();
            this.leftcombo = new System.Windows.Forms.ComboBox();
            this.centerbtnfield = new System.Windows.Forms.TextBox();
            this.rightbtnfield = new System.Windows.Forms.TextBox();
            this.leftbtnfield = new System.Windows.Forms.TextBox();
            this.msgtitlefield = new System.Windows.Forms.TextBox();
            this.msg1field = new System.Windows.Forms.TextBox();
            this.errortype = new System.Windows.Forms.Label();
            this.errortypecombox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(531, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(294, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message Line One: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message Box Title: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Left Button Text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Centered Button Text:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Right Button Text:";
            // 
            // rightcombo
            // 
            this.rightcombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightcombo.FormattingEnabled = true;
            this.rightcombo.Items.AddRange(new object[] {
            "Disabled",
            "Enabled",
            "Hidden"});
            this.rightcombo.Location = new System.Drawing.Point(615, 214);
            this.rightcombo.Name = "rightcombo";
            this.rightcombo.Size = new System.Drawing.Size(121, 24);
            this.rightcombo.Sorted = true;
            this.rightcombo.TabIndex = 8;
            this.rightcombo.Text = "None";
            this.rightcombo.SelectedIndexChanged += new System.EventHandler(this.rightcombo_SelectedIndexChanged);
            // 
            // centercombo
            // 
            this.centercombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centercombo.FormattingEnabled = true;
            this.centercombo.Items.AddRange(new object[] {
            "Disabled",
            "Enabled",
            "Hidden"});
            this.centercombo.Location = new System.Drawing.Point(615, 259);
            this.centercombo.Name = "centercombo";
            this.centercombo.Size = new System.Drawing.Size(121, 24);
            this.centercombo.Sorted = true;
            this.centercombo.TabIndex = 9;
            this.centercombo.Text = "None";
            this.centercombo.SelectedIndexChanged += new System.EventHandler(this.centercombo_SelectedIndexChanged);
            // 
            // leftcombo
            // 
            this.leftcombo.AllowDrop = true;
            this.leftcombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftcombo.Items.AddRange(new object[] {
            "Disabled",
            "Enabled",
            "Hidden"});
            this.leftcombo.Location = new System.Drawing.Point(615, 170);
            this.leftcombo.Name = "leftcombo";
            this.leftcombo.Size = new System.Drawing.Size(121, 24);
            this.leftcombo.Sorted = true;
            this.leftcombo.TabIndex = 10;
            this.leftcombo.Text = "None";
            this.leftcombo.SelectedIndexChanged += new System.EventHandler(this.leftcombo_SelectedIndexChanged);
            // 
            // centerbtnfield
            // 
            this.centerbtnfield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centerbtnfield.Location = new System.Drawing.Point(354, 261);
            this.centerbtnfield.Name = "centerbtnfield";
            this.centerbtnfield.Size = new System.Drawing.Size(192, 22);
            this.centerbtnfield.TabIndex = 11;
            this.centerbtnfield.TextChanged += new System.EventHandler(this.centerbtnfield_TextChanged);
            // 
            // rightbtnfield
            // 
            this.rightbtnfield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightbtnfield.Location = new System.Drawing.Point(354, 216);
            this.rightbtnfield.Name = "rightbtnfield";
            this.rightbtnfield.Size = new System.Drawing.Size(192, 22);
            this.rightbtnfield.TabIndex = 12;
            this.rightbtnfield.TextChanged += new System.EventHandler(this.rightbtnfield_TextChanged);
            // 
            // leftbtnfield
            // 
            this.leftbtnfield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftbtnfield.Location = new System.Drawing.Point(354, 170);
            this.leftbtnfield.Name = "leftbtnfield";
            this.leftbtnfield.Size = new System.Drawing.Size(192, 22);
            this.leftbtnfield.TabIndex = 13;
            this.leftbtnfield.TextChanged += new System.EventHandler(this.leftbtnfield_TextChanged);
            // 
            // msgtitlefield
            // 
            this.msgtitlefield.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgtitlefield.Location = new System.Drawing.Point(221, 102);
            this.msgtitlefield.Name = "msgtitlefield";
            this.msgtitlefield.Size = new System.Drawing.Size(515, 22);
            this.msgtitlefield.TabIndex = 14;
            this.msgtitlefield.TextChanged += new System.EventHandler(this.msgtitlefield_TextChanged);
            // 
            // msg1field
            // 
            this.msg1field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msg1field.Location = new System.Drawing.Point(221, 33);
            this.msg1field.Name = "msg1field";
            this.msg1field.Size = new System.Drawing.Size(515, 22);
            this.msg1field.TabIndex = 16;
            this.msg1field.TextChanged += new System.EventHandler(this.msg1field_TextChanged);
            // 
            // errortype
            // 
            this.errortype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errortype.AutoSize = true;
            this.errortype.Location = new System.Drawing.Point(544, 318);
            this.errortype.Name = "errortype";
            this.errortype.Size = new System.Drawing.Size(49, 17);
            this.errortype.TabIndex = 17;
            this.errortype.Text = "ICON: ";
            // 
            // errortypecombox
            // 
            this.errortypecombox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errortypecombox.FormattingEnabled = true;
            this.errortypecombox.Items.AddRange(new object[] {
            "Error",
            "Warning",
            "Confirmation",
            "Information"});
            this.errortypecombox.Location = new System.Drawing.Point(615, 311);
            this.errortypecombox.Name = "errortypecombox";
            this.errortypecombox.Size = new System.Drawing.Size(121, 24);
            this.errortypecombox.TabIndex = 18;
            this.errortypecombox.Text = "None";
            this.errortypecombox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errortypecombox);
            this.Controls.Add(this.errortype);
            this.Controls.Add(this.msg1field);
            this.Controls.Add(this.msgtitlefield);
            this.Controls.Add(this.leftbtnfield);
            this.Controls.Add(this.rightbtnfield);
            this.Controls.Add(this.centerbtnfield);
            this.Controls.Add(this.leftcombo);
            this.Controls.Add(this.centercombo);
            this.Controls.Add(this.rightcombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Error Message Customizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.ComboBox rightcombo;
        protected System.Windows.Forms.ComboBox centercombo;
        protected System.Windows.Forms.ComboBox leftcombo;
        protected System.Windows.Forms.TextBox centerbtnfield;
        protected System.Windows.Forms.TextBox rightbtnfield;
        protected System.Windows.Forms.TextBox leftbtnfield;
        protected System.Windows.Forms.TextBox msgtitlefield;
        protected System.Windows.Forms.TextBox msg1field;
        private System.Windows.Forms.Label errortype;
        protected System.Windows.Forms.ComboBox errortypecombox;
    }
}

