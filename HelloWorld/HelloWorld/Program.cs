// See https://aka.ms/new-console-template for more information
namespace Demo
{
    class Data
    {
        public void Shaon()
        {
            Console.WriteLine("Hi!! This is Shaon..");
        }

        internal void Shahrin()
        {
            Console.WriteLine("Hi!!! This is Shahrin...");
        }
        private void Shinorina()
        {
            Console.WriteLine("Hi!!! This is Shinorina...");
        }

    }
    class Program
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum of {0} and {1} is {2}.",a,b,c);

        }
        public void Radius(double radius)
        {
            double circle, area;
            circle = Math.PI * radius * radius;
            area = Math.Sqrt(circle);
            Console.WriteLine("The circle is:" + circle);
            Console.WriteLine("The area is:" + area);
        }
        public void Temperature(double c)
        {
            double f = ((9 * c) / 5) + 32;
            Console.WriteLine("Tempertaure in F is:"+f);
        }
        static void Main(string[] args)
        {
            Data obj = new Data();
            obj.Shaon();
            obj.Shahrin();

            string name;
            Console.WriteLine("Enter your after name: ");
            name = Console.ReadLine();
            Console.WriteLine("Ater name is " + name);
            Console.WriteLine("Enter your first name: ");
            name = Console.ReadLine();
            Console.WriteLine("First name is {0}", name);

            int a, b;
            Console.WriteLine("Enter 2 numbers:");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            Program obj1 = new Program();
            obj1.Add(a, b);

            double radius;
            Console.WriteLine("Enter the radius:");
            radius = Convert.ToDouble(Console.ReadLine());
            obj1.Radius(radius);

            double c;
            Console.WriteLine("Enter C:");
            c = Convert.ToDouble(Console.ReadLine());
            obj1.Temperature(c);
                
        }
    }
}
