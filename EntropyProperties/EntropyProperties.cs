using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntropyProperties
{
    public partial class EntropyProperties : Form
    {
        public EntropyProperties()
        {
            InitializeComponent();
        }

        private void EntropyProperties_Load(object sender, EventArgs e)
        {
            EntropyPropertiesDefinition properties = new EntropyPropertiesDefinition();
        }

        private void btnMutualProb_Click(object sender, EventArgs e)
        {

        }

        private void btnCondProbAB_Click(object sender, EventArgs e)
        {

        }

        private void btnCondProbBA_Click(object sender, EventArgs e)
        {

        }

        
    }
}
