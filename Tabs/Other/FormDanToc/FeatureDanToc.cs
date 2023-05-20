using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.Tabs.Other.FormDanToc
{
    public partial class FeatureDanToc : Form
    {
        public FeatureDanToc()
        {
            InitializeComponent();
        }

        private void ptbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
