﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnListarDepartamentos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCrearDepartamento_Click(object sender, EventArgs e)
        {
            FrmCrearDepartamento frmCrear = new FrmCrearDepartamento();
            frmCrear.ShowDialog();
        }
    }
}
