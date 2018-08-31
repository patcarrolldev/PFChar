using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacter
{
    /*
     * Each ability should have an ID, which will generate an instance of the ability with
     * the appropriate array of character modifiers that are dynamic based on the class
     * level associated with the ability
     */
    class CharacterAbility
    {
        public CharacterAbility() { }

        public Guid AbilityIdentifier;
        public string Description;
        public CharacterModifier[] Modifiers;
    }
}
