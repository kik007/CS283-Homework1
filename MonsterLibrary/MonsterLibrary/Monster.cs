using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Monster
    {
        public string monstername;
        public bool gender;
        public string property;
        public int hp;
        public float weight;
        public float height;
        public int star;
        public int candy;
    }

    public class MonsterSkill
    {
        public string skillname;
        public int skillrank;
        public int skillinjure;
    }
}