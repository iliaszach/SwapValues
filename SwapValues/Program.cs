using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapValues
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public class Swapper
    {
        public object[] Arguments { get; private set; }

        public Swapper(object[] args)
        {
            if (args.Length != 2)
            {
                throw new ArgumentException();
            }
            Arguments = args;
        }

        public void SwapValues()
        {
            object[] args = new[] { Arguments[0], Arguments[1] };

            object temp = args[0];
            args[0] = args[1];
            args[1] = temp;
            Arguments = args;
        }
    }
}
