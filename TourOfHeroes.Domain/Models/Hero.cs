using System;
using System.Collections.Generic;
using System.Text;

namespace TourOfHeroes.Domain.Models
{
    public class Hero : BaseEntity
    {
        public Hero(string name, string alterEgo, string shortDescription = "", string superPower = "", string backstory = "")
        {
            ValidateSuperPower(superPower);
            Name = name;
            AlterEgo = alterEgo;
            Backstory = backstory;
            ShortDescription = shortDescription;
        }

        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string AlterEgo{ get; set; }
        public string SuperPower { get; set; }
        public string Backstory { get; set; }

        //Validate if a power exists in the powers list
        //TODO: Implement this beahviour, by now just validate if the power is not null. Will never happen cause superpower has as default value a empty string.
        public void ValidateSuperPower(string superPower) 
        {
            if (superPower == null)
                throw new Exception("Superpower is null");
        }

        public void Update(string name, string alterEgo)
        {
        }
    }
}
