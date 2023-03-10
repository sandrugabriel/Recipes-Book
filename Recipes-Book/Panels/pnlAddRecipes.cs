using Recipes_Book.Controllers;
using Recipes_Book.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Recipes_Book.Panels
{
    internal class pnlAddRecipes:Panel
    {

        Label lblName;
        TextBox txtName;

        Label lblIngredients;
        TextBox txtIngredients;

        Label lblTags;
        RadioButton radDinner;
        RadioButton radBreakfast;
        RadioButton radLunch;
        RadioButton radSweet;

        Label lblTime;
        NumericUpDown numericTime;

        Label lblSteps;
        RichTextBox txtSteps;

        Button btnSave;

        Form1 form;

        ControllerRecipes controllerRecipes;

        Button btnAddImage;

        PictureBox pictureBox;

        private int idClient;

        List<string> erori;

        public pnlAddRecipes(int idClient1,Form1 form1)
        {
            controllerRecipes = new ControllerRecipes();
            form = form1;
            idClient = idClient1;
            erori = new List<string>();
            this.Name = "pnlAddRecipe";
            this.Size = new System.Drawing.Size(785, 475);
            this.Location = new System.Drawing.Point(6, 82);
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;

            Font font = new Font("Microsoft YaHei UI Light", 20);
            Font font1 = new Font("Microsoft YaHei UI Light", 14);

            //Name
            lblName = new Label();
            txtName= new TextBox();
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.lblName.Text = "Name";
            this.lblName.Font = font;
            this.lblName.Location = new System.Drawing.Point(58, 55);
            this.lblName.AutoSize = true;
            this.txtName.Font = font1;
            this.txtName.Size = new System.Drawing.Size(198, 34);
            this.txtName.Location = new System.Drawing.Point(58, 100);



            //Ingredients
            lblIngredients = new Label();
            txtIngredients= new TextBox();
            this.Controls.Add(lblIngredients);
            this.Controls.Add(txtIngredients);
            this.lblIngredients.Text = "Ingredients";
            this.lblIngredients.Font = font;
            this.lblIngredients.Location = new System.Drawing.Point(359, 85);
            this.lblIngredients.AutoSize = true;
            this.txtIngredients.Font = font1;
            this.txtIngredients.Size = new System.Drawing.Size(198, 34);
            this.txtIngredients.Location = new System.Drawing.Point(359, 130);

            //Tags
            lblTags = new Label();
            radBreakfast = new System.Windows.Forms.RadioButton();
            radLunch= new System.Windows.Forms.RadioButton();
            radDinner = new System.Windows.Forms.RadioButton();
            radSweet = new System.Windows.Forms.RadioButton();
            this.Controls.Add(lblTags);
            this.Controls.Add(radLunch);
            this.Controls.Add(radDinner);
            this.Controls.Add(radSweet);
            this.Controls.Add(radBreakfast);

            this.lblTags.Font = font;
            this.lblTags.AutoSize = true;
            this.lblTags.Text = "Tags";
            this.lblTags.Location = new System.Drawing.Point(640, 85);
            this.radBreakfast.Name = "radBreakfast";
            this.radLunch.Name = "radLunch";
            this.radDinner.Name = "radDinner";
            this.radSweet.Name = "radSweet";
            this.radBreakfast.Location = new System.Drawing.Point(640,130);
            this.radBreakfast.Font = font1;
            this.radBreakfast.Text = "Breakfast";
            this.radBreakfast.AutoSize = true;
            this.radLunch.Location = new System.Drawing.Point(640, 175);
            this.radLunch.Font = font1;
            this.radLunch.Text = "Lunch";
            this.radLunch.AutoSize = true;
            this.radDinner.Location = new System.Drawing.Point(640, 220);
            this.radDinner.Font = font1;
            this.radDinner.Text = "Dinner";
            this.radDinner.AutoSize = true;
            this.radSweet.Location = new System.Drawing.Point(640, 265);
            this.radSweet.Font = font1;
            this.radSweet.Text = "Sweet";
            this.radSweet.AutoSize = true;

            //Cooking Time
            lblTime = new Label();
            numericTime = new NumericUpDown();
            this.Controls.Add(lblTime);
            this.Controls.Add(numericTime);
            this.lblTime.Text = "Cooking time";
            this.lblTime.Font = font;
            this.lblTime.Location = new System.Drawing.Point(359, 205);
            this.lblTime.AutoSize = true;
            this.numericTime.Font = font1;
            this.numericTime.Maximum = 999999;
            this.numericTime.Size = new System.Drawing.Size(90, 34);
            this.numericTime.Location = new System.Drawing.Point(397, 269);

            //Steps
            lblSteps = new Label();
            txtSteps = new RichTextBox();
            this.Controls.Add(lblSteps);
            this.Controls.Add(txtSteps);
            this.lblSteps.Text = "Steps";
            this.lblSteps.Font = font;
            this.lblSteps.Location = new System.Drawing.Point(64, 290);
            this.lblSteps.AutoSize = true;
            this.txtSteps.Font = font1;
            this.txtSteps.Size = new System.Drawing.Size(573, 140);
            this.txtSteps.Location = new System.Drawing.Point(64, 330);
            this.AutoScroll = true;
            this.txtSteps.AutoSize= true;

            //Save
            btnSave = new System.Windows.Forms.Button();
            this.Controls.Add(btnSave);
            this.btnSave.Location = new System.Drawing.Point(650, 360);
            this.btnSave.Text = "Save";
            this.btnSave.Font = font;
            this.btnSave.Size = new System.Drawing.Size(110, 55);
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Click += new EventHandler(btnSave_Click);

            //AddImage
            btnAddImage = new Button();
            this.Controls.Add(btnAddImage);
            this.btnAddImage.Location = new System.Drawing.Point(110, 230);
            this.btnAddImage.Text = "Upload";
            this.btnAddImage.Font = new Font("Microsoft YaHei UI Light", 10);
            this.btnAddImage.Size = new System.Drawing.Size(90, 50);
            this.btnAddImage.Click += new EventHandler(btnAddImage_Click);
            pictureBox = new PictureBox();
            this.Controls.Add(pictureBox);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.Location = new System.Drawing.Point(70,150);
            this.pictureBox.Size = new System.Drawing.Size(170,75);
            this.pictureBox.BackColor = System.Drawing.Color.White;
            

            this.form.button5.Visible = true;
        }

        private string uploadImage;

        private void btnAddImage_Click(object sender, EventArgs e)
        {

           OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.ShowDialog();

            string image = openFileDialog.FileName;

            this.pictureBox.Image = Image.FromFile(image);


            string[] imag = image.Split('\\');

            uploadImage = imag[imag.Length-1];


        }

        public string radioBtnActiv()
        {
            if(radBreakfast.Checked == true)
            {
                return radBreakfast.Text;
            }
            else if (radLunch.Checked == true)
            {
                return radLunch.Text;
            }
            else if (radDinner.Checked == true)
            {
                return radDinner.Text;
            }
            else if (radSweet.Checked == true)
            {
                return radSweet.Text;
            }

            return null;
        }

        private void errors()
        {

            erori.Clear();

            if (txtName.Text.Equals(""))
            {
                erori.Add("You have not entered the name");
            }

            if (txtIngredients.Text.Equals(""))
            {
                erori.Add("You have not entered the ingredients");
            }

            if (txtSteps.Text.Equals(""))
            {
                txtSteps.Focus();
                erori.Add("You have not entered the steps");

            }

            if (numericTime.Value == 0)
            {
                txtSteps.Focus();
                erori.Add("You have not entered the time");

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            errors();

            if (erori.Count > 0)
            {
                for (int i = 0; i < erori.Count; i++)
                {
                    MessageBox.Show(erori[i], "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {


                this.form.button5.Visible = true;

                int id = controllerRecipes.generareId();
                string name = txtName.Text;
                string ingredients = txtIngredients.Text;
                int time = ((int)numericTime.Value);
                string steps = txtSteps.Text;
                string tag = radioBtnActiv();
                string image = uploadImage;

                string textul = idClient.ToString() + ";" + id.ToString() + ";" + name + ";" + ingredients + ";" + time.ToString() + ";" + steps + ";" + tag + ";" + image;

                controllerRecipes.save(textul);
                controllerRecipes.load();
                List<Recipe> recipes = new List<Recipe>();
                controllerRecipes.getRecipes(recipes);
                this.form.Controls.Add(new pnlCards(idClient ,recipes,form));
                this.form.removepnl("pnlAddRecipe");

            }

        }

    }
}
