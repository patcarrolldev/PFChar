using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacter
{
    class ActiveEffect
    {
        public ActiveEffect() { }

        public Guid AbilityIdentifier;
        public string Description;
        public CharacterModifier[] Modifiers;
        public int DurationRounds;
    }
}
