using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inzendatu_Version1
{
    public partial class ScreenSplash : Form
    {
        public ScreenSplash()
        {
            InitializeComponent();
        }

        private void ScreenSplash_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
        }
    }
}
