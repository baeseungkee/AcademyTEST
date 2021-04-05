using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            world.Init();

            foreach (Creature target in world.list)
            {
                if(target is iSwimmable)
                {
                    (target as iSwimmable).swim();
                }
            }
        }
        class World
        {
            public List<Creature> list = new List<Creature>();
            public void Init()
            {
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new Monkey());
                }
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new Whale());
                }
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new Dolphin());
                }
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new Eagle());
                }
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new Sparrow());
                }
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new Pigeon());
                }
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new GoldFish());
                }
                for (int i = 0; i < 3; i++)
                {
                    list.Add(new Eel());
                }
            }
        }
        interface iSwimmable
        {
            void swim();
        }
        abstract class Creature
        {

        }
        abstract class Mammal : Creature
        {

        }
        abstract class Bird : Creature
        {

        }
        abstract class Fish : Creature
        {

        }
        class Monkey : Mammal { }
        class Whale : Mammal, iSwimmable
        {
            public void swim()
            {
                Console.WriteLine($"[{nameof(Whale)}]");
            }
        }
        class Dolphin : Mammal { }
        class Eagle : Bird { }
        class Sparrow : Bird { }
        class Pigeon : Bird { }
        class Penguin : Bird, iSwimmable
        {
            void iSwimmable.swim()
            {
                throw new NotImplementedException();
            }
        }
        class GoldFish : Fish, iSwimmable
        {
            void iSwimmable.swim()
            {
                throw new NotImplementedException();
            }
        }
        class Eel : Fish, iSwimmable
        {
            void iSwimmable.swim()
            {
                throw new NotImplementedException();
            }
        }
    }
}
