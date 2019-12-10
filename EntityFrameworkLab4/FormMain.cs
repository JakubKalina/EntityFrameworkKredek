using EntityFrameworkLab4.Models;
using EntityFrameworkLab4.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkLab4
{
    public partial class FormMain : Form
    {
        private readonly ISkiJumpingGeneric<Jumper> _jumpers;
        private readonly ISkiJumpingGeneric<Country> _countries;

        public FormMain()
        {
            InitializeComponent();
            _jumpers = new SkiJumpingGeneric<Jumper>();
            _countries = new SkiJumpingGeneric<Country>();
        }

        private void buttonJumperUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
