using Recipes_Book.Controllers;
using Recipes_Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes_Book.Panels
{
    internal class pnlMyRecipes:Panel
    {

        List<Recipe> recipes = new List<Recipe>();

        Label lblInfo;

        Form1 form;

        private int idClient;

        ControllerRecipes controllerRecipes;

        public pnlMyRecipes(int idClient1,List<Recipe> recipe1, Form1 form1)
        {
            idClient= idClient1;
            controllerRecipes = new ControllerRecipes();

            this.Name = "pnlMyRecipes";
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Size = new System.Drawing.Size(765, 412);
            this.Location = new System.Drawing.Point(5, 82);
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;

            recipes = recipe1;

            createCard(3);


            //Info
            this.lblInfo = new Label();
            this.Controls.Add(this.lblInfo);

            this.lblInfo.Text = "To change the data and delete a client, click on card";
            this.lblInfo.BackColor = System.Drawing.Color.Yellow;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10);

            this.form = form1;

            controllerRecipes.load();

        }
        public void createCard(int nrCollums)
        {

            this.Controls.Clear();

            int x = 53, y = 43, ct = 0;

            foreach (Recipe recipe in recipes)
            {
                ct++;
                pnlCard pnlcard = new pnlCard(recipe, form);
                pnlcard.Location = new System.Drawing.Point(x, y);
                this.Controls.Add(pnlcard);
                pnlcard.Click += new EventHandler(pnlcard_Click);
                void pnlcard_Click(object sender, EventArgs e)
                {
                    string title = pnlcard.lblTitle1.Text;
                    int id = controllerRecipes.idByNume(title);
                    this.form.removepnl("pnlMyRecipes");
                    this.form.Controls.Add(new pnlUpdate(idClient, id, form));
                }
                x += 200;

                if (ct % nrCollums == 0)
                {
                    x = 55;
                    y += 210;
                }
                if (y > this.Height)
                {
                    this.AutoScroll = true;
                }
            }


        }









    }
}
