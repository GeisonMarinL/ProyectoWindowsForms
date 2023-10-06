namespace TriviaCulturaGeneral
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textoPrincipal = new System.Windows.Forms.Label();
            this.textoDescriptivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonIniciar = new System.Windows.Forms.Button();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.moverFormuario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textoPrincipal
            // 
            this.textoPrincipal.AutoSize = true;
            this.textoPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPrincipal.Location = new System.Drawing.Point(237, 43);
            this.textoPrincipal.Name = "textoPrincipal";
            this.textoPrincipal.Size = new System.Drawing.Size(146, 29);
            this.textoPrincipal.TabIndex = 0;
            this.textoPrincipal.Text = "Bienvenidos";
            // 
            // textoDescriptivo
            // 
            this.textoDescriptivo.AutoSize = true;
            this.textoDescriptivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoDescriptivo.Location = new System.Drawing.Point(194, 96);
            this.textoDescriptivo.Name = "textoDescriptivo";
            this.textoDescriptivo.Size = new System.Drawing.Size(247, 24);
            this.textoDescriptivo.TabIndex = 1;
            this.textoDescriptivo.Text = "Trivia Sobre Cultura General";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // botonIniciar
            // 
            this.botonIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonIniciar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonIniciar.FlatAppearance.BorderSize = 0;
            this.botonIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIniciar.Location = new System.Drawing.Point(260, 324);
            this.botonIniciar.Margin = new System.Windows.Forms.Padding(0);
            this.botonIniciar.Name = "botonIniciar";
            this.botonIniciar.Size = new System.Drawing.Size(123, 38);
            this.botonIniciar.TabIndex = 3;
            this.botonIniciar.Text = "Iniciar Test";
            this.botonIniciar.UseVisualStyleBackColor = false;
            this.botonIniciar.Click += new System.EventHandler(this.botonIniciar_Click);
            // 
            // botonCerrar
            // 
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrar.Location = new System.Drawing.Point(610, -3);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(40, 40);
            this.botonCerrar.TabIndex = 4;
            this.botonCerrar.Text = "X";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 40);
            this.panel1.TabIndex = 5;
            // 
            // moverFormuario
            // 
            this.moverFormuario.Fixed = true;
            this.moverFormuario.Horizontal = true;
            this.moverFormuario.TargetControl = this;
            this.moverFormuario.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.botonIniciar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textoDescriptivo);
            this.Controls.Add(this.textoPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoPrincipal;
        private System.Windows.Forms.Label textoDescriptivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonIniciar;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl moverFormuario;
    }
}

