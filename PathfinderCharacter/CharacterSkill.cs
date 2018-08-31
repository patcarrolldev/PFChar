using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacter
{
    class CharacterSkill
    {
        public CharacterSkill() { }

        public Guid SkillIdentifier;
        public string Description;
        public int Ranks;
        public CharacterModifier[] Modifiers;
    }
}
