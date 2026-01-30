using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class BizonyitekKezelo
	{
		private List<Bizonyitek> bizonyitekok;
		private Adattar adatBiz;
		private List<Bizonyitek> raktar;
		public BizonyitekKezelo(List<Bizonyitek> bizonyitekok)
		{
			this.bizonyitekok = bizonyitekok;
			this.raktar = new List<Bizonyitek>();
		}

		internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
		internal List<Bizonyitek> Raktar { get => raktar; set => raktar = value; }

		public void BizonyitekHozzaadasa(Bizonyitek b)
		{
			if (raktar.Contains(b)) { 
				bizonyitekok.Add(b);
				raktar.Remove(b);
			}
			else if (bizonyitekok.Contains(b)) {
				Console.WriteLine("Ez már benne van a bizonyítékokban!");
			}
			else
			{
				bizonyitekok.Add(b);
			}
			
		}

		public Bizonyitek BizonyitekTorlese(Bizonyitek b)
		{
			if (!bizonyitekok.Contains(b))
			{
				Console.WriteLine("Nincs ilyen bizonyítékok között!");
			}
			else
			{
				raktar.Add(b);
				bizonyitekok.Remove(b);
			}

			return b;
		}
	}
}
