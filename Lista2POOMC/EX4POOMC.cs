using System;

internal class Program
{
    static void Main(string[] args)
    {
        Triangulo area1;
        area1 = new Triangulo();

        Console.Write("Insira o Valor da base do triângulo: ");
        area1.setB(double.Parse(Console.ReadLine()));

        Console.Write("Insira o Valor da altura do triângulo: ");
        area1.setH(double.Parse(Console.ReadLine()));

        area1.calcular();

        Console.WriteLine("");

        Console.WriteLine("A Área do triângulo de base {0} e altura {1} é {2}",
            area1.getB(), area1.getH(), area1.getArea());
    }
}

internal class Triangulo
{
    private double b;
    private double h;
    private double area;

    public Triangulo()
    {
        this.b = 0;
        this.h = 0;
    }

    public Triangulo(double b, double h)
    { 
        this.b = b;
        this.h = h;
    }

    public void setB(double b)
    {
        this.b = b;
    }
    public void setH(double h)
    {
        this.h = h;
    }
    public double getB()
    {
        return this.b;
    }
    public double getH()
    {
        return this.h;
    }

    public double getArea()
    {
        return this.area;
    }
    public void calcular()
    {
        this.area = (this.b * this.h)/2;
    }
}