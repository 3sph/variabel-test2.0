namespace variabel_test2._0
{
    internal class Program
    {
        //private static object Console;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = "Espen";
            Console.WriteLine($"mitt navn er {name}");
            int age = 30;
            char forbokstav = 'E';
            Console.WriteLine($"Første bokstaven i mitt navn er {forbokstav}");
            Console.WriteLine($"jeg er {age} år gammel");
            double høyde = 1.81;
            Console.WriteLine($"jeg er {høyde} cm");
            float pi = 3.14F;
            Console.WriteLine("pi =" + pi);
            bool truePi = true;
            Console.WriteLine(truePi);
            decimal pi2 = 3.14159M;
            Console.WriteLine($" ett høyere tall for pi er {pi2}");
            long timeWasted = 946707779;
            Console.WriteLine($"mitt liv i sekunder er {timeWasted} sekunder");


            int a = 5;
            decimal b = 3.0M;
            decimal result = a + b;
            Console.WriteLine($"resultatet av stykket i oppgave 2 blir: {result}");
        }
      
                    }


        
    }
