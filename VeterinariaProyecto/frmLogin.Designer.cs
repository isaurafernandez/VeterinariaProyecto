namespace VeterinariaProyecto
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            panel1 = new Panel();
            btnIngresar = new Button();
            bindingSource1 = new BindingSource(components);
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(580, 78);
            label1.Name = "label1";
            label1.Size = new Size(137, 52);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 248);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 220);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(15, 15, 15);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = SystemColors.InactiveCaption;
            txtUsuario.Location = new Point(467, 162);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(350, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "USUARIO";
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(15, 15, 15);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.ForeColor = SystemColors.InactiveCaption;
            txtContraseña.Location = new Point(467, 248);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(350, 27);
            txtContraseña.TabIndex = 4;
            txtContraseña.Text = "CONTRASEÑA";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.BackgroundImage = Properties.Resources.fondo_vet_5;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 450);
            panel1.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.GrayText;
            btnIngresar.Location = new Point(547, 328);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(193, 29);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_project;
            pictureBox1.Location = new Point(117, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(914, 450);
            Controls.Add(btnIngresar);
            Controls.Add(panel1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Panel panel1;
        private Button btnIngresar;
        private BindingSource bindingSource1;
        private PictureBox pictureBox1;
    }
}
