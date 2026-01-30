using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Donteshozo
	{
		public Donteshozo(Gyanusitott gy, Bizonyitek b) {
			if (b.MegbizhatosagiErtek >= 3)
			{
				gy.GyanusitottsagiSzint += 10;
			}
			if (gy.GyanusitottsagiSzint >= 75)
			{
				Console.WriteLine("Figyelem elértél egy Gyanusítottsági szint küszöbértéket!!!");
			}
		}
	}
}
