using System;

namespace Solid4
{
    // Щоб вирішити описану проблему, ми можемо застосувати принцип сегрегації інтерфейсів (ISP), 
    // розбивши інтерфейс IItem на менші, більш сфокусовані інтерфейси.
    interface IPriceable
    {
        void SetPrice(double price);
    }

    interface IDiscountable
    {
        void ApplyDiscount(string discount);
        void ApplyPromocode(string promocode);
    }

    interface IColorable
    {
        void SetColor(byte color);
    }

    interface ISizable
    {
        void SetSize(byte size);
    }

    class Book : IPriceable, IDiscountable
    {
        private double _price;
        private string _currentDiscount;
        private string _currentPromocode;

        public void SetPrice(double price)
        {
            _price = price;
            Console.WriteLine($"Book price set to: {price:C}");
        }

        public void ApplyDiscount(string discount)
        {
            _currentDiscount = discount;
            Console.WriteLine($"Discount applied to book: {discount}");
        }

        public void ApplyPromocode(string promocode)
        {
            _currentPromocode = promocode;
            Console.WriteLine($"Promocode applied to book: {promocode}");
        }
    }

    class Outerwear : IPriceable, IDiscountable, IColorable, ISizable
    {
        private double _price;
        private string _currentDiscount;
        private string _currentPromocode;
        private byte _color;
        private byte _size;

        public void SetPrice(double price)
        {
            _price = price;
            Console.WriteLine($"Outerwear price set to: {price:C}");
        }

        public void ApplyDiscount(string discount)
        {
            _currentDiscount = discount;
            Console.WriteLine($"Discount applied to outerwear: {discount}");
        }

        public void ApplyPromocode(string promocode)
        {
            _currentPromocode = promocode;
            Console.WriteLine($"Promocode applied to outerwear: {promocode}");
        }

        public void SetColor(byte color)
        {
            _color = color;
            Console.WriteLine($"Outerwear color set to: {color}");
        }

        public void SetSize(byte size)
        {
            _size = size;
            Console.WriteLine($"Outerwear size set to: {size}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.SetPrice(19.99);
            myBook.ApplyDiscount("10% off");
            myBook.ApplyPromocode("BOOK10");

            Outerwear myJacket = new Outerwear();
            myJacket.SetPrice(79.99);
            myJacket.ApplyDiscount("20% off");
            myJacket.ApplyPromocode("WINTER20");
            myJacket.SetColor(5); // Припустимо, що 5 - це код для «Синього»
            myJacket.SetSize(2);  // Припустимо, що 2 - це код для «Середній»

            Console.ReadKey();
        }
    }
}
