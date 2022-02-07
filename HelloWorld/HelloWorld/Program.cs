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
        public void Condition(int a, int b, int c)
        {
            int m = a;
            if (m < b)
            {
                m = b;
            }
            if(m <c)
            {
                m = c;
            }
            Console.WriteLine("The output is: "+m);

        }
        public void Loop(int n)
        {
            int i = 0;
            while (i <= n)
            {
                Console.WriteLine("The number is: "+i);
                i++;
            }
        }
        public void Factorial(int f)
        {
            for (int i = 1; i <= f; i++)
            {
                if (f % i == 0)
                {
                    Console.WriteLine("The factorial is: " + i);
                }
            }
        }
        public void Check(int bo)
        {
            bool flag = false;
            for (int i=2;i<bo;i++)
            {
                if(bo % i == 0)
                {
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
        }
        public void Show()
        {
            int[] ar = new int[] {10,20,30,40,50};
            for(int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]+" ");
            }
            Console.WriteLine();

            string[] ar1 = new string[] { "Shinorina", "Shahrin", "Shaon", "Ishabela" };
            foreach(string s in ar1)
            {
                Console.WriteLine(s);
            }
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

            int x,y,z;
            Console.WriteLine("Enter 3 number.");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            obj1.Condition(x,y,z);

            int n;
            Console.WriteLine("Enter number: ");
            n = Convert.ToInt32(Console.ReadLine());
            obj1.Loop(n);

            int f;
            Console.WriteLine("Enter the number for factorial: ");
            f = Convert.ToInt32(Console.ReadLine());
            obj1.Factorial(f);

            int bo;
            Console.WriteLine("Enter the boolen value: ");
            bo = Convert.ToInt32(Console.ReadLine());
            obj1.Check(bo);

            obj1.Show();
                
        }
    }
}
