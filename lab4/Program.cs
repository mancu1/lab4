﻿/*
 Порядок выполнения работы:
1) Разработать методы и свойства для каждого из определяемых
классов.
2) Реализовать программу на C# в соответствии с вариантом
исполнения.
3) Подготовить отчет в твердой копии и в электронном виде.
 
Построить иерархию классов в соответствии с вариантом задания
9) Игрушка, продукт, товар, молочный продукт

*/

namespace lab4
{
    public class Tovar
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Tovar(string name, double price)
        {
            Name = name;
            Price = price;
        }
        
        public void Print()
        {
            Console.WriteLine("Name: {0}, Price: {1}", Name, Price);
        }
    }
    
    public class Product : Tovar
    {
        public double Kcal { get; set; }
        public Product(string name, double price, double kcal) : base(name, price)
        {
            Kcal = kcal;
        }
        
        public void Print()
        {
            Console.WriteLine("Name: {0}, Price: {1}, Kcal: {2}", Name, Price, Kcal);
        }
    }
    
    public class MilkProduct : Product
    {
        public string Jirnost { get; set; }
        public MilkProduct(string name, double price, double kcal, string jirnost) : base(name, price, kcal)
        {
            Jirnost = jirnost;
        }
        
        public void Print()
        {
            Console.WriteLine("Name: {0}, Price: {1}, Kcal: {2}, Jirnost: {3}", Name, Price, Kcal, Jirnost);
        }
    }
    
    public class Toy : Tovar
    {
        public string Age { get; set; }
        public Toy(string name, double price, string age) : base(name, price)
        {
            Age = age;
        }
        
        public void Print()
        {
            Console.WriteLine("Name: {0}, Price: {1}, Age: {2}", Name, Price, Age);
        }
    }
    
    
    public static class Program
    {
        public static void Main(string[] args)
        {
            Tovar tovar = new Tovar("Tovar", 100);
            tovar.Print();
            
            Product product = new Product("Product", 200, 100);
            product.Print();
            
            MilkProduct milkProduct = new MilkProduct("MilkProduct", 300, 100, "5%");
            milkProduct.Print();
            
            Toy toy = new Toy("Toy", 400, "12");
            toy.Print();
        }
    }
}