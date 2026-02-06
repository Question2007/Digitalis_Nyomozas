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
		private List<Gyanusitott> gyanusitottLista;
		private List<Tanu> tanukLista;
		private List<IdovonalEsemeny> idovonalEsemenyLista;

		public Adattar(List<Felhasznalo> felhasznalokLista, List<Ugy> ugyekLista, List<Szemely> szemelyekLista, List<Bizonyitek> bizonyitekLista, List<Gyanusitott> gyanusitottLista, List<Tanu> tanukLista, List<IdovonalEsemeny> idovonalEsemenyLista)
		{
			this.felhasznalokLista = felhasznalokLista;
			this.ugyekLista = ugyekLista;
			this.szemelyekLista = szemelyekLista;
			this.bizonyitekLista = bizonyitekLista;
			this.gyanusitottLista = gyanusitottLista;
			this.tanukLista = tanukLista;
			this.idovonalEsemenyLista = idovonalEsemenyLista;
		}

		internal List<Felhasznalo> FelhasznalokLista { get => felhasznalokLista; set => felhasznalokLista = value; }
		internal List<Ugy> UgyekLista { get => ugyekLista; set => ugyekLista = value; }
		internal List<Szemely> SzemelyekLista { get => szemelyekLista; set => szemelyekLista = value; }
		internal List<Bizonyitek> BizonyitekLista { get => bizonyitekLista; set => bizonyitekLista = value; }
		internal List<Gyanusitott> GyanusitottLista { get => gyanusitottLista; set => gyanusitottLista = value; }

		internal List<Tanu> TanukLista { get => tanukLista; set => tanukLista = value; }
		internal List<IdovonalEsemeny> IdovonalEsemenyLista { get => idovonalEsemenyLista; set => idovonalEsemenyLista = value; }

		public void ListazasUgyek()
		{
			int i = 1;
			foreach(var item in this.UgyekLista)
			{
				Console.WriteLine(i + ". :" + item);
				i++;
			}
		}

		public void ListazasSzemelyek()
		{
			int i = 1;
			foreach (var item in this.SzemelyekLista)
			{
				Console.WriteLine(i + ". :" + item);
				i++;
			}
		}

		public void ListazasFelhasznalok()
		{
			int i = 1;
			foreach (var item in this.FelhasznalokLista)
			{
				Console.WriteLine(i + ". :" + item);
				i++;
			}
		}

		public void ListazasBizonyitekok()
		{
			int i = 1;
			foreach (var item in this.BizonyitekLista)
			{
				Console.WriteLine(i + ". :" + item);
				i++;
			}
		}

		public void ListazasGyanusitottak()
		{
			int i = 1;
			foreach (var item in this.GyanusitottLista)
			{
				Console.WriteLine(i + ". :" + item);
				i++;
			}
		}

		public void ListazasTanuk()
		{
			int i = 1;
			foreach (var item in this.TanukLista)
			{
				Console.WriteLine(i + ". :" + item);
				i++;
			}
		}

		public void ListazasIdovonalEsemenyek()
		{
			int i = 1;
			foreach (var item in this.idovonalEsemenyLista)
			{
				Console.WriteLine(i + ". :" + item);
				i++;
			}
		}
	}
}
