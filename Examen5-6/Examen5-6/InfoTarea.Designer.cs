namespace Examen5_6
{
    partial class InfoTarea
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
            this.BSalir2 = new System.Windows.Forms.Button();
            this.BEnter2 = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.TxtHour = new System.Windows.Forms.TextBox();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblHour = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BSalir2
            // 
            this.BSalir2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BSalir2.Location = new System.Drawing.Point(264, 137);
            this.BSalir2.Margin = new System.Windows.Forms.Padding(2);
            this.BSalir2.Name = "BSalir2";
            this.BSalir2.Size = new System.Drawing.Size(71, 25);
            this.BSalir2.TabIndex = 27;
            this.BSalir2.Text = "&Salir";
            this.BSalir2.UseVisualStyleBackColor = true;
            this.BSalir2.Click += new System.EventHandler(this.BSalir2_Click);
            // 
            // BEnter2
            // 
            this.BEnter2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BEnter2.Location = new System.Drawing.Point(114, 137);
            this.BEnter2.Margin = new System.Windows.Forms.Padding(2);
            this.BEnter2.Name = "BEnter2";
            this.BEnter2.Size = new System.Drawing.Size(71, 25);
            this.BEnter2.TabIndex = 26;
            this.BEnter2.Text = "En&ter";
            this.BEnter2.UseVisualStyleBackColor = true;
            this.BEnter2.Click += new System.EventHandler(this.BEnter2_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(259, 85);
            this.TxtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(76, 20);
            this.TxtStatus.TabIndex = 25;
            // 
            // TxtHour
            // 
            this.TxtHour.Location = new System.Drawing.Point(259, 52);
            this.TxtHour.Margin = new System.Windows.Forms.Padding(2);
            this.TxtHour.Name = "TxtHour";
            this.TxtHour.Size = new System.Drawing.Size(76, 20);
            this.TxtHour.TabIndex = 23;
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(259, 18);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(161, 20);
            this.TxtDesc.TabIndex = 21;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(95, 82);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(76, 20);
            this.TxtName.TabIndex = 19;
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(95, 52);
            this.TxtDate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(76, 20);
            this.TxtDate.TabIndex = 17;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(95, 23);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(76, 20);
            this.TxtUser.TabIndex = 14;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(195, 90);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(40, 13);
            this.LblStatus.TabIndex = 24;
            this.LblStatus.Text = "&Status:";
            // 
            // LblHour
            // 
            this.LblHour.AutoSize = true;
            this.LblHour.Location = new System.Drawing.Point(195, 59);
            this.LblHour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(33, 13);
            this.LblHour.TabIndex = 22;
            this.LblHour.Text = "&Hora:";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(189, 24);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(66, 13);
            this.LblDescription.TabIndex = 20;
            this.LblDescription.Text = "D&escripcion:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(31, 85);
            this.LblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 13);
            this.LblName.TabIndex = 18;
            this.LblName.Text = "&Nombre:";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(38, 55);
            this.LblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(40, 13);
            this.LblDate.TabIndex = 15;
            this.LblDate.Text = "&Fecha:";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(32, 26);
            this.LblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(46, 13);
            this.LblUser.TabIndex = 16;
            this.LblUser.Text = "&Usuario:";
            // 
            // InfoTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 209);
            this.Controls.Add(this.BSalir2);
            this.Controls.Add(this.BEnter2);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.TxtHour);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblUser);
            this.Name = "InfoTarea";
            this.Text = "InfoTarea";
            this.Load += new System.EventHandler(this.InfoTarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSalir2;
        private System.Windows.Forms.Button BEnter2;
        public System.Windows.Forms.TextBox TxtStatus;
        public System.Windows.Forms.TextBox TxtHour;
        public System.Windows.Forms.TextBox TxtDesc;
        public System.Windows.Forms.TextBox TxtName;
        public System.Windows.Forms.TextBox TxtDate;
        public System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblUser;
    }
}