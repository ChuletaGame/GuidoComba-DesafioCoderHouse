namespace GuidoComba_DesafioAccesoADatos
{
    partial class FrmView
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
            btnCargarDatos = new Button();
            dgvListado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Location = new Point(67, 47);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(122, 69);
            btnCargarDatos.TabIndex = 0;
            btnCargarDatos.Text = "Cargar Datos";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // dgvListado
            // 
            dgvListado.AllowUserToAddRows = false;
            dgvListado.AllowUserToDeleteRows = false;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(12, 154);
            dgvListado.Name = "dgvListado";
            dgvListado.ReadOnly = true;
            dgvListado.RowTemplate.Height = 25;
            dgvListado.Size = new Size(776, 284);
            dgvListado.TabIndex = 1;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListado);
            Controls.Add(btnCargarDatos);
            Name = "FrmView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargarDatos;
        private DataGridView dgvListado;
    }
}
