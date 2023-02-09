using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Book.Models
{
    internal class Client
    {

        private int id;
        private string name;
        private string password;
        private string recipes;

        public Client(int id, string name, string password, string recipes)
        {

            this.id = id;
            this.name = name;
            this.password = password;
            this.recipes = recipes;

        }

        public int getId() { 
            return id; }

        public string getName()
        {
            return name;
        }

        public string getPassword()
        {
            return password;
        }

        public string getRecipes()
        {
           return recipes;
        }

    }
}
