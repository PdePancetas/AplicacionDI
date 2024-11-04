namespace BlizzardApp
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
            this.btnShop = new System.Windows.Forms.Button();
            this.btnCommunity = new System.Windows.Forms.Button();
            this.btnSupport = new System.Windows.Forms.Button();
            this.panel_ultimosLanzamientos = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_Perfil = new System.Windows.Forms.ComboBox();
            this.panel_ultimosLanzamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.CadetBlue;
            this.btnShop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShop.Location = new System.Drawing.Point(341, 15);
            this.btnShop.Margin = new System.Windows.Forms.Padding(4);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(140, 34);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "Tienda";
            this.btnShop.UseMnemonic = false;
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnTienda_Click);
            // 
            // btnCommunity
            // 
            this.btnCommunity.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCommunity.Location = new System.Drawing.Point(521, 13);
            this.btnCommunity.Margin = new System.Windows.Forms.Padding(4);
            this.btnCommunity.Name = "btnCommunity";
            this.btnCommunity.Size = new System.Drawing.Size(140, 34);
            this.btnCommunity.TabIndex = 1;
            this.btnCommunity.Text = "Comunidad";
            this.btnCommunity.UseVisualStyleBackColor = false;
            this.btnCommunity.Click += new System.EventHandler(this.btnCommunity_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSupport.Location = new System.Drawing.Point(713, 15);
            this.btnSupport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(140, 34);
            this.btnSupport.TabIndex = 2;
            this.btnSupport.Text = "Soporte";
            this.btnSupport.UseVisualStyleBackColor = false;
            // 
            // panel_ultimosLanzamientos
            // 
            this.panel_ultimosLanzamientos.BackColor = System.Drawing.Color.Transparent;
            this.panel_ultimosLanzamientos.Controls.Add(this.pictureBox4);
            this.panel_ultimosLanzamientos.Controls.Add(this.pictureBox3);
            this.panel_ultimosLanzamientos.Controls.Add(this.pictureBox2);
            this.panel_ultimosLanzamientos.Location = new System.Drawing.Point(306, 133);
            this.panel_ultimosLanzamientos.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ultimosLanzamientos.Name = "panel_ultimosLanzamientos";
            this.panel_ultimosLanzamientos.Size = new System.Drawing.Size(577, 198);
            this.panel_ultimosLanzamientos.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::BlizzardApp.Properties.Resources.juego3;
            this.pictureBox4.Location = new System.Drawing.Point(396, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(160, 202);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BlizzardApp.Properties.Resources.juego2;
            this.pictureBox3.Location = new System.Drawing.Point(202, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(176, 202);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BlizzardApp.Properties.Resources.juego1;
            this.pictureBox2.Location = new System.Drawing.Point(17, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(400, 40, 40, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BlizzardApp.Properties.Resources.blizzardLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_Perfil
            // 
            this.comboBox_Perfil.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBox_Perfil.FormattingEnabled = true;
            this.comboBox_Perfil.Items.AddRange(new object[] {
            "Ver mis datos",
            "Detalles de mi cuenta",
            "Filtros de la tienda",
            "Cambiar de cuenta",
            "Cerrar sesión"});
            this.comboBox_Perfil.Location = new System.Drawing.Point(1038, 12);
            this.comboBox_Perfil.Name = "comboBox_Perfil";
            this.comboBox_Perfil.Size = new System.Drawing.Size(132, 24);
            this.comboBox_Perfil.TabIndex = 6;
            this.comboBox_Perfil.Text = "Mi Perfil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::BlizzardApp.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 602);
            this.Controls.Add(this.comboBox_Perfil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_ultimosLanzamientos);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.btnCommunity);
            this.Controls.Add(this.btnShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_ultimosLanzamientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnCommunity;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.Panel panel_ultimosLanzamientos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox_Perfil;
    }
}

