
using System.Drawing;

Square square1 = new Square(5, "Зеленый");
square1.AreaOfTgeSquare(square1.SideLength);
square1.PrintInfoFigure();
Square square2 = new Square(2, "Синий");
square2.AreaOfTgeSquare(square2.SideLength);
square2.PrintInfoFigure();

Square square3 = new Square(15, "Голубой");
square3.AreaOfTgeSquare(square3.SideLength);
square3.PrintInfoFigure();

square1.SideLength = square2.SideLength * 3;
square1.AreaOfTgeSquare(square1.SideLength);
square1.PrintInfoFigure();

public class Square
{
    public int SideLength { get; set; }
    public string Color { get; set; }
    public double Area { get; set; }
    public Square(int sideLength, string color)
    {
        SideLength = sideLength;
        Color = color;
    }
    public void AreaOfTgeSquare(int sideLength)
    {
        Area = sideLength * sideLength;
    }
    public void PrintInfoFigure()
    {
        Console.WriteLine($"Длина фигуры: {SideLength},\nЦвет фигуры: {Color},\nПлощадь фигуры: {Area}");
    }

}