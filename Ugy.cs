using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Ugy
	{
		private string ugyAzonosito;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Szemely> hozzaTartozoSzemelyek;
		private List<Bizonyitek> hozzaTartozoBizonyitekok;

		public Ugy()
		{
			this.ugyAzonosito = "";
			this.cim = "";
			this.leiras = "";
			this.allapot = "";
			this.hozzaTartozoSzemelyek = new List<Szemely>();
			this.hozzaTartozoBizonyitekok = new List<Bizonyitek>();
		}

		public Ugy(string ugyAzonosito, string cim, string leiras, string allapot)
		{
			this.ugyAzonosito = ugyAzonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.hozzaTartozoSzemelyek = new List<Szemely>();
			this.hozzaTartozoBizonyitekok = new List<Bizonyitek>();
		}

		public string UgyAzonosito { get => ugyAzonosito; set => ugyAzonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal List<Szemely> HozzaTartozoSzemelyek { get => hozzaTartozoSzemelyek; set => hozzaTartozoSzemelyek = value; }
		internal List<Bizonyitek> HozzaTartozoBizonyitekok { get => hozzaTartozoBizonyitekok; set => hozzaTartozoBizonyitekok = value; }


		public void HozzatartozoFelvetel(Szemely sz)
		{
			this.hozzaTartozoSzemelyek.Add(sz);
		}

		public void BizonyitekFelvetel(Bizonyitek b)
		{
			this.hozzaTartozoBizonyitekok.Add(b);
		}

		public void AllapotValtozas(string ujAllapot)
		{
			this.allapot = ujAllapot;
			Console.WriteLine("Az ügy állapota frissült");
		}
		public override string ToString()
		{
			return $"Ügy azonosító: {this.ugyAzonosito} Cím: {this.cim} Leírás: {this.leiras} Állapot: {this.allapot} Hozzá tartozó személyek: {this.hozzaTartozoSzemelyek} Hozzá tartozó bizonyítékok: {this.HozzaTartozoBizonyitekok}";
		}
	}
}
