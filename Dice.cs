using System;

namespace source {
  class Program {
    public static void Main(string[] args) {
      Dice dice = new Dice();
      int diceNumber = dice.Throw();
      Console.WriteLine($"Dice number is {diceNumber}");
    }
  }

  class Dice {
    public int Throw() {
      Random rand = new Random();
      return rand.Next(1, 7);
    }
  }
}
