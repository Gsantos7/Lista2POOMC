using System;

internal class Program
{
    static void Main(string[] args)
    {
        Quadrado area1;
        area1 = new Quadrado();

        Console.Write("Insira o Valor da aresta do quadrado: ");
        area1.setAresta(double.Parse(Console.ReadLine()));

        area1.calcular();

        Console.WriteLine("");

        Console.WriteLine("A Área do quadrado de aresta {0} é {1}",
            area1.getAresta(), area1.getArea());
    }
}

internal class Quadrado
{
    private double aresta;
    private double area;

    public Quadrado()
    {
        this.aresta = 0;
    }

    public Quadrado(double aresta)
    { 
        this.aresta = aresta;
    }
    public void setAresta(double aresta)
    {
        this.aresta = aresta;
    }

    public double getAresta()
    {
        return this.aresta;
    }

    public double getArea()
    {
        return this.area;
    }

    public void calcular()
    {
        this.area = this.aresta * this.aresta;
    }
}