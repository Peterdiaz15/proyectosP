namespace proyectoFruteria.Vista
{
    partial class frmCatalogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.grpCatalogo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.grpCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCatalogo
            // 
            this.grpCatalogo.AutoSize = true;
            this.grpCatalogo.BackColor = System.Drawing.Color.LemonChiffon;
            this.grpCatalogo.Controls.Add(this.label1);
            this.grpCatalogo.Controls.Add(this.btnSalir);
            this.grpCatalogo.Controls.Add(this.btnReportes);
            this.grpCatalogo.Controls.Add(this.btnInventario);
            this.grpCatalogo.Controls.Add(this.Logo);
            this.grpCatalogo.Controls.Add(this.btnCategorias);
            this.grpCatalogo.Controls.Add(this.btnVentas);
            this.grpCatalogo.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCatalogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpCatalogo.Location = new System.Drawing.Point(3, 2);
            this.grpCatalogo.Name = "grpCatalogo";
            this.grpCatalogo.Size = new System.Drawing.Size(311, 584);
            this.grpCatalogo.TabIndex = 0;
            this.grpCatalogo.TabStop = false;
            this.grpCatalogo.Enter += new System.EventHandler(this.grpCatalogo_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Tomato;
            this.btnSalir.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(8, 480);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(297, 64);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReportes.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportes.Location = new System.Drawing.Point(8, 254);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(297, 64);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.DarkGreen;
            this.btnInventario.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventario.Location = new System.Drawing.Point(8, 325);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(297, 64);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.LemonChiffon;
            this.Logo.ErrorImage = null;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(-1, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(305, 177);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCategorias.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCategorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategorias.Location = new System.Drawing.Point(7, 396);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(297, 64);
            this.btnCategorias.TabIndex = 4;
            this.btnCategorias.Text = "Venta Diaria";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.DarkGreen;
            this.btnVentas.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentas.Location = new System.Drawing.Point(8, 183);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(297, 64);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnCuentasDeUsuario_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 526);
            this.Controls.Add(this.grpCatalogo);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCatalogo";
            this.Text = "Fruteria La Huerta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            this.grpCatalogo.ResumeLayout(false);
            this.grpCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCatalogo;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}

