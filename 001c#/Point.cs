using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
		 private int x;
         private int y;

        // аксессоры propfull
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
		{
			get { return y; }
			set { y = value; }
		}
        
    }
}
