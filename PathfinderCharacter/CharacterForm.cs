using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathfinderCharacter
{
    public partial class Character : Form
    {
        public Character()
        {
            InitializeComponent();
            comboRace.DataSource = Enum.GetValues(typeof(PathfinderRace));
        }
    }
}
