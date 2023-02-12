using Microsoft.SqlServer.Server;
using Recipes_Book.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes_Book.Controllers
{
    internal class ControllerRecipes
    {

        private List<Recipe> recipes;

        public ControllerRecipes() {

            recipes = new List<Recipe>();

            load();
        
        }

        public void load()
        {
            string path = Application.StartupPath + @"/data/recipes.txt";
            StreamReader streamReader = new StreamReader(path);

            string text;

            while((text = streamReader.ReadLine()) != null)
            {
                Recipe recipe = new Recipe(text);

                recipes.Add(recipe);

            }

            streamReader.Close();
        }



        public int idByNume(string nume)
        {

            for (int i = 0; i < recipes.Count; i++)
            {

                if (recipes[i].getName().Equals(nume))
                {
                    return recipes[i].getId();
                }

            }

            return -1;
        }

        public void getBooks(List<Recipe> books1)
        {

            for (int i = 0; i < recipes.Count; i++)
            {

                Recipe a = recipes[i];
                books1.Add(a);
            }


        }












    }
}
