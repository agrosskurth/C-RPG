using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperAdventure.Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player p1;

        public SuperAdventure()
        {
            InitializeComponent();
            p1 = new Player(10, 10, 20, 0, 1);

            Location loc = new Location(1, "Home", "This is your home.");
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }
    }
}
