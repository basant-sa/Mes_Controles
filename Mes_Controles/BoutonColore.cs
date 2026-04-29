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
            set { if (value >= 0 && value <= 255) { tDroite = value; Invalidate();  } }
        }



        protected override void OnPaint(PaintEventArgs e)
        {
             
            Bitmap bmp = new Bitmap(this.Width, this.Height);

             
            Graphics g = Graphics.FromImage(bmp);
         
            Color colorGauche = Color.FromArgb(tGauche, cGauche);
            Color colorDroite = Color.FromArgb(tDroite, cDroite);

           
            LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, this.Height),   
                colorGauche,    
                colorDroite,     
                LinearGradientMode.Horizontal  
            );

            g.FillRectangle(brush, 0, 0, this.Width, this.Height);
            SizeF textSize = g.MeasureString(this.Text, this.Font);

            float x = (this.Width - textSize.Width) / 2;
            float y = (this.Height - textSize.Height) / 2;

            g.DrawString(
                this.Text,             
                this.Font,              
                Brushes.White,          
                x, y                    
            );

            e.Graphics.DrawImage(bmp, 0, 0);

            g.Dispose();
            bmp.Dispose();
            brush.Dispose();

            base.OnPaint(e);
        }






     
    }   
}
