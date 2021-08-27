using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Error
{
    public partial class Form1 : Form
    {
        public static string msg1 = " ", title = " ", 
            leftbtn = " ", rightbtn = " ", centerbtn = " ",
            leftcombotext = "", rightcombotext = "", centercombotext = "", errortypetext = "", icon_ = "";

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(610, 410);
        }

      

        protected void msgtitlefield_TextChanged(object sender, EventArgs e)
        {
            title = msgtitlefield.Text.ToString();
            SetButton();
        }

        protected void leftbtnfield_TextChanged(object sender, EventArgs e)
        {
            leftbtn = leftbtnfield.Text.ToString();
            SetButton();
        }

        protected void rightbtnfield_TextChanged(object sender, EventArgs e)
        {
            rightbtn = rightbtnfield.Text.ToString();
            SetButton();
        }

        protected void leftcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButton();
            leftcombotext = leftcombo.GetItemText(leftcombo.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButton();
            errortypetext = errortypecombox.GetItemText(errortypecombox.SelectedItem);
        }

        protected void centerbtnfield_TextChanged(object sender, EventArgs e)
        {
            centerbtn = centerbtnfield.Text.ToString();
            SetButton();
        }

        private void rightcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButton();
            rightcombotext = rightcombo.GetItemText(rightcombo.SelectedItem);
        }

        private void centercombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButton();
            centercombotext = centercombo.GetItemText(centercombo.SelectedItem);
        }

        protected void msg1field_TextChanged(object sender, EventArgs e)
        {
            msg1 = msg1field.Text.ToString();
            SetButton();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            msg1field.Text = "";
            msgtitlefield.Text = "";
            leftbtnfield.Text = "";
            rightbtnfield.Text = "";
            centerbtnfield.Text = "";
            leftcombo.Text = "None";
            rightcombo.Text = "None";
            centercombo.Text = "None";
            errortypecombox.Text = "None";
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
         
            form2.ShowDialog();
            this.Close();
        }

        protected void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetButton()
        {
            button2.Enabled = (msg1field.Text != "" || msg1field.Visible == false) &&
                (msgtitlefield.Text != "" || msgtitlefield.Visible == false) &&
                (leftbtnfield.Text != "" || leftbtnfield.Visible == false) &&
                (rightbtnfield.Text != "" || rightbtnfield.Visible == false) &&
                (centerbtnfield.Text != "" || centerbtnfield.Visible == false) &&
                (leftcombo.SelectedIndex > -1) && (rightcombo.SelectedIndex > -1) && 
                (centercombo.SelectedIndex > -1) && (errortypecombox.SelectedIndex > -1);
        }
    }
}
