namespace Examen5_6
{
    partial class Texto
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
            this.TxtDetalle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.Location = new System.Drawing.Point(0, 0);
            this.TxtDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDetalle.Multiline = true;
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.Size = new System.Drawing.Size(453, 451);
            this.TxtDetalle.TabIndex = 1;
            // 
            // Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.TxtDetalle);
            this.Name = "Texto";
            this.Text = "Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtDetalle;
    }
}