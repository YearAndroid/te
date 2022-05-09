
namespace Prestamos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlSubMenAgregar1 = new Prestamos.ControlSubMenAgregar();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.controlEstudiante1 = new Prestamos.ControlEstudiante();
            this.controlAdministrador1 = new Prestamos.ControlAdministrador();
            this.controlInicio1 = new Prestamos.ControlInicio();
            this.controlLibros1 = new Prestamos.ControlLibros();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.PnPrincipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.controlSubMenAgregar1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 405);
            this.panel1.TabIndex = 2;
            // 
            // controlSubMenAgregar1
            // 
            this.controlSubMenAgregar1.Location = new System.Drawing.Point(0, 181);
            this.controlSubMenAgregar1.Name = "controlSubMenAgregar1";
            this.controlSubMenAgregar1.Size = new System.Drawing.Size(207, 198);
            this.controlSubMenAgregar1.TabIndex = 1;
            this.controlSubMenAgregar1.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Bibliotecario";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Administrador";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Estudiante";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-3, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseEnter += new System.EventHandler(this.button1_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(0, 99);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(207, 35);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.Controls.Add(this.controlEstudiante1);
            this.PnPrincipal.Controls.Add(this.controlAdministrador1);
            this.PnPrincipal.Controls.Add(this.controlInicio1);
            this.PnPrincipal.Controls.Add(this.controlLibros1);
            this.PnPrincipal.Controls.Add(this.panel2);
            this.PnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnPrincipal.Location = new System.Drawing.Point(207, 0);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(807, 405);
            this.PnPrincipal.TabIndex = 3;
            this.PnPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // controlEstudiante1
            // 
            this.controlEstudiante1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.controlEstudiante1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlEstudiante1.Location = new System.Drawing.Point(0, 36);
            this.controlEstudiante1.Name = "controlEstudiante1";
            this.controlEstudiante1.Size = new System.Drawing.Size(807, 369);
            this.controlEstudiante1.TabIndex = 4;
            // 
            // controlAdministrador1
            // 
            this.controlAdministrador1.BackColor = System.Drawing.Color.GreenYellow;
            this.controlAdministrador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlAdministrador1.Location = new System.Drawing.Point(0, 36);
            this.controlAdministrador1.Name = "controlAdministrador1";
            this.controlAdministrador1.Size = new System.Drawing.Size(807, 369);
            this.controlAdministrador1.TabIndex = 3;
            // 
            // controlInicio1
            // 
            this.controlInicio1.BackColor = System.Drawing.SystemColors.Highlight;
            this.controlInicio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlInicio1.Location = new System.Drawing.Point(0, 36);
            this.controlInicio1.Name = "controlInicio1";
            this.controlInicio1.Size = new System.Drawing.Size(807, 369);
            this.controlInicio1.TabIndex = 2;
            // 
            // controlLibros1
            // 
            this.controlLibros1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.controlLibros1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlLibros1.Location = new System.Drawing.Point(0, 36);
            this.controlLibros1.Name = "controlLibros1";
            this.controlLibros1.Size = new System.Drawing.Size(807, 369);
            this.controlLibros1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 36);
            this.panel2.TabIndex = 0;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(775, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 405);
            this.Controls.Add(this.PnPrincipal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Prestamos de Libro URACCAN";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.PnPrincipal.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel PnPrincipal;
        private ControlLibros userControl11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public ControlSubMenAgregar controlSubMenAgregar1;
        public ControlLibros controlLibros1;
        public ControlInicio controlInicio1;
        public ControlAdministrador controlAdministrador1;
        public ControlEstudiante controlEstudiante1;
    }
}

