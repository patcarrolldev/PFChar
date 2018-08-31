using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacter
{
    class CharacterFeat
    {
        public CharacterFeat() { }

        public Guid AbilityIdentifier;
        public string Description;
        public CharacterModifier[] Modifiers;
    }
}
