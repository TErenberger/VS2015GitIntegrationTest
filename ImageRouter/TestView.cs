using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageRouter
{
    class TestView
    {
        public static void Main(String[] args)
        {
            ImageSet images = new ImageSet();
            images.GatherImages("D:\\");
            Console.ReadLine();
        }
    }
}
