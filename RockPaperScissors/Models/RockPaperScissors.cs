using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public string[] WeaponArray { get; set; }
    public string HeroWeapon { get; set; }
    public string VillainWeapon { get; set; }
    public Game (string heroWeapon, string villainWeapon)
    {
      string [] WeaponArray = {"Rock", "Paper", "Scissors"};
      HeroWeapon = heroWeapon;
      VillainWeapon = villainWeapon;
    }
    public static void PlayGame()
    {
      // etc
    }
  }
}
