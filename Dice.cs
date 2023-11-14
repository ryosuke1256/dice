using System;

namespace Source {
  class Program {
    private static void Main(string[] args) {
      var dice = new Dice();
      int diceNumber = dice.Roll();
      Console.WriteLine($"Dice number is {diceNumber}");
    }
  }

  class Dice {
    private readonly Random random;

    public Dice() {
      random = new Random();
    }

    public int Roll() {
      return random.Next(1, 7);
    }
  }
}
