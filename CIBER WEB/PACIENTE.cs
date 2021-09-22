using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIBER_WEB
{
    public partial class PACIENTE : DevExpress.XtraEditors.XtraForm
    {
        public PACIENTE()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            Empleados db = new Empleados();
            empleadosBindingSource.DataSource = Empleados.toList();

        }
    }
}