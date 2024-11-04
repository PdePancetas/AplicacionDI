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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_recomendados = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(255, 74);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(105, 28);
            this.btnShop.TabIndex = 0;
            this.btnShop.Text = "Tienda";
            this.btnShop.UseMnemonic = false;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnTienda_Click);
            // 
            // btnCommunity
            // 
            this.btnCommunity.Location = new System.Drawing.Point(394, 74);
            this.btnCommunity.Name = "btnCommunity";
            this.btnCommunity.Size = new System.Drawing.Size(105, 28);
            this.btnCommunity.TabIndex = 1;
            this.btnCommunity.Text = "Comunidad";
            this.btnCommunity.UseVisualStyleBackColor = true;
            this.btnCommunity.Click += new System.EventHandler(this.btnCommunity_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.Location = new System.Drawing.Point(528, 74);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(105, 28);
            this.btnSupport.TabIndex = 2;
            this.btnSupport.Text = "Soporte";
            this.btnSupport.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(779, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Mi Perfil";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel_recomendados
            // 
            this.panel_recomendados.Location = new System.Drawing.Point(255, 108);
            this.panel_recomendados.Name = "panel_recomendados";
            this.panel_recomendados.Size = new System.Drawing.Size(378, 225);
            this.panel_recomendados.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BlizzardApp.Properties.Resources.blizzardLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlizzardApp.Properties.Resources.EJRUQ2OU4NN2TOALAB637TBPWQ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 587);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_recomendados);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSupport);
            this.Controls.Add(this.btnCommunity);
            this.Controls.Add(this.btnShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Opacity = 0.6D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnCommunity;
        private System.Windows.Forms.Button btnSupport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel_recomendados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

