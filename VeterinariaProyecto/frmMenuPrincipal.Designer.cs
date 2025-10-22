namespace VeterinariaProyecto
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCliente = new Button();
            btnCitas = new Button();
            btnProductos = new Button();
            btnEmpleados = new Button();
            btnProveedor = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_project;
            pictureBox1.Location = new Point(27, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.ActiveCaption;
            btnCliente.Location = new Point(188, 153);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(120, 40);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = SystemColors.ActiveCaption;
            btnCitas.Location = new Point(428, 153);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(120, 40);
            btnCitas.TabIndex = 2;
            btnCitas.Text = "Reservaciones";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = SystemColors.ActiveCaption;
            btnProductos.Location = new Point(668, 153);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(120, 40);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = SystemColors.ActiveCaption;
            btnEmpleados.Location = new Point(308, 346);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(120, 40);
            btnEmpleados.TabIndex = 4;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = SystemColors.ActiveCaption;
            btnProveedor.Location = new Point(548, 346);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(120, 40);
            btnProveedor.TabIndex = 5;
            btnProveedor.Text = "Proveedores";
            btnProveedor.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnProveedor);
            Controls.Add(btnEmpleados);
            Controls.Add(btnProductos);
            Controls.Add(btnCitas);
            Controls.Add(btnCliente);
            Controls.Add(panel1);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCliente;
        private Button btnCitas;
        private Button btnProductos;
        private Button btnEmpleados;
        private Button btnProveedor;
        private PictureBox pictureBox1;
    }
}