namespace AdoNetCore
{
    partial class Form06UpdateSalasClase
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
            btnModificarSalas = new Button();
            txtNuevaSala = new TextBox();
            label2 = new Label();
            lstSalas = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.Location = new Point(265, 148);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(125, 32);
            btnModificarSalas.TabIndex = 9;
            btnModificarSalas.Text = "Modificar Salas";
            btnModificarSalas.UseVisualStyleBackColor = true;
            btnModificarSalas.Click += btnModificarSalas_Click;
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(265, 93);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(125, 27);
            txtNuevaSala.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 54);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 7;
            label2.Text = "Nueva Sala";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(49, 93);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(187, 224);
            lstSalas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 54);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "Salas";
            // 
            // Form06UpdateSalasClase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 351);
            Controls.Add(btnModificarSalas);
            Controls.Add(txtNuevaSala);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(label1);
            Name = "Form06UpdateSalasClase";
            Text = "Form06UpdateSalasClase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarSalas;
        private TextBox txtNuevaSala;
        private Label label2;
        private ListBox lstSalas;
        private Label label1;
    }
}