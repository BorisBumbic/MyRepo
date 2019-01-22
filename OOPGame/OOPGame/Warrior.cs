using System;

namespace OOPGame
{
    class Warrior
    {
        public string Name { get; set; } = "Nameless Warrior";
        public int Hp { get; set; } = 0;
        public int Dmg { get; set; } = 0;
        public int Block { get; set; } = 0;

        Random r = new Random();

        public Warrior(string name = "Nameless Warrior", int hp = 0, int dmg = 0, int block = 0)
        {
            Name = name;
            Hp = hp;
            Dmg = dmg;
            Block = block;
        }
        
        //This part is an excercise and not necessary for our constructor above is more than enough for this case.
        //public Warrior() : this("Maximus", 1000, 50, 20) { }

        //public Warrior(string name) : this(name, 1000, 50, 20) { }

        //public Warrior(string name, int hp) : this(name, hp, 50, 20) { }

        //public Warrior(string name, int hp, int dmg) : this(name, hp, dmg, 20) { }

        public int Attack()
        {
            return r.Next(1, Dmg);
        }

        public int BlockAttack()
        {
            return r.Next(1, Block);
        }

    }
}
