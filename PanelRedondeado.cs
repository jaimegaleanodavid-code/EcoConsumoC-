using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class PanelRedondeado : Panel
{
    // Propiedades personalizables desde el Diseñador de Visual Studio
    public int RadioBorde { get; set; } = 20;
    public Color ColorBorde { get; set; } = Color.Transparent;
    public int GrosorBorde { get; set; } = 1;

    public PanelRedondeado()
    {
        this.DoubleBuffered = true; // Evita el parpadeo visual al redimensionar
        this.DoubleBuffered = true;

        // ESTA LÍNEA PERMITE SOPORTAR TRANSPARENCIA Y COLORES TRANSLÚCIDOS
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

        // Color predeterminado semi-transparente opcional
        this.BackColor = Color.FromArgb(100, 0, 0, 0);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Crear la ruta con las esquinas redondeadas
        using (GraphicsPath path = ObtenerRutaRedondeada(this.ClientRectangle, RadioBorde))
        {
            // Asignar la región gráfica al panel para recortar su contenido
            this.Region = new Region(path);

            // Dibujar el borde si se especificó un color diferente a Transparent
            if (ColorBorde != Color.Transparent && GrosorBorde > 0)
            {
                using (Pen pen = new Pen(ColorBorde, GrosorBorde))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }

    private GraphicsPath ObtenerRutaRedondeada(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = radius * 2;

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Esquina superior izquierda
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Esquina superior derecha
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Esquina inferior derecha
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Esquina inferior izquierda
        path.CloseFigure();

        return path;
    }
}