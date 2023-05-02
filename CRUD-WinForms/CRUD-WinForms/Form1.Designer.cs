namespace CRUD_WinForms
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtDNI = new TextBox();
            TxtNombre = new TextBox();
            TxtApellido = new TextBox();
            TxtTelefono = new TextBox();
            DateNacimiento = new DateTimePicker();
            label6 = new Label();
            BtnAgregar = new Button();
            panel1 = new Panel();
            BtnModificar = new Button();
            DGVUsuarios = new DataGridView();
            label7 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            TxtDNIEliminar = new TextBox();
            label8 = new Label();
            BtnEliminar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 62);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 106);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 150);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingrese Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 194);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 3;
            label4.Text = "Ingrese Fecha Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 238);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 4;
            label5.Text = "Ingrese Telefono";
            // 
            // TxtDNI
            // 
            TxtDNI.Location = new Point(7, 80);
            TxtDNI.Name = "TxtDNI";
            TxtDNI.Size = new Size(100, 23);
            TxtDNI.TabIndex = 5;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(7, 124);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(100, 23);
            TxtNombre.TabIndex = 6;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(7, 168);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(100, 23);
            TxtApellido.TabIndex = 7;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Location = new Point(7, 256);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(100, 23);
            TxtTelefono.TabIndex = 8;
            // 
            // DateNacimiento
            // 
            DateNacimiento.Location = new Point(7, 212);
            DateNacimiento.Name = "DateNacimiento";
            DateNacimiento.Size = new Size(219, 23);
            DateNacimiento.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 24);
            label6.Name = "label6";
            label6.Size = new Size(177, 25);
            label6.TabIndex = 10;
            label6.Text = "AGREGAR USUARIO";
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(32, 296);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(75, 23);
            BtnAgregar.TabIndex = 11;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnModificar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(BtnAgregar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DateNacimiento);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TxtTelefono);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TxtApellido);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TxtNombre);
            panel1.Controls.Add(TxtDNI);
            panel1.Location = new Point(51, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 350);
            panel1.TabIndex = 12;
            // 
            // BtnModificar
            // 
            BtnModificar.Location = new Point(140, 296);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(75, 23);
            BtnModificar.TabIndex = 17;
            BtnModificar.Text = "Modificar";
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Location = new Point(3, 59);
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.RowTemplate.Height = 25;
            DGVUsuarios.Size = new Size(352, 176);
            DGVUsuarios.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(104, 24);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 14;
            label7.Text = "LISTA USUARIOS";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(TxtDNIEliminar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(BtnEliminar);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(DGVUsuarios);
            panel2.Location = new Point(335, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 350);
            panel2.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 299);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 16;
            label9.Text = "Ingrese DNI";
            // 
            // TxtDNIEliminar
            // 
            TxtDNIEliminar.Location = new Point(138, 296);
            TxtDNIEliminar.Name = "TxtDNIEliminar";
            TxtDNIEliminar.Size = new Size(100, 23);
            TxtDNIEliminar.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(104, 251);
            label8.Name = "label8";
            label8.Size = new Size(178, 25);
            label8.TabIndex = 16;
            label8.Text = "ELIMINAR USUARIO";
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(264, 296);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 16;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 475);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtDNI;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private TextBox TxtTelefono;
        private DateTimePicker DateNacimiento;
        private Label label6;
        private Button BtnAgregar;
        private Panel panel1;
        private DataGridView DGVUsuarios;
        private Label label7;
        private Panel panel2;
        private Button BtnEliminar;
        private Button BtnModificar;
        private Label label8;
        private Label label9;
        private TextBox TxtDNIEliminar;
    }
}