using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace assignment1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            point P1 = new point(5,7);
            point P2 = new point(2,5);

            if (P1.x > P2.x)
            {
                Console.WriteLine("P2 is to the right of P1");
            }
            else if (P1.x < P2.x)
            {
                Console.WriteLine("P2 is to the left of P1");
            }
            else
            {
                Console.WriteLine("P2 is on the same axis");
            }
        }
    }

    public class point
    {
        public point(double xCord, double yCord)
        {
            x = xCord;
            y = yCord;
        }
        public point()
        {
            x = 0;
            y = 0;
        }

        public double x;
        public double y;
    }
}

