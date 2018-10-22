using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroStrikesBack.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        private string _heroName;

        public string HeroName
        {
            get { return _heroName; }
        }

        public void SetHeroName()
        {
            _heroName = new HeroGenerator().GetHeroName(FirstName, LastName);
        }
    }


}
