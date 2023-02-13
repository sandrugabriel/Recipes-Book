using Recipes_Book.Controllers;
using Recipes_Book.Models;
using Recipes_Book.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes_Book
{
    public partial class Form1 : Form
    {
        private int id;

        ControllerClients controllerClients;
        ControllerRecipes controllerRecipes;
        List<Recipe> recipes;
        public Form1(int id1)
        {
            InitializeComponent();
            id = id1;
            controllerClients= new ControllerClients();
            controllerRecipes = new ControllerRecipes();
            controllerClients.load();
            string name = controllerClients.numeById(id);

            label2.Text = controllerClients.numeById(id);

            recipes = new List<Recipe>();
            controllerRecipes.getRecipes(recipes);

            this.Controls.Add(new pnlCards(id,recipes,this));
            this.button3.Visible = false;
        }

        public void removepnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            recipes.Clear();
            controllerRecipes.getRecipes(recipes);

            this.Controls.Add(new pnlCards(id,recipes,this));
            this.removepnl("pnlAddRecipe");
            this.removepnl("pnlMyRecipes");
            this.button5.Visible = true;
            this.button3.Visible = false; 
            this.button4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new pnlAddRecipes(id,this));
            this.removepnl("pnlCards");
            this.removepnl("pnlMyRecipes");
            this.button5.Visible = false;
            this.button3.Visible = true;
            this.button4.Visible = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            recipes.Clear();
            this.button4.Visible = false;
            this.button3.Visible = true;
            this.button5.Visible = true;
            this.removepnl("pnlCards");
            this.removepnl("pnlAddRecipe");
            controllerRecipes.getMyRecipes(recipes, id);
            this.Controls.Add(new pnlMyRecipes(id,recipes,this));
        }
    }
}
