using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipes_Book.Mockups
{
    public partial class Mockup_AddRecipe : Form
    {
        public Mockup_AddRecipe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            openFileDialog.ShowDialog();

            MessageBox.Show(openFileDialog.FileName);
        }
    }
}
