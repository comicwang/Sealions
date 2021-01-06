using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace package.builder
{
    public partial class IISPackageControl : UserControl
    {
        private string _pakId = string.Empty;

        public IISPackageControl()
        {
            InitializeComponent();
        }

        public IISPackageControl(string pakId) : this()
        {
            _pakId = pakId;
        }
    }
}
