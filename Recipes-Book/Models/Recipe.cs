using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Recipes_Book.Models
{
    internal class Recipe
    {
        private int idClient;
        private int id;
        private string name;
        private string ingredients;
        private int cookingTime;
        private string steps;
        private string tag;
        private string image;
        private int rating;

        public Recipe(int idClient,int id, string name, string ingredients, int cookTime, string steps, string tag, string image, int rating) { 
        
            this.idClient = idClient;
            this.id = id;
            this.name = name;
            this.ingredients = ingredients;
            this.cookingTime = cookTime;
            this.steps = steps;
            this.tag = tag;
            this.image= image;
            this.rating = rating; 

        }

        public int getIdClient()
        {
            return idClient;
        }

        public int getId() { 
                return id; }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getIngredients()
        {
            return ingredients;
        }

        public void setIngredients(string ingredients)
        {
            this.ingredients= ingredients;
        }

        public int getCookintTime()
        {
            return cookingTime;
        }

        public void setCookingTime(int cookingTime)
        {
            this.cookingTime= cookingTime;
        }

        public string getSteps()
        {
            return steps;
        }

        public void setSteps(string steps)
        {
            this.steps = steps;
        }

        public string getTag() { 
          return tag;
        }

        public void setTag(string tag)
        {
            this.tag = tag;
        }

        public string getImage()
        {
            return image;
        }

        public void setImage(string image)
        {
            this.image = image;
        }

        public int getRating()
        {
            return rating;
        }



    }
}
