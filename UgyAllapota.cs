using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class UgyAllapota
	{
		private string aktualisStatusz;

		public UgyAllapota(string aktualisStatusz)
		{
			this.aktualisStatusz = aktualisStatusz;
		}

		public string AktualisStatusz { get => aktualisStatusz; set => aktualisStatusz = value; }

		public void AllapotValtoztatas(string allapot)
		{
			this.aktualisStatusz = allapot;
		}
	} 
}
