using System;

namespace Solid3
{
    // Неправильний результат спричинений порушенням принципу заміни Ліскова (LSP) з принципів S.O.L.I.D.
    /*У цьому прикладі: клас Square некоректно змодельовано як підклас класу Rectangle. 
     * У класі Square виконується інваріант, що ширина == висота. Однак, базовий клас Rectangle цього не робить. 
     * Коли екземпляр Square розглядається як Rectangle (як у рядку Rectangle rect = new Square();), 
     * програма порушує очікувану поведінку Rectangle.
     */
    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int GetArea()
        {
            return Width * Height;
        }
    }

    class Square : Shape
    {
        public int Side { get; set; }

        public override int GetArea()
        {
            return Side * Side;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle
            {
                Width = 5,
                Height = 10
            };
            Console.WriteLine($"Rectangle Area: {rect.GetArea()}"); 

            Square square = new Square
            {
                Side = 5
            };
            Console.WriteLine($"Square Area: {square.GetArea()}"); 

            Console.ReadKey();
        }
    }
}
