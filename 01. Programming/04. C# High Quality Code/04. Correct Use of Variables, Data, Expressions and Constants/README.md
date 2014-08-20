#Correct Use of Variables, Data, Expressions and Constants

**Exercises:**

1. Refactor the following code to use proper variable naming and simplified expressions:
```cs
public class Size
{
  public double wIdTh, Viso4ina;
  public Size(double w, double h)
  {
    this.wIdTh = w;
    this.Viso4ina = h;
  }
}

public static Size GetRotatedSize(
  Size s, double angleOfTheFigureThatWillBeRotaed)
{
  return new Size(
    Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
      Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina,
    Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.wIdTh + 
      Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.Viso4ina);
}

```
