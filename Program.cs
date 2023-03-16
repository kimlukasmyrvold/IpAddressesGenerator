using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace IpGenerator
{
    internal class Program
    {
        public static void GenerateIpAddresses()
        {
            for (int a = 0; a <= 255; a++)
            {
                for (int b = 0; b <= 255; b++)
                {
                    for (int c = 0; c <= 255; c++)
                    {
                        for (int d = 0; d <= 255; d++)
                        {
                            Console.WriteLine($"{a}.{b}.{c}.{d}");
                        }
                    }
                }
            }
        }

        static void Main(string[] args) {
            Program.GenerateIpAddresses();
        }
    }
}