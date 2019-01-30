namespace proyectoFruteria.Vista
{
    partial class AgregarProducto
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
            this.components = new System.ComponentModel.Container();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmFechaAdquirido = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorCampoVacio = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoVacio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(232, 49);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreProducto.MaxLength = 50;
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(279, 26);
            this.txtNombreProducto.TabIndex = 3;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            this.txtNombreProducto.Validated += new System.EventHandler(this.txtNombreProducto_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del pruducto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio adquirido:";
            // 
            // txtPrecioAd
            // 
            this.txtPrecioAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecioAd.Location = new System.Drawing.Point(188, 91);
            this.txtPrecioAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioAd.MaxLength = 5;
            this.txtPrecioAd.Multiline = true;
            this.txtPrecioAd.Name = "txtPrecioAd";
            this.txtPrecioAd.Size = new System.Drawing.Size(97, 26);
            this.txtPrecioAd.TabIndex = 5;
            this.txtPrecioAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioAd_KeyPress);
            this.txtPrecioAd.Validated += new System.EventHandler(this.txtPrecioAd_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(307, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio de venta:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrecioVenta.Location = new System.Drawing.Point(477, 89);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioVenta.MaxLength = 5;
            this.txtPrecioVenta.Multiline = true;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(83, 26);
            this.txtPrecioVenta.TabIndex = 7;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            this.txtPrecioVenta.Validated += new System.EventHandler(this.txtPrecioVenta_Validated);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCantidad.Location = new System.Drawing.Point(152, 150);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.MaxLength = 5;
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(68, 26);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Validated += new System.EventHandler(this.txtCantidad_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad(Kg):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(2, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha de adquisición :";
            // 
            // dtmFechaAdquirido
            // 
            this.dtmFechaAdquirido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtmFechaAdquirido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaAdquirido.Location = new System.Drawing.Point(232, 5);
            this.dtmFechaAdquirido.Margin = new System.Windows.Forms.Padding(2);
            this.dtmFechaAdquirido.Name = "dtmFechaAdquirido";
            this.dtmFechaAdquirido.Size = new System.Drawing.Size(167, 26);
            this.dtmFechaAdquirido.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(251, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(366, 150);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(131, 28);
            this.cmbCategoria.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(284, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 39);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAceptar.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(100, 200);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(132, 39);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorCampoVacio
            // 
            this.errorCampoVacio.ContainerControl = this;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 244);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtmFechaAdquirido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProducto);
            this.Location = new System.Drawing.Point(350, 142);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.errorCampoVacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtmFechaAdquirido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ErrorProvider errorCampoVacio;
    }
}