using Recipes_Book.Controllers;
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
    internal class pnlView:Panel
    {

        Label lblName;
        TextBox txtName;

        Label lblIngredients;
        RichTextBox txtIngredients;

        Label lblTags;
        RadioButton radDinner;
        RadioButton radBreakfast;
        RadioButton radLunch;
        RadioButton radSweet;

        Label lblTime;
        NumericUpDown numericTime;

        Label lblSteps;
        RichTextBox txtSteps;

        Button btnCancel;

        Form1 form;

        ControllerRecipes controllerRecipes;

        private int id;
        private int idClient;

        List<Recipe> recipes;

        public pnlView(int idClient1, int id1, Form1 form1)
        {
            idClient = idClient1;
            controllerRecipes = new ControllerRecipes();
            form = form1;
            id = id1;
            this.Name = "pnlView";
            this.Size = new System.Drawing.Size(785, 475);
            this.Location = new System.Drawing.Point(6, 82);
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            

            Font font = new Font("Microsoft YaHei UI Light", 20);
            Font font1 = new Font("Microsoft YaHei UI Light", 14);

            //Name
            lblName = new Label();
            txtName = new TextBox();
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.lblName.Text = "Name";
            this.lblName.Font = font;
            this.lblName.Location = new System.Drawing.Point(58, 85);
            this.lblName.AutoSize = true;
            this.txtName.Font = font1;
            this.txtName.Size = new System.Drawing.Size(198, 34);
            this.txtName.Location = new System.Drawing.Point(58, 130);
            this.txtName.ReadOnly = true;


            //Ingredients
            lblIngredients = new Label();
            txtIngredients = new RichTextBox();
            this.Controls.Add(lblIngredients);
            this.Controls.Add(txtIngredients);
            this.lblIngredients.Text = "Ingredients";
            this.lblIngredients.Font = font;
            this.lblIngredients.Location = new System.Drawing.Point(359, 85);
            this.lblIngredients.AutoSize = true;
            this.txtIngredients.Font = font1;
            this.txtIngredients.Size = new System.Drawing.Size(245, 44);
            this.txtIngredients.Location = new System.Drawing.Point(359, 130);
            this.txtIngredients.AutoSize = true;
            this.txtIngredients.ReadOnly = true;

            //Tags
            lblTags = new Label();
            radBreakfast = new System.Windows.Forms.RadioButton();
            radLunch = new System.Windows.Forms.RadioButton();
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
            this.radBreakfast.Location = new System.Drawing.Point(640, 130);
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
            this.numericTime.ReadOnly= true;


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
            this.txtSteps.AutoSize = true;
            this.txtSteps.ReadOnly = true;

            //Cancel
            btnCancel = new System.Windows.Forms.Button();
            this.Controls.Add(btnCancel);
            this.btnCancel.Location = new System.Drawing.Point(650, 360);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Font = font;
            this.btnCancel.Size = new System.Drawing.Size(110, 55);
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Click += new EventHandler(btnCancel_Click);


            this.txtName.Text = controllerRecipes.nameById(id);
            this.txtIngredients.Text = controllerRecipes.ingredientsById(id);
            this.txtSteps.Text = controllerRecipes.stepsById(id);
            this.numericTime.Value = controllerRecipes.timeById(id);
            string radioSel = controllerRecipes.tagById(id);

            recipes = new List<Recipe>();
            controllerRecipes.getRecipes(recipes);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            recipes.Clear();
            controllerRecipes.getRecipes(recipes);


            this.form.removepnl("pnlView");
            this.form.Controls.Add(new pnlCards(idClient, recipes, form));


        }
















    }
}
