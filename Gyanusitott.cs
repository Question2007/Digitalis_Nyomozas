using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Gyanusitott
	{
		private Szemely gyanusitottSzemely;
		private int gyanusitottsagiSzint;
		private string statusz;

		public Gyanusitott(Szemely gyanusitottSzemely, int gyanusitottsagiSzint, string statusz)
		{
			this.gyanusitottSzemely = gyanusitottSzemely;
			this.gyanusitottsagiSzint = gyanusitottsagiSzint;
			this.statusz = statusz;
		}

		public int GyanusitottsagiSzint { get => gyanusitottsagiSzint; set => gyanusitottsagiSzint = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Szemely GyanusitottSzemely { get => gyanusitottSzemely; set => gyanusitottSzemely = value; }

		public override string ToString()
		{
			return $"Gyanusított személy: {this.gyanusitottSzemely} Gyanusítottsági szint: {this.gyanusitottsagiSzint} Státusz: {this.statusz}";
		}
	}
}
