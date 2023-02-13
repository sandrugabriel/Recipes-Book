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

        public void getRecipes(List<Recipe> recipes1)
        {

            for (int i = 0; i < recipes.Count; i++)
            {

                Recipe a = recipes[i];
                recipes1.Add(a);
            }


        }

        public void getMyRecipes(List<Recipe> recipes1, int idClient)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getIdClient() == idClient)
                {

                Recipe a = recipes[i];
                recipes1.Add(a);
                }

            }


        }

        public Recipe getRecipeById(int id)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    return recipes[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getRecipeById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/recipes.txt";
            File.AppendAllText(path, text + "\n");


        }

        public string nameById(int id)
        {

            for(int i=0;i<recipes.Count;i++)
            {
                if (recipes[i].getId() == id)
                {
                    return (recipes[i].getName());
                }
            }

            return null;
        }

        public string ingredientsById(int id)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    return (recipes[i].getIngredients());
                }
            }

            return null;
        }

        public string stepsById(int id)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    return recipes[i].getSteps();
                }
            }

            return null;
        }

        public string tagById(int id)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    return recipes[i].getTag();
                }
            }

            return null;
        }


        public int timeById(int id)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    return recipes[i].getCookintTime();
                }
            }

            return -1;
        }

        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < recipes.Count; i++)
            {
                t += recipes[i].toSave() + "\n";
            }

            return t;
        }

        public void save()
        {
            String path = Application.StartupPath + @"/data/recipes.txt";
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(this.toSaveFisier());

            streamWriter.Close();
        }

        public void setNume(int id, string nume)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    recipes[i].setName(nume);
                }
            }


        }

        public void setIngredients(int id, string ingr)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    recipes[i].setIngredients(ingr);
                }
            }


        }

        public void setsteps(int id, string steps)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    recipes[i].setSteps(steps);
                }
            }


        }

        public void settag(int id, string tag)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    recipes[i].setTag(tag);
                }
            }


        }

        public void settime(int id, int time)
        {

            for (int i = 0; i < recipes.Count; i++)
            {
                if (recipes[i].getId() == id)
                {
                    recipes[i].setCookingTime(time);
                }
            }


        }


    }
}
