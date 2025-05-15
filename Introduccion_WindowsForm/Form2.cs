using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduccion_WindowsForm
{
    public partial class Form2 : Form
    {
        private string _message;
        public Form2(string message)
        {
            _message = message;
            InitializeComponent();
            txtShow.Text = _message;
        }

      
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
