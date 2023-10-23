using System;

   internal class Program
   {
       static void Main(string[] args)
       {
           Quadrado area1;
           area1 = new Quadrado();

           Console.Write("Insira o Valor da diagonal do quadrado: ");
           area1.setDiagonal(double.Parse(Console.ReadLine()));

           area1.calcular();

           Console.WriteLine("");

           Console.WriteLine("A área do quadrado de diagonal {0} é {1}", area1.getDiagonal(), area1.getArea());
       }
   }

  internal class Quadrado
  {
      private double diagonal;
      private double area;

      public Quadrado()
      {
          this.diagonal = 0;
      }

      public Quadrado (double diagonal)
      { 
          this.diagonal = diagonal;
      }

      public void setDiagonal(double diagonal)
      {
          this.diagonal = diagonal;
      }

      public double getDiagonal()
      {
          return this.diagonal;
      }

      public double getArea()
      {
          return this.area;
      }

      public void calcular()
      {

          this.area = Math.Pow(this.diagonal / Math.Sqrt(2), 2);

      }

  }