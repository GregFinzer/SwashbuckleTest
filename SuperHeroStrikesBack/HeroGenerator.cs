using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroStrikesBack
{
    public class HeroGenerator
    {
        private Dictionary<string, string> _firstNames = new Dictionary<string, string>()
        {
            {"A", "Captain"},
            {"B", "Night" },
            {"C", "The" },
            {"D", "Ancient" },
            {"E", "Spider" },
            {"F", "Invisible" },
            {"G", "Master" },
            {"H", "Invincible" },
            {"I", "Silver" },
            {"J", "Flawless" },
            {"K", "Professor" },
            {"L", "Radioactive" },
            {"M", "Incredible" },
            {"N", "Impossible" },
            {"O", "Iron" },
            {"P", "Rocket" },
            {"Q", "Human" },
            {"R", "Power" },
            {"S", "Green" },
            {"T", "Super" },
            {"U", "Wonder" },
            {"V", "Metal" },
            {"W", "Doctor" },
            {"X", "Masked" },
            {"Y", "Crimson" },
            {"Z", "Omega" }
        };

        private Dictionary<string, string> _lastNames = new Dictionary<string, string>()
        {
            {"A", "Lightning"},
            {"B", "Knight" },
            {"C", "Hulk" },
            {"D", "Centurion" },
            {"E", "Surfer" },
            {"F", "Warrior" },
            {"G", "Soldier" },
            {"H", "Ghost" },
            {"I", "Master" },
            {"J", "Hornet" },
            {"K", "Phantom" },
            {"L", "Crusader" },
            {"M", "Daredevil" },
            {"N", "Machine" },
            {"O", "America" },
            {"P", "X" },
            {"Q", "Cyclone" },
            {"R", "Fist" },
            {"S", "Shadow" },
            {"T", "Patriot" },
            {"U", "Claw" },
            {"V", "Ninja" },
            {"W", "Storm" },
            {"X", "Samurai" },
            {"Y", "Yeller" },
            {"Z", "Man" }
        };

        public string GetHeroName(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                return string.Empty;

            string firstNameLetter = firstName.ToUpper()[0].ToString();
            string lastNameLetter = lastName.ToUpper()[0].ToString();

            string result;

            if (_firstNames.ContainsKey(firstNameLetter))
                result = _firstNames[firstNameLetter];
            else
                result = "General";

            result += " ";

            if (_lastNames.ContainsKey(lastNameLetter))
                result += _lastNames[lastNameLetter];
            else
                result += "Zod";

            return result;
        }
    }
}
