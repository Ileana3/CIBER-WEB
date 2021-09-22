using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIBER_WEB
{
    public partial class CIBER_WEB : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public CIBER_WEB()
        {
            InitializeComponent();

            fluentDesignFormContainer1.Controls.Add(new PACIENTE() { Dock = DockStyle.Fill });


        }
    }
}
