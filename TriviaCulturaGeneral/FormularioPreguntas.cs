using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaCulturaGeneral
{
    public partial class FormularioPreguntas : Form
    {
        public FormularioPreguntas()
        {
            InitializeComponent();
        }

        void respuestaIncorrecta()
        {
            FormularioRIncorrecta formularioRIncorrecta = new FormularioRIncorrecta();
            formularioRIncorrecta.ShowDialog(); 
        }

        void respuestaCorrecta()
        {
            FormularioRCorrecta formularioRCorrecta = new FormularioRCorrecta();
            formularioRCorrecta.ShowDialog();   
        }



        private void botonCerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRespuesta1_Click(object sender, EventArgs e)
        {
            respuestaCorrecta();
            panelPregunta1.Show();
           
        }

        private void btnRespuesta2_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
        }

        private void btnRespuesta3_Click(object sender, EventArgs e)
        {
            respuestaIncorrecta();
            
        }
    }    
}
