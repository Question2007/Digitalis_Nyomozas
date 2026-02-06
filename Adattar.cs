using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Adattar
	{
		private List<Felhasznalo> felhasznalokLista;
		private List<Ugy> ugyekLista;
		private List<Szemely> szemelyekLista;
		private List<Bizonyitek> bizonyitekLista;

		public Adattar(List<Felhasznalo> felhasznalokLista, List<Ugy> ugyekLista, List<Szemely> szemelyekLista, List<Bizonyitek> bizonyitekLista)
		{
			this.felhasznalokLista = felhasznalokLista;
			this.ugyekLista = ugyekLista;
			this.szemelyekLista = szemelyekLista;
			this.bizonyitekLista = bizonyitekLista;
		}

		internal List<Felhasznalo> FelhasznalokLista { get => felhasznalokLista; set => felhasznalokLista = value; }
		internal List<Ugy> UgyekLista { get => ugyekLista; set => ugyekLista = value; }
		internal List<Szemely> SzemelyekLista { get => szemelyekLista; set => szemelyekLista = value; }
		internal List<Bizonyitek> BizonyitekLista { get => bizonyitekLista; set => bizonyitekLista = value; }

		public void ListazasUgyek()
		{
			int i = 1;
			foreach(var item in this.UgyekLista)
			{
				Console.WriteLine(i + ". :" + item);
				i++;
			}
		}

	}
}
