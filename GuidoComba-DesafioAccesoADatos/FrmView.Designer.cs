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
            btnListarUsuarios = new Button();
            dgvListado = new DataGridView();
            btnBuscarUsuario = new Button();
            txtId = new TextBox();
            btnCrearUsuario = new Button();
            btnEliminarUsuario = new Button();
            btnModificarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // btnListarUsuarios
            // 
            btnListarUsuarios.Location = new Point(12, 48);
            btnListarUsuarios.Name = "btnListarUsuarios";
            btnListarUsuarios.Size = new Size(90, 50);
            btnListarUsuarios.TabIndex = 0;
            btnListarUsuarios.Text = "Listar Usuarios";
            btnListarUsuarios.UseVisualStyleBackColor = true;
            btnListarUsuarios.Click += btnListarUsuarios_Click;
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
            dgvListado.Size = new Size(520, 307);
            dgvListado.TabIndex = 1;
            dgvListado.SelectionChanged += dgvListado_SelectionChanged;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(108, 48);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(90, 50);
            btnBuscarUsuario.TabIndex = 2;
            btnBuscarUsuario.Text = "Buscar Usuario";
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(195, 104);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "Ingrese un ID";
            txtId.Size = new Size(109, 23);
            txtId.TabIndex = 3;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.Location = new Point(204, 48);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(90, 50);
            btnCrearUsuario.TabIndex = 4;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(300, 48);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(90, 50);
            btnEliminarUsuario.TabIndex = 5;
            btnEliminarUsuario.Text = "Borrar Usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnModificarUsuario
            // 
            btnModificarUsuario.Location = new Point(396, 48);
            btnModificarUsuario.Name = "btnModificarUsuario";
            btnModificarUsuario.Size = new Size(90, 50);
            btnModificarUsuario.TabIndex = 6;
            btnModificarUsuario.Text = "Modificar Usuario";
            btnModificarUsuario.UseVisualStyleBackColor = true;
            btnModificarUsuario.Click += btnModificarUsuario_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 489);
            Controls.Add(btnModificarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnCrearUsuario);
            Controls.Add(txtId);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(dgvListado);
            Controls.Add(btnListarUsuarios);
            Name = "FrmView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarUsuarios;
        private DataGridView dgvListado;
        private Button btnBuscarUsuario;
        private TextBox txtId;
        private Button btnCrearUsuario;
        private Button btnEliminarUsuario;
        private Button btnModificarUsuario;
    }
}
