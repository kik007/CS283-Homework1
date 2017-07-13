using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterLibrary;

namespace Pokemon
{
    internal class Pokemon
    {
        private static void Main(string[] args)
        {
            Monster monster = new Monster()
            {
                monstername = "妙蛙種子",
                gender = true,
                property = "草/毒",
                hp = 60,
                weight = 5.94f,
                height = 0.67f,
                star = 271484,
                candy = 27,
            };

            MonsterSkill monsterskill = new MonsterSkill()
            {
                skillname = "藤鞭",
                skillrank = 0,
                skillinjure = 7
            };

            MonsterSkill monsterskill2 = new MonsterSkill()
            {
                skillname = "汙泥炸彈",
                skillrank = 2,
                skillinjure = 80
            };

            Console.WriteLine(
                "{0},{1}HP,{2}kg,屬性{3},{4}m,{5}星星沙子,{6}{0}的糖果,{7},{8},{9},{10},{11},{12}",
                monster.monstername,
                monster.hp,
                monster.weight,
                monster.property,
                monster.height,
                monster.star,
                monster.candy,
                monsterskill.skillname,
                monsterskill.skillrank,
                monsterskill.skillinjure,
                monsterskill2.skillname,
                monsterskill2.skillrank,
                monsterskill2.skillinjure);
        }
    }
}