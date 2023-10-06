namespace TriviaCulturaGeneral
{
    partial class FormularioPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPreguntas));
            this.botonCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPregunta1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRespuesta3 = new System.Windows.Forms.Button();
            this.btnRespuesta1 = new System.Windows.Forms.Button();
            this.btnRespuesta2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panelPregunta1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCerrar
            // 
            this.botonCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.botonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCerrar.Location = new System.Drawing.Point(594, 0);
            this.botonCerrar.Name = "botonCerrar";
            this.botonCerrar.Size = new System.Drawing.Size(40, 40);
            this.botonCerrar.TabIndex = 0;
            this.botonCerrar.Text = "X";
            this.botonCerrar.UseVisualStyleBackColor = false;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 40);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.botonCerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 40);
            this.panel2.TabIndex = 7;
            // 
            // panelPregunta1
            // 
            this.panelPregunta1.Controls.Add(this.pictureBox1);
            this.panelPregunta1.Controls.Add(this.btnRespuesta3);
            this.panelPregunta1.Controls.Add(this.btnRespuesta1);
            this.panelPregunta1.Controls.Add(this.btnRespuesta2);
            this.panelPregunta1.Controls.Add(this.label1);
            this.panelPregunta1.Location = new System.Drawing.Point(12, 55);
            this.panelPregunta1.Name = "panelPregunta1";
            this.panelPregunta1.Size = new System.Drawing.Size(610, 300);
            this.panelPregunta1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "¿Quién es el autor de la pintura \"La Mona Lisa\"?";
            // 
            // btnRespuesta3
            // 
            this.btnRespuesta3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta3.Location = new System.Drawing.Point(436, 249);
            this.btnRespuesta3.Name = "btnRespuesta3";
            this.btnRespuesta3.Size = new System.Drawing.Size(75, 38);
            this.btnRespuesta3.TabIndex = 17;
            this.btnRespuesta3.Text = "Rafael";
            this.btnRespuesta3.UseVisualStyleBackColor = true;
            this.btnRespuesta3.Click += new System.EventHandler(this.btnRespuesta3_Click);
            // 
            // btnRespuesta1
            // 
            this.btnRespuesta1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta1.Location = new System.Drawing.Point(103, 249);
            this.btnRespuesta1.Name = "btnRespuesta1";
            this.btnRespuesta1.Size = new System.Drawing.Size(148, 38);
            this.btnRespuesta1.TabIndex = 16;
            this.btnRespuesta1.Text = "Leonardo da Vinci";
            this.btnRespuesta1.UseVisualStyleBackColor = true;
            this.btnRespuesta1.Click += new System.EventHandler(this.btnRespuesta1_Click);
            // 
            // btnRespuesta2
            // 
            this.btnRespuesta2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta2.Location = new System.Drawing.Point(286, 249);
            this.btnRespuesta2.Name = "btnRespuesta2";
            this.btnRespuesta2.Size = new System.Drawing.Size(112, 38);
            this.btnRespuesta2.TabIndex = 15;
            this.btnRespuesta2.Text = "Miguel Ángel";
            this.btnRespuesta2.UseVisualStyleBackColor = true;
            this.btnRespuesta2.Click += new System.EventHandler(this.btnRespuesta2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.panelPregunta1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioPreguntas";
            this.Text = "FormularioPreguntas";
            this.panel2.ResumeLayout(false);
            this.panelPregunta1.ResumeLayout(false);
            this.panelPregunta1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelPregunta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRespuesta3;
        private System.Windows.Forms.Button btnRespuesta1;
        private System.Windows.Forms.Button btnRespuesta2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}