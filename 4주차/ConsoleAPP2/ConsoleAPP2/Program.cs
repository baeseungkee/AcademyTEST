using System;
using System.Collections.Generic;

namespace ConsoleAPP2
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            world.Init();

        }
        class World
        {
            public List<Creature> creatures = new List<Creature>();
            public void Init()
            {
                creatures.Add(new Monkey());
                creatures.Add(new Monkey());
                creatures.Add(new Monkey());

                creatures.Add(new Whale());
                creatures.Add(new Whale());
                creatures.Add(new Whale());

                creatures.Add(new Eagle());
                creatures.Add(new Eagle());
                creatures.Add(new Eagle());
            }
        }
        abstract class Creature // 생성 불가능한 추상화 클래스
        {
        }
        abstract class Mammal // 포유류
        {
        }
        abstract class Birds // 조류
        {
        }
        abstract class Fish // 어류
        {
        }
        class Monkey : Mammal
        {
        }
        class Whale : Mammal
        {
        }
        class Dolphin : Mammal
        {
        }
        class Eagle : Birds
        {
        }
        class Sparoow : Birds
        {
        }
        class Pigeon : Birds
        {

        }
        class Penguin : Birds
        {
        }
        class Goldfish : Fish
        {
        }
        class Eel : Fish
        {
        }

    }
}
