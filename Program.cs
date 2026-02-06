namespace Digitalis_Nyomozas
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Felhasznalo f1 = new Felhasznalo("KZ", "007", "nyomozó");
			Felhasznalo f2 = new Felhasznalo("Khabib", "012", "nyomozó");
			Szemely s1 = new Szemely("Koczka Steve", 67, "Úszómester");
			Szemely s2 = new Szemely("Urbin Pork", 69, "Cisco mester");
			Bizonyitek b1 = new Bizonyitek("01", "digitális adat", "Linux keresés előzmény", 3);
			Bizonyitek b2 = new Bizonyitek("02", "fotó", "Kép az Urbin Islandről", 5);

			List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
			felhasznalok.Add(f1);
			felhasznalok.Add(f2);
			List<Szemely> szemelyek = new List<Szemely>();
			szemelyek.Add(s1);
			szemelyek.Add(s2);
			List<Bizonyitek> bizonyitekok = new List<Bizonyitek>();
			bizonyitekok.Add(b1);
			bizonyitekok.Add(b2);

			Ugy u1 = new Ugy("001", "Koczka elszabadul", "Úszó olimpikon", "őrizetben");
			u1.HozzatartozoFelvetel(s1);
			u1.BizonyitekFelvetel(b1);
			Ugy u2 = new Ugy("002", "Urbin Island", "Cisco mester", "őrizetben");
			u2.HozzatartozoFelvetel(s2);
			u2.BizonyitekFelvetel(b2);
			List<Ugy> ugyek = new List<Ugy>();
			ugyek.Add(u1);
			ugyek.Add(u2);
			Adattar a = new Adattar(felhasznalok, ugyek, szemelyek, bizonyitekok);
			foreach(var item in a.SzemelyekLista)
			{
				Console.WriteLine(item);
			}
			int input = 0;
			do
			{
				Console.WriteLine("1. Ügyek kezelése\r\n2. Személyek kezelése\r\n3. Bizonyítékok kezelése\r\n4. Idővonal megtekintése\r\n5. Elemzés / döntések\r\n6. Kilépés");

				input = Convert.ToInt32(Console.ReadLine());

				if (input == 1) 
				{

					Console.Write("Cím: ");
					string cim = Console.ReadLine();
					Console.Write("Leírás: ");
					string leiras = Console.ReadLine();
					Console.Write("Állapot: ");
					string allapot = Console.ReadLine();
					Ugy uj_ugy = new Ugy("001", cim, leiras, allapot);
					uj_ugy.HozzatartozoFelvetel(s2);
					uj_ugy.BizonyitekFelvetel(b2);

					Console.WriteLine(uj_ugy);

				}
				if (input == 2)
				{
					continue;
				}
				if (input == 3) { 
					continue; 
				}
				if (input == 4) 
				{
					Console.Write("Ugy állapot változtatása erre: ");
					string ugy_allapot = Console.ReadLine();
					u1.AllapotValtozas(ugy_allapot);
				}
				if (input == 5)
				{
					continue;
				}
				if (input == 6)
				{
					Environment.Exit(0);
				}
				else
				{

				}

			}
			while (input != 6);
        }
    }
}
