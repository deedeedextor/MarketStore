namespace MarketStore
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Owner ownerOne = new Owner("Petar Petrov");
            Owner ownerTwo = new Owner("Dimitar Stoev");
            Owner ownerThree = new Owner("Alex Alenov");

            ICard cardOne = new Bronze(ownerThree, 0);
            ICard cardTwo = new Silver(ownerOne, 600);
            ICard cardThree = new Gold(ownerTwo, 1500);
            ICard cardFour = new Bronze(ownerOne, 302);
            ICard cardFive = new Silver(ownerTwo, 212);
            ICard cardSix = new Gold(ownerTwo, 750);

            Console.WriteLine(cardOne.Output(150));
            Console.WriteLine(cardTwo.Output(850));
            Console.WriteLine(cardThree.Output(1300));
            Console.WriteLine(cardFour.Output(199));
            Console.WriteLine(cardFive.Output(342));
            Console.WriteLine(cardSix.Output(187));
        }
    }
}
