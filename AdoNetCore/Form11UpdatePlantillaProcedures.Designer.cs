namespace AdoNetCore
{
    partial class Form11UpdatePlantillaProcedures
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
            txtIncremento = new TextBox();
            btnModificarSalario = new Button();
            cmbHospitales = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            lstPlantilla = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 40);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(381, 71);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(206, 27);
            txtIncremento.TabIndex = 1;
            // 
            // btnModificarSalario
            // 
            btnModificarSalario.Location = new Point(251, 126);
            btnModificarSalario.Name = "btnModificarSalario";
            btnModificarSalario.Size = new Size(159, 46);
            btnModificarSalario.TabIndex = 2;
            btnModificarSalario.Text = "Modificar Salario";
            btnModificarSalario.UseVisualStyleBackColor = true;
            btnModificarSalario.Click += btnModificarSalario_Click;
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(98, 70);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(180, 28);
            cmbHospitales.TabIndex = 3;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 40);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "Incremento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 174);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(68, 216);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(554, 204);
            lstPlantilla.TabIndex = 6;
            // 
            // Form11UpdatePlantillaProcedures
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 463);
            Controls.Add(lstPlantilla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbHospitales);
            Controls.Add(btnModificarSalario);
            Controls.Add(txtIncremento);
            Controls.Add(label1);
            Name = "Form11UpdatePlantillaProcedures";
            Text = "Form11UpdatePlantillaProcedures";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIncremento;
        private Button btnModificarSalario;
        private ComboBox cmbHospitales;
        private Label label2;
        private Label label3;
        private ListBox lstPlantilla;
    }
}