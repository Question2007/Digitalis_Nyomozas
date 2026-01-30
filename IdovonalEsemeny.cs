using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class IdovonalEsemeny
	{
		private DateTime datum;
		private string esemenyLeiras;

		public IdovonalEsemeny(DateTime datum, string esemenyLeiras)
		{
			this.datum = datum;
			this.esemenyLeiras = esemenyLeiras;
		}

		public DateTime Datum { get => datum; set => datum = value; }
		public string EsemenyLeiras { get => esemenyLeiras; set => esemenyLeiras = value; }

		public override string ToString() {
			return $"Dátum: {this.datum} Esemény leírás: {this.esemenyLeiras}";
		}
	}
}
