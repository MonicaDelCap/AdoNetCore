namespace AdoNetCore
{
    partial class Form04EliminarPlantilla
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
            btnEliminarEnfermo = new Button();
            lstEmpleados = new ListBox();
            txtIdEmpleado = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEliminarEnfermo
            // 
            btnEliminarEnfermo.Location = new Point(61, 153);
            btnEliminarEnfermo.Name = "btnEliminarEnfermo";
            btnEliminarEnfermo.Size = new Size(94, 29);
            btnEliminarEnfermo.TabIndex = 9;
            btnEliminarEnfermo.Text = "Eliminar";
            btnEliminarEnfermo.UseVisualStyleBackColor = true;
            btnEliminarEnfermo.Click += btnEliminarEnfermo_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(310, 108);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(409, 284);
            lstEmpleados.TabIndex = 8;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(61, 99);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(125, 27);
            txtIdEmpleado.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 59);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "Empleados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 59);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 5;
            label1.Text = "ID Empleado";
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarEnfermo);
            Controls.Add(lstEmpleados);
            Controls.Add(txtIdEmpleado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarEnfermo;
        private ListBox lstEmpleados;
        private TextBox txtIdEmpleado;
        private Label label2;
        private Label label1;
    }
}