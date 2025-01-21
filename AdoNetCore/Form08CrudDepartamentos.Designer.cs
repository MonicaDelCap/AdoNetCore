namespace AdoNetCore
{
    partial class Form08CrudDepartamentos
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
            label1 = new Label();
            label2 = new Label();
            lstDepartamentos = new ListBox();
            txtId = new TextBox();
            txtLocalidad = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 40);
            label1.Name = "label1";
            label1.Size = new Size(172, 31);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 84);
            label2.Name = "label2";
            label2.Size = new Size(36, 31);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(85, 93);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(294, 345);
            lstDepartamentos.TabIndex = 2;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(510, 133);
            txtId.Name = "txtId";
            txtId.Size = new Size(175, 38);
            txtId.TabIndex = 3;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(510, 400);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(175, 38);
            txtLocalidad.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(510, 260);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(175, 38);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 195);
            label3.Name = "label3";
            label3.Size = new Size(98, 31);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 341);
            label4.Name = "label4";
            label4.Size = new Size(113, 31);
            label4.TabIndex = 7;
            label4.Text = "Localidad";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(803, 157);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(137, 51);
            btnInsertar.TabIndex = 8;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(803, 256);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(137, 51);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(803, 353);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(137, 51);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 509);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtLocalidad);
            Controls.Add(txtId);
            Controls.Add(lstDepartamentos);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form08CrudDepartamentos";
            Text = "Form08CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstDepartamentos;
        private TextBox txtId;
        private TextBox txtLocalidad;
        private TextBox txtNombre;
        private Label label3;
        private Label label4;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}