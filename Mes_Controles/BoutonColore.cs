using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Mes_Controles

    [ToolboxBitmap(typeof(BoutonColore), "BoutonColore.bmp")]
{
    public class BoutonColore: Button
    {
        private Color cGouche;
        private Color cDroite;

        private int tGouche;
        private int tDroite;

        public BoutonColore()
        {
           cGouche=Color.Blue;
              cDroite=Color.Red;
            tGouche = 200;
            tDroite = 200;
        }

        [Category("Appearance BoutonColore ")]
        [Description("Couleur de gauche du dégradé")]
        public Color CGauche
        {
            get { return cGouche; }
            set { cGouche = value; Invalidate(); }
        }

        [Category("Appearance BoutonColore ")]
        [Description("Couleur de droite du dégradé")]
        public Color CDroite
        {
            get { return cDroite; }
            set { cDroite = value; Invalidate(); }
        }

        [Category("Appearance BoutonColore ")]
        [Description("Transparence gauche(0-255)")]
        public int TGauche
        {
            get { return tGouche; }
            set { if (value >= 0 && value <= 255) { tGouche = value; Invalidate(); } }
        }

        [Category("Appearance BoutonColore ")]
        [Description("Transparence droite(0-255)")]
        public int TDroite
        {
            get { return tDroite; }
            set { if (value >= 0 && value <= 255) { tDroite = value; Invalidate(); } }
        }







    }
}
