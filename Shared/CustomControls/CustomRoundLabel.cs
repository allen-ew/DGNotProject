using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.Shared.CustomControls
{
    public class CustomRoundLabel : Control
    {
        #region Constructor
        public CustomRoundLabel()
        {
            this.AutoSize = true;
            this.Size = new System.Drawing.Size(24, 24);
        }
        #endregion
        #region Private Methods
        private void UpdateVisibility()
        {
            this.Visible = !string.IsNullOrEmpty(this.Text) && int.TryParse(this.Text, out _) && int.Parse(this.Text) > 0;
        }
        #endregion
        #region Overriden Methods

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Suavizar los bordes

            // Dibujar el círculo rojo y el texto solo si hay notificaciones
            if (!string.IsNullOrEmpty(this.Text) && int.TryParse(this.Text, out int count) && count > 0)
            {
                using (Brush brush = new SolidBrush(Color.Red))
                {
                    g.FillEllipse(brush, 1, 1, Width - 2, Height - 2); // Dibuja el círculo con un pequeño margen
                }

                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    Font drawFont = new Font("Arial", 12, FontStyle.Bold); // Ajusta el tamaño de la fuente
                    SizeF textSize = g.MeasureString(this.Text, drawFont);
                    PointF textLocation = new PointF((Width - textSize.Width) / 2, (Height - textSize.Height) / 2);
                    g.DrawString(this.Text, drawFont, textBrush, textLocation);
                }
            }
        }
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                UpdateVisibility(); // Actualizar la visibilidad del control
                Invalidate(); // Forzar un redibujo del control
            }
        }
        #endregion
    }
}
