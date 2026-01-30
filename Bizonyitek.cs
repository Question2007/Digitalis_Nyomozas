using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Bizonyitek
	{
		private string azonosito;
		private string tipus;
		private string leiras;
		private int megbizhatosagiErtek;

		public Bizonyitek(string azonosito, string tipus, string leiras, int megbizhatosagiErtek)
		{
			this.azonosito = azonosito;
			this.tipus = tipus;
			this.leiras = leiras;
			this.megbizhatosagiErtek = megbizhatosagiErtek;
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public int MegbizhatosagiErtek { get => megbizhatosagiErtek; set => megbizhatosagiErtek = value; }

		public override string ToString()
		{
			return $"Azonosító: {this.azonosito} Típus: {this.tipus} Leírás: {this.leiras} Megbízhatósági érték: {this.megbizhatosagiErtek}";
		}
	}
}
