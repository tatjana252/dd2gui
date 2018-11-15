using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiBuilder.GuiConsole
{
	public class PrintComponentsConsole
	{
		public static void PrintTextbox(string name, bool required)
		{
			Console.WriteLine(String.Format("{0, 15}{1, 1}┌────────────────────┐", name, (required) ? "*" : " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}│                    │", "", " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}└────────────────────┘", "", " "));
		}

		public static void PrintCombobox(string name, bool required)
		{
			Console.WriteLine(String.Format("{0, 15}{1, 1}┌───────────────┐┌───┐", name, (required) ? "*" : " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}│               ││ V │", "", " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}└───────────────┘└───┘", "", " "));
		}

		public static void PrintTable(List<string> columns)
		{

			Console.WriteLine();
			PrintRow(columns.ToArray());
			PrintLine();
			for (int i = 0; i < 5; i++)
			{
				PrintEmptyRow(columns.Count);
				PrintLine();
			}

		}

		internal static void PrintRadiobutton(string name)
		{
			Console.WriteLine($"( ) {name}");
		}

		public static void PrintRadiobutton(List<string> components)
		{
			foreach (var c in components)
			{
				if (c == components.First())
				{
					Console.WriteLine($"(o) {c}");
				}
				else
				{ Console.WriteLine($"( ) {c}"); }
			}

		}

		public static void PrintTabs(List<string> columns)
		{
			PrintLine();
			PrintRow(columns.ToArray());
		}

		public static void PrintCheckbox(string name)
		{
			Console.WriteLine($"[ ] {name}");
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

		public static void PrintDateField(string pName, bool required)
		{
			Console.WriteLine(String.Format("{0, 15}{1, 1}┌───────────────┐┌───┐", pName, (required) ? "*" : " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}│               ││▒▒▒│", "", " "));
			Console.WriteLine(String.Format("{0, 15}{1, 1}└───────────────┘└───┘", "", " "));
		}
	}
}
