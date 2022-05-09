using System;
using System.Linq;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class Form1 : Form
    {
        public int xClick = 0, yClick = 0;
        public Form1()
        {
            InitializeComponent();
            //ControlLibros nuevo = new ControlLibros();
            //this.Controls.Add(nuevo);
           // controlInicio1.BringToFront();
                
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            controlInicio1.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //controlLibros1.BringToFront();
            controlSubMenAgregar1.Visible = true;
            
            controlSubMenAgregar1.BringToFront();
            
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //controlEstudiante1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //controlAdministrador1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            if(this.WindowState == FormWindowState.Maximized){
                this.WindowState = FormWindowState.Normal;

            }else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            controlSubMenAgregar1.Visible = false;
            controlSubMenAgregar1.SendToBack();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        { 
                if (e.Button != MouseButtons.Left)
                { xClick = e.X; yClick = e.Y; }
                else
                { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
