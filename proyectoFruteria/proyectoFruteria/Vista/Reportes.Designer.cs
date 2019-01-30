namespace proyectoFruteria.Vista
{
    partial class Reportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmFechaF = new System.Windows.Forms.DateTimePicker();
            this.dtmFechaI = new System.Windows.Forms.DateTimePicker();
            this.lbProducto = new System.Windows.Forms.Label();
            this.rbUno = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUANTOS PRODUCTOS";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.rbTodos.Location = new System.Drawing.Point(16, 104);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(2);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(101, 23);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos ";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtmFechaF);
            this.groupBox1.Controls.Add(this.dtmFechaI);
            this.groupBox1.Controls.Add(this.lbProducto);
            this.groupBox1.Controls.Add(this.rbUno);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(3, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(472, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNombreProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtNombreProducto.Location = new System.Drawing.Point(235, 183);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(212, 31);
            this.txtNombreProducto.TabIndex = 8;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(288, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Inicio:";
            // 
            // dtmFechaF
            // 
            this.dtmFechaF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaF.Location = new System.Drawing.Point(258, 50);
            this.dtmFechaF.Name = "dtmFechaF";
            this.dtmFechaF.Size = new System.Drawing.Size(169, 29);
            this.dtmFechaF.TabIndex = 5;
            // 
            // dtmFechaI
            // 
            this.dtmFechaI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaI.Location = new System.Drawing.Point(30, 50);
            this.dtmFechaI.Name = "dtmFechaI";
            this.dtmFechaI.Size = new System.Drawing.Size(178, 29);
            this.dtmFechaI.TabIndex = 0;
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Castellar", 10F, System.Drawing.FontStyle.Bold);
            this.lbProducto.Location = new System.Drawing.Point(4, 194);
            this.lbProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(227, 17);
            this.lbProducto.TabIndex = 3;
            this.lbProducto.Text = "Nombre del pruducto:";
            // 
            // rbUno
            // 
            this.rbUno.AutoSize = true;
            this.rbUno.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.rbUno.Location = new System.Drawing.Point(16, 141);
            this.rbUno.Margin = new System.Windows.Forms.Padding(2);
            this.rbUno.Name = "rbUno";
            this.rbUno.Size = new System.Drawing.Size(79, 23);
            this.rbUno.TabIndex = 1;
            this.rbUno.TabStop = true;
            this.rbUno.Text = "Uno ";
            this.rbUno.UseVisualStyleBackColor = true;
            this.rbUno.CheckedChanged += new System.EventHandler(this.rbUno_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Teal;
            this.btnCancelar.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(265, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Teal;
            this.btnAceptar.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(77, 275);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(132, 39);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 318);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUno;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dtmFechaF;
        private System.Windows.Forms.DateTimePicker dtmFechaI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProducto;
    }
}