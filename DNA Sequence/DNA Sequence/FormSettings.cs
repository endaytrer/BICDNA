using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNA_Sequence
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            Common f = new Common();
            MessageBox.Show(f.threel.ToString() + f.sep.ToString());
            if(f.threel)
            {
                radioButtonT.Checked = true;
                radioButtonS.Checked = false;
            }
            else
            {
                radioButtonT.Checked = false;
                radioButtonS.Checked = true;
            }
            if (f.sep)
            {
                checkBoxBar.Checked = true;
            }
            else
            {
                checkBoxBar.Checked = false;
            }
        }
    }
}
