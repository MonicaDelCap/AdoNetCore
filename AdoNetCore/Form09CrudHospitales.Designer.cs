namespace AdoNetCore
{
    partial class Form09CrudHospitales
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
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            label4 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtId = new TextBox();
            lstHospitales = new ListBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtCamas = new Label();
            txtTelefono = new TextBox();
            txtCam = new TextBox();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(772, 370);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 51);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(772, 273);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(137, 51);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(772, 174);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(137, 51);
            btnInsertar.TabIndex = 19;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 205);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 18;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(479, 110);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 17;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(479, 146);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 27);
            txtNombre.TabIndex = 16;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(479, 245);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(175, 27);
            txtDireccion.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Location = new Point(479, 73);
            txtId.Name = "txtId";
            txtId.Size = new Size(175, 27);
            txtId.TabIndex = 14;
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(54, 110);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(294, 344);
            lstHospitales.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 41);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 57);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 11;
            label1.Text = "Hospital";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 304);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 22;
            label5.Text = "Telefono";
            // 
            // txtCamas
            // 
            txtCamas.AutoSize = true;
            txtCamas.Location = new Point(479, 401);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(53, 20);
            txtCamas.TabIndex = 23;
            txtCamas.Text = "Camas";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(479, 348);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(175, 27);
            txtTelefono.TabIndex = 24;
            // 
            // txtCam
            // 
            txtCam.Location = new Point(479, 427);
            txtCam.Name = "txtCam";
            txtCam.Size = new Size(175, 27);
            txtCam.TabIndex = 25;
            // 
            // Form09CrudHospitales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 529);
            Controls.Add(txtCam);
            Controls.Add(txtTelefono);
            Controls.Add(txtCamas);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtDireccion);
            Controls.Add(txtId);
            Controls.Add(lstHospitales);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form09CrudHospitales";
            Text = "Form09CrudHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnInsertar;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtId;
        private ListBox lstHospitales;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label txtCamas;
        private TextBox txtTelefono;
        private TextBox txtCam;
    }
}