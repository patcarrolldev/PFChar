using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacter
{
    


    class PathfinderClass {
        public PathfinderClass(PathfinderClassType Type, int Level)
        {
            this.Type = Type;
            this.Level = Level;
        }

        public PathfinderClassType Type;
        public int Level;
    }


    class PathfinderCharacter
    {
        public PathfinderCharacter()
        {
            this.ScoresBase = new int[6];
        }

        public void LoadCharacter(string FilePath)
        {

        }
        public void SaveCharacter(string FilePath)
        {

        }
        public bool CheckCharacterValid()
        {
            return true;
        }

        public Guid CharacterIdentifier;
        public string Name;
        public PathfinderRace Race;
        public PathfinderClass[] ClassArray;

        public int[] ScoresBase;
        public CharacterAbility[] Abilities;
        public CharacterSkill[] Skills;
        public CharacterFeat[] Feats;

        
    }
}
