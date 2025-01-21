namespace AdoNetCore
{
    partial class Form03EliminarEnfermos
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
            txtInscripcion = new TextBox();
            lstEnfermos = new ListBox();
            btnEliminarEnfermo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Inscripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 36);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Enfermos";
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(35, 85);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(125, 27);
            txtInscripcion.TabIndex = 2;
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.Location = new Point(264, 85);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(409, 284);
            lstEnfermos.TabIndex = 3;
            // 
            // btnEliminarEnfermo
            // 
            btnEliminarEnfermo.Location = new Point(46, 151);
            btnEliminarEnfermo.Name = "btnEliminarEnfermo";
            btnEliminarEnfermo.Size = new Size(94, 29);
            btnEliminarEnfermo.TabIndex = 4;
            btnEliminarEnfermo.Text = "Eliminar";
            btnEliminarEnfermo.UseVisualStyleBackColor = true;
            btnEliminarEnfermo.Click += btnEliminarEnfermo_Click;
            // 
            // Form03EliminarEnfermos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarEnfermo);
            Controls.Add(lstEnfermos);
            Controls.Add(txtInscripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03EliminarEnfermos";
            Text = "Form03EliminarEnfermos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtInscripcion;
        private ListBox lstEnfermos;
        private Button btnEliminarEnfermo;
    }
}