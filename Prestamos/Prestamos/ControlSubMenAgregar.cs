using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class ControlSubMenAgregar : UserControl
    {
        public ControlSubMenAgregar()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserControl nuevo = (UserControl)this.ParentForm.Controls.Find("controlLibros1", true)[0];
            nuevo.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserControl nuevoAdmin = (UserControl)this.ParentForm.Controls.Find("controlAdministrador1", true)[0];
            nuevoAdmin.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl nuevoEstudiante = (UserControl)this.ParentForm.Controls.Find("controlEstudiante1", true)[0];
            nuevoEstudiante.BringToFront();
        }
    }
}
