namespace proyectoFruteria.Vista
{
    partial class ticket
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
            this.lblticket = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblticket
            // 
            this.lblticket.AutoSize = true;
            this.lblticket.Location = new System.Drawing.Point(12, 9);
            this.lblticket.Name = "lblticket";
            this.lblticket.Size = new System.Drawing.Size(35, 13);
            this.lblticket.TabIndex = 0;
            this.lblticket.Text = "label1";
            // 
            // ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 500);
            this.Controls.Add(this.lblticket);
            this.Name = "ticket";
            this.Text = "ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblticket;
    }
}