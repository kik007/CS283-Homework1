using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonsterLibrary;

namespace PokemonFormsApp
{
    public partial class PokemonForm : Form
    {
        public Monster Monster;
        public int UserStarDust;
        public int UserCandy;

        public PokemonForm()
        {
            InitializeComponent();
            UserStarDust = 100000;
            UserCandy = 1234;
            Monster = new Monster()
            {
                Name = "妙蛙種子",
                CurrentHp = 40,
                Hp = 60,
                Weight = 6.94f,
                Types = new string[] { "草", "毒" },
                Height = 0.66f,
                PowerUpCandy = 3,
                PowerUpStardust = 3000,
                EvolveCandy = 25
            };
            Monster_Label.Text = Monster.Name;
            Hp_Label.Text = Monster.CurrentHp.ToString() + "/" + Monster.Hp + "HP";
            Height_Label.Text = Monster.Height.ToString() + "m";
            Types_Label.Text = Monster.Types[0] + "/" + Monster.Types[1];
            Weight_Label.Text = Monster.Weight.ToString() + "kg";
            PowerUpCandy_Label.Text = Monster.PowerUpCandy.ToString();
            PowerUpStardust_Label.Text = Monster.PowerUpStardust.ToString();
            EvolveCandy_Label.Text = Monster.EvolveCandy.ToString();
            UserStardust_Label.Text = UserStarDust.ToString();
            UserCandy_Label.Text = UserCandy.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserCandy = UserCandy - Monster.PowerUpCandy;
            UserStarDust = UserStarDust - Monster.PowerUpStardust;
            Monster.Hp = Monster.Hp + 10;
            Monster.CurrentHp = Monster.CurrentHp + 10;
            Hp_Label.Text = Monster.CurrentHp.ToString() + "/" + Monster.Hp + "HP";
            UserStardust_Label.Text = UserStarDust.ToString();
            UserCandy_Label.Text = UserCandy.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserCandy = UserCandy - Monster.EvolveCandy;
            Monster = new Monster()
            {
                Name = "妙蛙草",
                CurrentHp = 150,
                Hp = 250,
                Weight = 10.94f,
                Types = new string[] { "草", "毒" },
                Height = 1.66f,
                PowerUpCandy = 3,
                PowerUpStardust = 3000,
                EvolveCandy = 100
            };
            Monster_Label.Text = Monster.Name;
            Hp_Label.Text = Monster.CurrentHp.ToString() + "/" + Monster.Hp + "HP";
            Height_Label.Text = Monster.Height.ToString();
            Types_Label.Text = Monster.Types[0] + "/" + Monster.Types[1];
            Weight_Label.Text = Monster.Weight.ToString();
            PowerUpCandy_Label.Text = Monster.PowerUpCandy.ToString();
            PowerUpStardust_Label.Text = Monster.PowerUpStardust.ToString();
            EvolveCandy_Label.Text = Monster.EvolveCandy.ToString();
            UserStardust_Label.Text = UserStarDust.ToString();
            UserCandy_Label.Text = UserCandy.ToString();
        }
    }
}