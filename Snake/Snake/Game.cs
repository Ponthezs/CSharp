using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    internal class Game
    {
        public Keys Direction { get; set; }

        public Keys Arrow { get; set; }

        private Timer Frame { get; set; }
        private Label LbPontuacao { get; set; }
        private Panel PnTela { get; set; }

        private int pontos = 0;

        private food food;

        private snake Snake;

        private Bitmap offScreenBitmap;
        private Graphics bitmapGraph;
    }
}
