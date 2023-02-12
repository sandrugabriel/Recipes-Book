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
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();

            this.Controls.Add(new pnlStart(this));

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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
