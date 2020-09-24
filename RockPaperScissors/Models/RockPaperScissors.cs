using System;
using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public string[] WeaponArray = {"Rock", "Scissors", "Paper"};
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
      int heroIndex = Array.IndexOf(WeaponArray,HeroWeapon);
      int villainIndex = Array.IndexOf(WeaponArray,VillainWeapon);
      Console.WriteLine("heroIndex: "+heroIndex+", villainIndex: "+villainIndex);
      // if (villainIndex <= ((WeaponArray.Length -1)/2)+1) { result = HeroWeapon+" beats "+VillainWeapon} else if (villainIndex >= ((WeaponArray.Length -1)/2)+1)
      int index = 0;
      foreach (string weapon in WeaponArray)
      {
        
        if (index < heroIndex)
        {
          heroIndex = index;
        }
        index += 1;
      }




      if (HeroWeapon == VillainWeapon)
      {
      result = "It's a Tie!";
      }
      // else if ([] Weaponarray < ContextStaticAttribute )
      // {
      // result = "It's a Tie!";
      // }
      else
      {
        result = "I don't know what just happened?";
      }
      return result;
    }
  }
}
