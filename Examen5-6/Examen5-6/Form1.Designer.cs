namespace Examen5_6
{
    partial class Form1
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
            this.BSubir = new System.Windows.Forms.Button();
            this.TxtMenu = new System.Windows.Forms.TextBox();
            this.BMenu = new System.Windows.Forms.Button();
            this.BSalida = new System.Windows.Forms.Button();
            this.BEnter = new System.Windows.Forms.Button();
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.LblOption = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.DataGridView();
            this.Cuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            this.SuspendLayout();
            // 
            // BSubir
            // 
            this.BSubir.Location = new System.Drawing.Point(309, 248);
            this.BSubir.Margin = new System.Windows.Forms.Padding(2);
            this.BSubir.Name = "BSubir";
            this.BSubir.Size = new System.Drawing.Size(83, 28);
            this.BSubir.TabIndex = 19;
            this.BSubir.Text = "S&ubir";
            this.BSubir.UseVisualStyleBackColor = true;
            this.BSubir.Click += new System.EventHandler(this.BSubir_Click);
            // 
            // TxtMenu
            // 
            this.TxtMenu.Enabled = false;
            this.TxtMenu.Location = new System.Drawing.Point(32, 239);
            this.TxtMenu.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMenu.Multiline = true;
            this.TxtMenu.Name = "TxtMenu";
            this.TxtMenu.Size = new System.Drawing.Size(216, 95);
            this.TxtMenu.TabIndex = 16;
            // 
            // BMenu
            // 
            this.BMenu.Location = new System.Drawing.Point(564, 248);
            this.BMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BMenu.Name = "BMenu";
            this.BMenu.Size = new System.Drawing.Size(83, 28);
            this.BMenu.TabIndex = 15;
            this.BMenu.Text = "&Menu";
            this.BMenu.UseVisualStyleBackColor = true;
            this.BMenu.Click += new System.EventHandler(this.BMenu_Click);
            // 
            // BSalida
            // 
            this.BSalida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BSalida.Location = new System.Drawing.Point(684, 248);
            this.BSalida.Margin = new System.Windows.Forms.Padding(2);
            this.BSalida.Name = "BSalida";
            this.BSalida.Size = new System.Drawing.Size(83, 28);
            this.BSalida.TabIndex = 14;
            this.BSalida.Text = "&Salida";
            this.BSalida.UseVisualStyleBackColor = true;
            // 
            // BEnter
            // 
            this.BEnter.Location = new System.Drawing.Point(431, 248);
            this.BEnter.Margin = new System.Windows.Forms.Padding(2);
            this.BEnter.Name = "BEnter";
            this.BEnter.Size = new System.Drawing.Size(83, 28);
            this.BEnter.TabIndex = 13;
            this.BEnter.Text = "&Enter";
            this.BEnter.UseVisualStyleBackColor = true;
            this.BEnter.Click += new System.EventHandler(this.BEnter_Click);
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(422, 318);
            this.txtOpcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(76, 20);
            this.txtOpcion.TabIndex = 10;
            // 
            // LblOption
            // 
            this.LblOption.AutoSize = true;
            this.LblOption.Location = new System.Drawing.Point(374, 321);
            this.LblOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblOption.Name = "LblOption";
            this.LblOption.Size = new System.Drawing.Size(44, 13);
            this.LblOption.TabIndex = 11;
            this.LblOption.Text = "&Opcion:";
            // 
            // Info
            // 
            this.Info.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuser,
            this.Cfecha,
            this.Cname,
            this.Cdescripcion,
            this.Chour,
            this.Cstatus});
            this.Info.GridColor = System.Drawing.Color.Black;
            this.Info.Location = new System.Drawing.Point(14, 29);
            this.Info.Margin = new System.Windows.Forms.Padding(2);
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.RowHeadersWidth = 49;
            this.Info.RowTemplate.Height = 24;
            this.Info.Size = new System.Drawing.Size(775, 171);
            this.Info.TabIndex = 12;
            this.Info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Info_CellContentClick);
            // 
            // Cuser
            // 
            this.Cuser.HeaderText = "Usuario";
            this.Cuser.MinimumWidth = 6;
            this.Cuser.Name = "Cuser";
            this.Cuser.ReadOnly = true;
            this.Cuser.Width = 120;
            // 
            // Cfecha
            // 
            this.Cfecha.HeaderText = "Fecha";
            this.Cfecha.MinimumWidth = 6;
            this.Cfecha.Name = "Cfecha";
            this.Cfecha.ReadOnly = true;
            this.Cfecha.Width = 120;
            // 
            // Cname
            // 
            this.Cname.HeaderText = "Nombre";
            this.Cname.MinimumWidth = 6;
            this.Cname.Name = "Cname";
            this.Cname.ReadOnly = true;
            this.Cname.Width = 120;
            // 
            // Cdescripcion
            // 
            this.Cdescripcion.HeaderText = "Descripcion";
            this.Cdescripcion.MinimumWidth = 6;
            this.Cdescripcion.Name = "Cdescripcion";
            this.Cdescripcion.ReadOnly = true;
            this.Cdescripcion.Width = 120;
            // 
            // Chour
            // 
            this.Chour.HeaderText = "Hora";
            this.Chour.MinimumWidth = 6;
            this.Chour.Name = "Chour";
            this.Chour.ReadOnly = true;
            this.Chour.Width = 120;
            // 
            // Cstatus
            // 
            this.Cstatus.HeaderText = "Status";
            this.Cstatus.MinimumWidth = 6;
            this.Cstatus.Name = "Cstatus";
            this.Cstatus.ReadOnly = true;
            this.Cstatus.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(655, 318);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(76, 20);
            this.txtStatus.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Opciones de menu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(808, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BSubir);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtMenu);
            this.Controls.Add(this.BMenu);
            this.Controls.Add(this.BSalida);
            this.Controls.Add(this.BEnter);
            this.Controls.Add(this.txtOpcion);
            this.Controls.Add(this.LblOption);
            this.Controls.Add(this.Info);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSubir;
        private System.Windows.Forms.TextBox TxtMenu;
        private System.Windows.Forms.Button BMenu;
        private System.Windows.Forms.Button BSalida;
        private System.Windows.Forms.Button BEnter;
        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.Label LblOption;
        public System.Windows.Forms.DataGridView Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label2;
    }
}

