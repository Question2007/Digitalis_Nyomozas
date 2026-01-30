using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class UgyKezelo
	{
		private List<Ugy> ugyek;

		public UgyKezelo(List<Ugy> ugyek)
		{
			this.ugyek = new List<Ugy>();
		}

		internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }

		public void UjUgyLetrehozasa(Ugy u)
		{
			ugyek.Add(u);
		}

		public void UgyekListazasa() 
		{
			foreach (var item in ugyek)
			{
				Console.WriteLine(item);
			}
		}
	}
}
