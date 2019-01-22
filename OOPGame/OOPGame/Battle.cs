using System;

namespace OOPGame
{
    //This is an utility class. This means that all the methods should be static and since they are only gonna be used together with our Warrior-class.
    class Battle
    {
        public static int dmg;

        internal static void StartFight(Warrior gladiator1, Warrior gladiator2)
        {
            while(true)
            {
                dmg = Battle.BattleRound(gladiator1);
                gladiator2.Hp -= dmg;
                Console.WriteLine($"{gladiator1.Name} attacks {gladiator2.Name} and deals {dmg} damage. {gladiator2.Name} has {gladiator2.Hp} left.");
                Console.WriteLine();
                if (gladiator2.Hp < 1)
                    break;

                dmg = Battle.BattleRound(gladiator2);
                gladiator1.Hp -= dmg;
                Console.WriteLine($"{gladiator2.Name} attacks {gladiator1.Name} and deals {dmg} damage. {gladiator1.Name} has {gladiator1.Hp} left.");
                Console.WriteLine();
                if (gladiator1.Hp < 1)
                    break;
            }

            string defeated = gladiator1.Hp < 0 ? gladiator1.Name : gladiator2.Name;
            string victor = defeated == gladiator1.Name ? gladiator2.Name : gladiator1.Name;

            Console.WriteLine($"{defeated} has died and {victor} is victorious!");
        }

        private static int BattleRound(Warrior gladiator)
        {
            int dmg = AttackRound(gladiator);
            int block = BlockRound(gladiator);
            int totalDmg = dmg - block;

            if (totalDmg < 0)
            {
                totalDmg = 0;
            }

            return totalDmg;
        }

        private static int AttackRound(Warrior gladiator)
        {
            return gladiator.Attack();
        }

        private static int BlockRound(Warrior gladiator)
        {
            return gladiator.BlockAttack();
        }
    }
}
