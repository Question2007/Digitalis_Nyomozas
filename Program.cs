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
			Gyanusitott gy1 = new Gyanusitott(s1, 70, "őrizetben");
			Gyanusitott gy2 = new Gyanusitott(s2, 67, "megfigyelés alatt");
			List<Gyanusitott> gyanusitottak = new List<Gyanusitott>();
			gyanusitottak.Add(gy1);
			gyanusitottak.Add(gy2);

			Szemely s3 = new Szemely("Kiss István", 10, "Island áldozat");
			Szemely s4 = new Szemely("Nagy Laci", 12, "Island áldozat");
			Tanu t1 = new Tanu(s3, "Azt hittem csokit adnak", new DateTime(2025, 05, 15));
			Tanu t2 = new Tanu(s4, "Azt hittem nyaralni megyünk", new DateTime(2025, 07, 07));
			List<Tanu> tanuk = new List<Tanu>();
			tanuk.Add(t1);
			tanuk.Add(t2);

			IdovonalEsemeny i1 = new IdovonalEsemeny(new DateTime(2025, 05, 15), "Kihallgattuk Kiss István tanut.");
			IdovonalEsemeny i2 = new IdovonalEsemeny(new DateTime(2025, 07, 07), "Kihallgattuk Nagy Laci tanut.");
			List<IdovonalEsemeny> idovonalEsemenyek = new List<IdovonalEsemeny>();
			idovonalEsemenyek.Add(i1);
			idovonalEsemenyek.Add(i2);
			Adattar a = new Adattar(felhasznalok, ugyek, szemelyek, bizonyitekok, gyanusitottak, tanuk, idovonalEsemenyek);
			int input = 0;
			Ugy uj_ugy = new Ugy();

			Donteshozo donteshozo = new Donteshozo();
			do
			{
				Console.WriteLine("1. Ügyek kezelése\r\n2. Személyek kezelése\r\n3. Bizonyítékok kezelése\r\n4. Idővonal megtekintése\r\n5. Elemzés / döntések\r\n6. Kilépés");

				input = Convert.ToInt32(Console.ReadLine());

				if (input == 1) 
				{
					Console.WriteLine("1. Új ügy hozzáadása\r\n2. Ügy állapotának megváltoztatása ");
					int valasztas = Convert.ToInt32(Console.ReadLine());
					if (valasztas == 1)
					{
						Console.WriteLine("Ügy azonosító: ");
						string az = Console.ReadLine();
						Console.Write("Cím: ");
						string cim = Console.ReadLine();
						Console.Write("Leírás: ");
						string leiras = Console.ReadLine();
						Console.Write("Állapot: ");
						string allapot = Console.ReadLine();
						uj_ugy = new Ugy(az, cim, leiras, allapot);
						uj_ugy.HozzatartozoFelvetel(s2);
						uj_ugy.BizonyitekFelvetel(b2);
						ugyek.Add(uj_ugy);
						Console.WriteLine(uj_ugy);
					}
					else if (valasztas == 2)
					{

						Console.WriteLine("Melyik ugyet akarja megváltoztatni: ");
						a.ListazasUgyek();
						int ugyszam = Convert.ToInt32(Console.ReadLine());

						Console.Write("Ugy állapot változtatása erre: ");
						string ugy_allapot = Console.ReadLine();
						a.UgyekLista[ugyszam - 1].AllapotValtozas(ugy_allapot);
					}
					

				}
				if (input == 2)
				{
					a.ListazasSzemelyek();
					Console.Write("Név: ");
					string nev = Console.ReadLine();
					Console.Write("Életkor: ");
					int eletkor = Convert.ToInt32(Console.ReadLine());
					Console.Write("Megjegyzés: ");
					string megjegyzes = Console.ReadLine();
					Szemely uj_szemely = new Szemely(nev, eletkor, megjegyzes);
					szemelyek.Add(uj_szemely);
					Console.WriteLine(uj_szemely);
				}
				if (input == 3) {
					Console.Write("Bizonyíték azonosító: ");		
					string bizAzonosito = Console.ReadLine();
					Console.WriteLine("Típus (fotó, dokumentum, digitális adat): ");
					string tipus = Console.ReadLine();
					Console.WriteLine("Leírás: ");
					string leiras = Console.ReadLine();
					Console.WriteLine("Megbizhatósági érték (1-5)");
					int megbizhatosagi_ertek = Convert.ToInt32(Console.ReadLine());
					Bizonyitek uj_bizonyitek = new Bizonyitek(bizAzonosito, tipus, leiras, megbizhatosagi_ertek);

					Console.WriteLine(uj_bizonyitek);
					

				}
				if (input == 4) 
				{

				}
				if (input == 5)
				{
					Console.WriteLine("Válasz egy gyanusítottat: ");
					a.ListazasGyanusitottak();
					int gyanusitott_szam = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Válasz egy bizonyítékot: ");
					a.ListazasBizonyitekok();
					int bizonyitek_szam = Convert.ToInt32(Console.ReadLine());

					donteshozo.Donteshozas(a.GyanusitottLista[gyanusitott_szam-1], a.BizonyitekLista[bizonyitek_szam-1]);
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
