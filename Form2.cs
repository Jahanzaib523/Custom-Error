using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Custom_Error
{
    public partial class Form2 : Form
    {
        public static string icontype = "", left_combox_msg = "", right_combo_msg = "", centered_combo_msg = "";
        public int MAX_LINES = 2;
        public int centerbtn_height = 0, centerbtn_width = 0, 
            rightbtn_height = 0, rightbtn_width = 0, 
            leftbtn_height = 0, leftbtn_width = 0;
        public bool sizing = false;

        public Form2()
        {
            InitializeComponent();
            this.MinimumSize = new Size(550, 240);
            this.MaximumSize = new Size(1000, 240);
            //MakeButtonsHide();
        }


        private void Form2_Load(object sender, EventArgs e)
        { 
            SoundPlayer audio = new SoundPlayer("C:\\Users\\Jahanzaib Manzoor\\source\\repos\\Custom Error\\Images\\Windows.wav"); 
            audio.Play();

            this.Text = Form1.title;
            errormsg.Text = Form1.msg1;
            icontype = Form1.errortypetext;
            leftbtnform2.Text = Form1.leftbtn;
            rightbtnform2.Text = Form1.rightbtn;
            centerbtnform2.Text = Form1.centerbtn;

            left_combox_msg = Form1.leftcombotext;
            right_combo_msg = Form1.rightcombotext;
            centered_combo_msg = Form1.centercombotext;

            centerbtn_height = centerbtnform2.Location.Y;
            centerbtn_width = centerbtnform2.Location.X;

            rightbtn_height = rightbtnform2.Location.Y;
            rightbtn_width = rightbtnform2.Location.X;

            leftbtn_height = leftbtnform2.Location.Y;
            leftbtn_height = leftbtnform2.Location.X;

            Check_SetIcon(icontype);
            label3_Paint();
            PlaceButtons(left_combox_msg, right_combo_msg, centered_combo_msg);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void Check_SetIcon(string icon)
        {
            if(icon == "Error")
            {
                //imagename.Image = Image.FromFile("../Custom Error/Images/Error-Icon.png");
                imagename.Image = Properties.Resources.Error_Icon;
            }
            else if(icon == "Warning")
            {
                //imagename.Image = Image.FromFile("../Custom Error/Images/Warning-Icon.png");
                imagename.Image = Properties.Resources.Warning_Icon;
            }
            else if(icon == "Confirmation")
            {
                //imagename.Image = Image.FromFile("C:\\Users\\Jahanzaib Manzoor\\source\\repos\\Custom Error\\Images\\Confirmation-Icon.png");
                imagename.Image = Properties.Resources.Confirmation_Icon;
            }
            else if(icon == "Information")
            {
                //imagename.Image = Image.FromFile("../Custom Error/Images/Information-Icon.png");
                imagename.Image = Properties.Resources.Information_Icon;
            }
        }

        private void icon_Click(object sender, EventArgs e)
        {

        }

        public void MakeButtonsHide()
        {
            leftbtnform2.Visible = false;
            centerbtnform2.Visible = false;
        }

        public void PlaceButtons(string leftbtn_msg, string rightbtn_msg, string centeredbtn_msg)
        {
            if(rightbtn_msg == "Hidden")
            {
                int temp_height = rightbtn_height;
                int temp_width = rightbtn_width;

                int temp2_height = centerbtn_height;
                int temp2_width = centerbtn_width;

                centerbtnform2 = ChangeButtonLocation(centerbtnform2, temp_height, temp_width);
                leftbtnform2 = ChangeButtonLocation(leftbtnform2, temp2_height, temp2_width);

                rightbtnform2.Visible = false;
            }
            
            if(centeredbtn_msg == "Hidden")
            {
                int temp_height = centerbtn_height;
                int temp_width = centerbtn_width;

                leftbtnform2 = ChangeButtonLocation(leftbtnform2, temp_height, temp_width);

                centerbtnform2.Visible = false;
            }
            
            if(leftbtn_msg == "Hidden")
            {
                leftbtnform2.Visible = false;
            }

            if(rightbtn_msg == "Hidden" && centeredbtn_msg == "Hidden")
            {
                int temp_height = rightbtn_height;
                int temp_width = rightbtn_width;

                leftbtnform2 = ChangeButtonLocation(leftbtnform2, temp_height, temp_width);

                rightbtnform2.Visible = false;
                centerbtnform2.Visible = false;
            }

            if(rightbtn_msg == "Hidden"  && leftbtn_msg == "Hidden")
            {
                int temp_height = rightbtn_height;
                int temp_width = rightbtn_width;

                centerbtnform2 = ChangeButtonLocation(centerbtnform2, temp_height, temp_width);

                rightbtnform2.Visible = false;
                leftbtnform2.Visible = false;
            }

            if(rightbtn_msg == "Disabled")
            {
                rightbtnform2.Enabled = false;
            }

            if(leftbtn_msg == "Disabled")
            {
                leftbtnform2.Enabled = false;
            }

            if(centeredbtn_msg == "Disabled")
            {
                centerbtnform2.Enabled = false;
            }
        }

        
        private void label3_Paint()
        {

            Size sz = TextRenderer.MeasureText(errormsg.Text, errormsg.Font, errormsg.Size, TextFormatFlags.WordBreak);

            if (sz.Width > errormsg.Size.Width || sz.Height > errormsg.Size.Height)
            {

                DecreaseFontSize(errormsg);
            }
        }

        public void DecreaseFontSize(Label lbl)
        {

            lbl.Font = new System.Drawing.Font(lbl.Font.Name, lbl.Font.Size - 1, lbl.Font.Style);

        }

        public  Button ChangeButtonLocation(Button btn, int height, int width)
        {
            btn.Location = new Point(width, height);
            return btn;
        }
    }
}
