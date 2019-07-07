using System;
using System.Collections.Generic;
using System.Linq;

namespace _21cards
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<KeyValuePair<int, string>> cards = new List<KeyValuePair<int, string>>();

            GenerateDeck(cards);

            int indexOfCard = int.Parse(Console.ReadLine());

            if (IsInRange(indexOfCard))
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine(string.Join(", ", cards.Where(c => c.Key >= indexOfCard).Select(x => x.Value)));
            }
        }

        private static bool IsInRange(int indexOfCard)
        {
            if (indexOfCard >= 1 && indexOfCard <= 52)
            {
                return true;
            }

            return false;
        }

        private static void GenerateDeck(List<KeyValuePair<int, string>> cards)
        {
            int totalCountOfCards = 1;

            for (int i = 1; i <= 13; i++)
            {
                string currentCard = string.Empty;
                string suit = string.Empty;

                switch (i)
                {
                    case 1:
                        currentCard = "Двойка";
                        GeneratePackOfFourCards(currentCard, cards,ref totalCountOfCards, currentCard, suit);
                        break;
                    case 2:
                        currentCard = "Тройка";
                        GeneratePackOfFourCards(currentCard, cards,ref totalCountOfCards, currentCard, suit);
                        break;
                    case 3:
                        currentCard = "Четворка";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 4:
                        currentCard = "Петица";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 5:
                        currentCard = "Шестица";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 6:
                        currentCard = "Сецмица";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 7:
                        currentCard = "Осмица";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 8:
                        currentCard = "Деветка";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 9:
                        currentCard = "Десетка";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 10:
                        currentCard = "Вале";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 11:
                        currentCard = "Дама";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 12:
                        currentCard = "Поп";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                    case 13:
                        currentCard = "Асо";
                        GeneratePackOfFourCards(currentCard, cards, ref totalCountOfCards, currentCard, suit);
                        break;
                }
            }
        }

        private static void GeneratePackOfFourCards(string currentCard, List<KeyValuePair<int, string>> cards, ref int totalCountOfCards, string currentCard2, string suit)
        {
            for (int j = 0; j < 4; j++) // creating current type of card with all four suits
            {
                if (j == 0)
                {
                    suit = "спатия";
                    GenerateCard(cards, ref totalCountOfCards, currentCard, suit);
                }
                else if (j == 1)
                {
                    suit = "каро";
                    GenerateCard(cards, ref totalCountOfCards, currentCard, suit);
                }
                else if (j == 2)
                {
                    suit = "купа";
                    GenerateCard(cards, ref totalCountOfCards, currentCard, suit);
                }
                else if (j == 3)
                {
                    suit = "пика";
                    GenerateCard(cards, ref totalCountOfCards, currentCard, suit);
                }
            }
        }

        private static void GenerateCard(List<KeyValuePair<int, string>> cards, ref int countOfCards, string currentCard, string suit)
        {
            cards.Add(new KeyValuePair<int, string>(countOfCards++, $"{currentCard} {suit}"));
        }
    }
}

