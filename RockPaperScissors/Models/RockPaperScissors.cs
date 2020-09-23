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
      string [] WeaponArray = {"Rock", "Scissors", "Paper"};
      HeroWeapon = heroWeapon;
      VillainWeapon = villainWeapon;
    }
    public string PlayGame()
    {
      string result;
      if (HeroWeapon == VillainWeapon)
      {
      result = "It's a Tie!";
      }
      else
      {
        result = "I don't know what just happened?";
      }
      return result;
    }
  }
}
