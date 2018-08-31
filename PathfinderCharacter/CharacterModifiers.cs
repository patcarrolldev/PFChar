using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacter
{
    class CharacterModifier
    {
        public CharacterModifier()
        {
        }

        public Guid Source;
        public PathfinderStatType Type;
        public string Description; // optional
        public int StatStrength;
        public int StatIntelligence;
        public int StatWisdom;
        public int StatDexterity;
        public int StatConstitution;
        public int StatCharisma;

        public int BaseAttackBonus;
        public int SaveFortitude;
        public int SaveReflex;
        public int SaveWill;

        public int SkillModifier;
    }
}
