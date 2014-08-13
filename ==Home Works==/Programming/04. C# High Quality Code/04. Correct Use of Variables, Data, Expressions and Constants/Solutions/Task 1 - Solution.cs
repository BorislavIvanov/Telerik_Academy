using System;

public class Size
{
    public Size(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Width { get; set; }
    public double Height { get; set; }

    public static Size GetRotatedSize(Size s, double angleOfFigure)
    {
        double newWidth = Math.Abs(Math.Cos(angleOfFigure)) * s.Width + Math.Abs(Math.Sin(angleOfFigure)) * s.Height;
        double newHeight = Math.Abs(Math.Sin(angleOfFigure)) * s.Width + Math.Abs(Math.Cos(angleOfFigure)) * s.Height;

        return new Size(newWidth, newHeight);
    }
}


