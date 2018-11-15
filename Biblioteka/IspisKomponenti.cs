using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteka
{
	public class IspisKomponenti
	{
		public static void IspisiTextbox(string naziv, bool obavezno)
		{
			Console.WriteLine(String.Format("{0, 15}{1, 1}┌────────────────────┐", naziv, (obavezno) ? "*" : " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}│                    │", "", " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}└────────────────────┘", "", " "));
		}

		public static void IspisiCombobox(string naziv, bool obavezno)
		{
			Console.WriteLine(String.Format("{0, 15}{1, 1}┌───────────────┐┌───┐", naziv, (obavezno) ? "*" : " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}│               ││ V │", "", " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}└───────────────┘└───┘", "", " "));
		}

		public static void IspisiTabelu(List<string> kolone)
		{

			Console.WriteLine();
			PrintRow(kolone.ToArray());
			PrintLine();
			for (int i = 0; i < 5; i++)
			{
				PrintEmptyRow(kolone.Count);
				PrintLine();
			}

		}

		internal static void IspisiRadiobutton(string naziv)
		{
			Console.WriteLine($"( ) {naziv}");

		}

		public static void IspisiRadiobutton(List<string> Komponente)
		{
			foreach (var komponenta in Komponente)
			{
				if (komponenta == Komponente.First())
				{
					Console.WriteLine($"(o) {komponenta}");
				}
				else
				{ Console.WriteLine($"( ) {komponenta}"); }
			}

		}

		public static void IspisiKartice(List<string> komponentaNaziv)
		{
			PrintLine();
			PrintRow(komponentaNaziv.ToArray());
		}

		public static void IspisiCheckbox(string naziv)
		{
			Console.WriteLine($"[ ] {naziv}");
		}

		private static int tableWidth = 77;

		public static void PrintLine()
		{
			Console.WriteLine(new string('-', tableWidth));
		}

		public static void PrintRow(params string[] columns)
		{
			int width = (tableWidth - columns.Length) / columns.Length;
			string row = "|";

			foreach (string column in columns)
			{
				row += AlignCentre(column, width) + "|";
			}

			Console.WriteLine(row);
		}

		public static void PrintEmptyRow(int length)
		{
			int width = (tableWidth - length) / length;
			string row = "|";

			for (int i = 0; i < length; i++)
			{
				row += AlignCentre("", width) + "|";
			}

			Console.WriteLine(row);
		}

		private static string AlignCentre(string text, int width)
		{
			text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

			if (string.IsNullOrEmpty(text))
			{
				return new string(' ', width);
			}
			else
			{
				return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
			}
		}
	}
}
