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
    public partial class FormularioRIncorrecta : Form
    {
        public FormularioRIncorrecta()
        {
            InitializeComponent();
            reproducirSonido();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        public void reproducirSonido()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Incorrecto);
            player.Play();
        }
    }
}
