using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardGames
{
   
    class Program
    {
		static string[] DeckCards ={
					"AC", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC"
					,"AH", "2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH"
					,"AS", "2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS"
					,"AD", "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD"};
		static string Key = string.Empty;
		static string[] Cards;
		static void Main(string[] args)
        {
			try
			{

				Console.WriteLine("\t\t\t\tWelcome to Card Game \n");
				Console.WriteLine("Your Options are \n");
				Console.WriteLine("Press 1 to play cards \n");
				Console.WriteLine("Press 2 to 	Shuffle deck \n");
				Console.WriteLine("Press 3 to 	Restart the game \n");
				Console.WriteLine("Type Exit to exit game \n");
				Console.WriteLine("Lets Start Press Key \n");


				Cards = DeckCards;
				Shuffle();

				while (Cards.Length > 0)
				{
					Key = Convert.ToString(Console.ReadLine());

					if (Key == "1")
					{
						playGame();
					}
					else if (Key == "2")
					{
						Shuffle();
					}
					else if (Key == "3")
					{
						Restart();
					}
					else
					{
						Environment.Exit(0);
					}
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public static void playGame()
		{
			var random = new Random();
			int index = random.Next(Cards.Length);
			string value = Cards[index];
			string replacedValue = string.Empty;

			if (value.Contains("C"))
			{
				replacedValue = value.Replace("C", string.Empty);

				if (replacedValue == "A")
				{
					Console.WriteLine("Card Decked is Ace of Clubs");
				}
				else if (replacedValue == "J")
				{
					Console.WriteLine("Card Decked is Joker of Clubs");
				}
				else if (replacedValue == "Q")
				{
					Console.WriteLine("Card Decked is Queen of Clubs");
				}
				else if (replacedValue == "K")
				{
					Console.WriteLine("Card Decked is King of Clubs");
				}
				else
				{
					Console.WriteLine("Card Decked is " + replacedValue + " of Clubs");
				}
			}
			else if (value.Contains("H"))
			{
				replacedValue = value.Replace("H", string.Empty);

				if (replacedValue == "A")
				{
					Console.WriteLine("Card Decked is Ace of Hearts");
				}
				else if (replacedValue == "J")
				{
					Console.WriteLine("Card Decked is Joker of Hearts");
				}
				else if (replacedValue == "Q")
				{
					Console.WriteLine("Card Decked is Queen of Hearts");
				}
				else if (replacedValue == "K")
				{
					Console.WriteLine("Card Decked is King of Hearts");
				}
				else
				{
					Console.WriteLine("Card Decked is " + replacedValue + " of Hearts");
				}


			}
			else if (value.Contains("S"))
			{
				replacedValue = value.Replace("S", string.Empty);

				if (replacedValue == "A")
				{
					Console.WriteLine("Card Decked is Ace of Spades");
				}
				else if (replacedValue == "J")
				{
					Console.WriteLine("Card Decked is Joker of Spades");
				}
				else if (replacedValue == "Q")
				{
					Console.WriteLine("Card Decked is Queen of Spades");
				}
				else if (replacedValue == "K")
				{
					Console.WriteLine("Card Decked is King of Spades");
				}
				else
				{
					Console.WriteLine("Card Decked is " + replacedValue + " of Spades");
				}


			}
			else if (value.Contains("D"))
			{
				replacedValue = value.Replace("D", string.Empty);


				if (replacedValue == "A")
				{
					Console.WriteLine("Card Decked is Ace of Diamond");
				}
				else if (replacedValue == "J")
				{
					Console.WriteLine("Card Decked is Joker of Diamond");
				}
				else if (replacedValue == "Q")
				{
					Console.WriteLine("Card Decked is Queen of Diamond");
				}
				else if (replacedValue == "K")
				{
					Console.WriteLine("Card Decked is King of Diamond");
				}
				else
				{
					Console.WriteLine("Card Decked is " + replacedValue + " of Diamond");
				}


			}

			Cards = Cards.Where(val => val != value).ToArray();
		}

		public static void Shuffle()
		{

			var random = new Random();
			for (int i = Cards.Length - 1; i > 0; i--)
			{
				int randomIndex = random.Next(0, i + 1);
				string temp = Cards[i];
				Cards[i] = Cards[randomIndex];
				Cards[randomIndex] = temp;
			}
		}

		public static void Restart()
		{
			Cards = DeckCards;
		}
	}
}
