using Recipes_Book.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes_Book.Panels
{
    internal class pnlCard:Panel
    {


        Label lblTitle;
        public Label lblTitle1;

       // Label lblInfo;

        Recipe recipe;
        Form1 form;

        PictureBox pictureBox;

        private int id;

        public pnlCard(Recipe recipe1, Form1 form1)
        {
            this.form = form1;
            this.Name = "pnlCard";
            this.Size = new System.Drawing.Size(191, 175);
            this.Location = new System.Drawing.Point(53, 43);
            this.BackColor = System.Drawing.Color.White;

            recipe = recipe1;

            Font font = new Font("Microsoft YaHei UI Light", 13);
            Font font1 = new Font("Microsoft YaHei UI Light", 12);

            //Title
            lblTitle = new Label();
            lblTitle1 = new Label();
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTitle1);
            this.lblTitle.Name = "lbltitle";
            this.lblTitle1.Name = "lblTitle1";

            this.lblTitle.Location = new System.Drawing.Point(21, 13);
            this.lblTitle1.Location = new System.Drawing.Point(21, 42);
            this.lblTitle.AutoSize = true;
            this.lblTitle1.AutoSize = true;
            this.lblTitle.Font = font;
            this.lblTitle1.Font = font1;
            this.lblTitle.Text = "Title";
            this.lblTitle1.Text = recipe.getName();


            id = recipe1.getId();

            //PictureBox
            pictureBox = new PictureBox();
            this.Controls.Add(pictureBox);


            string path = Application.StartupPath + @"\images\" + recipe.getImage();
            this.pictureBox.Image = Image.FromFile(path);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.Location = new System.Drawing.Point(31, 72);

        }

        public int getid()
        {

            return id;

        }


    }
}
