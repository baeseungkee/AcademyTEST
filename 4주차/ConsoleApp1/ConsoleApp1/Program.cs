using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            world.Init();

            foreach(Creature target in world.creatureLint)
            {
                if(target is iSwimmable)
                {
                    (target as iSwimmable).Swim();
                }
            }
        }
        interface iSwimmable
        {
            void Swim();
        }
        class World
        {
            public List<Creature> creatureLint = new List<Creature>();
            public void Init()
            {
                for (int i = 0; i < 4; i++)
                {
                    creatureLint.Add(new Monkey());
                }

                for (int i = 0; i < 4; i++)
                {
                    creatureLint.Add(new Whale());
                }

                for (int i = 0; i < 4; i++)
                {
                    creatureLint.Add(new Dolphin());
                }

                for (int i = 0; i < 4; i++)
                {
                    creatureLint.Add(new Eagle());
                }

                for (int i = 0; i < 4; i++)
                {
                    creatureLint.Add(new Sparrow());
                }

                for (int i = 0; i < 4; i++)
                {
                    creatureLint.Add(new Pigeon());
                }

                for (int i = 0; i < 4; i++)
                {
                    creatureLint.Add(new Penguin());
                }

                for (int i = 0; i < 4; i++)
                {
                    creatureLint.Add(new Goldfish());
                }

                for (int i = 0; i < 4; i++)
                {
                    creatureLint.Add(new Eel());
                }
            }
        }
        abstract class Creature // 생성 불가능한 추상화 클래스
        {
        }
        abstract class Mammal : Creature // 포유류
        {
        }
        abstract class Birds : Creature // 조류
        {
        }
        abstract class Fish : Creature // 어류
        {
        }
        class Monkey : Mammal
        {
        }
        class Whale : Mammal, iSwimmable
        {
            public void Swim()
            {
                Console.WriteLine($"[{nameof(Whale)}] 수영했어요!");
            }
        }
        class Dolphin : Mammal, iSwimmable
        {
            public void Swim()
            {
                Console.WriteLine($"[{nameof(Dolphin)}] 수영했어요!");
            }
        }
        class Eagle : Birds
        {
        }
        class Sparrow : Birds
        {
        }
        class Pigeon : Birds
        {

        }
        class Penguin : Birds, iSwimmable
        {
            public void Swim()
            {
                Console.WriteLine($"[{nameof(Penguin)}] 수영했어요!");
            }
        }
        class Goldfish : Fish, iSwimmable
        {
            public void Swim()
            {
                Console.WriteLine($"[{nameof(Goldfish)}] 수영했어요!");
            }
        }
        class Eel : Fish, iSwimmable
        {
            public void Swim()
            {
                Console.WriteLine($"[{nameof(Eel)}] 수영했어요!");
            }
        }

    }
}