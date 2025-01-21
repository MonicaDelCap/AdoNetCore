namespace AdoNetCore
{
    partial class Form10UpdateEmpleadosOficios
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
            Oficios = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSuma = new Label();
            lblMedia = new Label();
            lblMaximo = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            label1 = new Label();
            txtOficio = new TextBox();
            SuspendLayout();
            // 
            // Oficios
            // 
            Oficios.AutoSize = true;
            Oficios.Location = new Point(70, 42);
            Oficios.Name = "Oficios";
            Oficios.Size = new Size(55, 20);
            Oficios.TabIndex = 0;
            Oficios.Text = "Oficios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 42);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(575, 42);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Oficio";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(56, 315);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(50, 20);
            lblSuma.TabIndex = 3;
            lblSuma.Text = "label4";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(254, 315);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(50, 20);
            lblMedia.TabIndex = 4;
            lblMedia.Text = "label5";
            // 
            // lblMaximo
            // 
            lblMaximo.AutoSize = true;
            lblMaximo.Location = new Point(500, 315);
            lblMaximo.Name = "lblMaximo";
            lblMaximo.Size = new Size(50, 20);
            lblMaximo.TabIndex = 5;
            lblMaximo.Text = "label6";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(575, 173);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(125, 27);
            txtIncremento.TabIndex = 6;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(575, 239);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(125, 47);
            btnIncrementar.TabIndex = 7;
            btnIncrementar.Text = "Incremento";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(70, 84);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(157, 184);
            lstOficios.TabIndex = 8;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(299, 84);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(154, 184);
            lstEmpleados.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 137);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 10;
            label1.Text = "Incremento";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(575, 84);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(125, 27);
            txtOficio.TabIndex = 11;
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 400);
            Controls.Add(txtOficio);
            Controls.Add(label1);
            Controls.Add(lstEmpleados);
            Controls.Add(lstOficios);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(lblMaximo);
            Controls.Add(lblMedia);
            Controls.Add(lblSuma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Oficios);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Oficios;
        private Label label2;
        private Label label3;
        private Label lblSuma;
        private Label lblMedia;
        private Label lblMaximo;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private Label label1;
        private TextBox txtOficio;
    }
}