using System;

namespace Method_hiding
{
    public class Employ
    {
        public string first;
        public string last;
        public void printfull()
        {
            Console.WriteLine(first + " " + last);
        }
    }
    public class parttime : Employ
    {
        public new void printfull()
        {
            base.printfull();
        }
    }
    public class FullTime :Employ
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTime ft = new FullTime();
            ft.first = "FullTime";
            ft.last = "Employ";
            ft.printfull();

            parttime pt = new Employ();
            pt.first = "FullTime";
            pt.last = "Employ";
            pt.printfull();
        }
    }
}
