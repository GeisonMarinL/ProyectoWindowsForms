using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaCulturaGeneral
{
    public partial class FormularioRCorrecta : Form
    {
        public FormularioRCorrecta()
        {
            InitializeComponent();
            reproducirSonido();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public void reproducirSonido()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.correcto);
            player.Play();
        }
    }
}
