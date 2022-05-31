using System;
using static System.Console;
namespace P01_Concept
{
    public sealed class Singleton
    {
        private Singleton() { }
        static readonly Singleton _instance = new Singleton();
        public static Singleton Instance => _instance;
        private int _count = 0;
        public void Increase() => _count++;
        public int Count => _count;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Title = "SINGLETON DESIGN PATTERN";
            WriteLine($"Start: {Singleton.Instance.Count}");
            Singleton.Instance.Increase();
            WriteLine($"First increment: {Singleton.Instance.Count}");
            Singleton.Instance.Increase();
            WriteLine($"Second increment: {Singleton.Instance.Count}");
            Singleton.Instance.Increase();
            WriteLine($"Third increment : {Singleton.Instance.Count}");
            ReadKey();
        }
    }
}