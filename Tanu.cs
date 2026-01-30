using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Tanu
	{
		private Szemely tanusitottSzemely;
		private string vallomasSzovege;
		private DateTime vallomasDatuma;

		public Tanu(Szemely tanusitottSzemely, string vallomasSzovege, DateTime vallomasDatuma)
		{
			this.tanusitottSzemely = tanusitottSzemely;
			this.vallomasSzovege = vallomasSzovege;
			this.vallomasDatuma = vallomasDatuma;
		}

		public string VallomasSzovege { get => vallomasSzovege; set => vallomasSzovege = value; }
		public DateTime VallomasDatuma { get => vallomasDatuma; set => vallomasDatuma = value; }
		internal Szemely TanusitottSzemely { get => tanusitottSzemely; set => tanusitottSzemely = value; }

		public override string ToString()
		{
			return $"Tanu: {this.tanusitottSzemely} Vallomás: {this.vallomasSzovege} Dátum: {this.vallomasDatuma}";
		}
	}
}
