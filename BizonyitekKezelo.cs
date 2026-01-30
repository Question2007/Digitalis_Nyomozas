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

		public BizonyitekKezelo(List<Bizonyitek> bizonyitekok)
		{
			this.bizonyitekok = new List<Bizonyitek>();
		}

		internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }

		public void BizonyitekHozzaadasa(Bizonyitek b)
		{
			bizonyitekok.Add(b);
		}

		public void BizonyitekTorlese(Bizonyitek b)
		{
			bizonyitekok.Remove(b);
		}
	}
}
