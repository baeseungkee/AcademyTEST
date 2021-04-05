using System;
using System.Collections.Generic;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            world.Init();

            foreach (Creature creature in world.list)
            {
                if(creature is iSwimmable)
                {
                    (creature as iSwimmable).Swim();
                }
            }
        }
    }
    class World
    {
        public List<Creature> list = new List<Creature>();
        public void Init()
        {
            for (int i = 0; i<3; i++)
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
                list.Add(new Penguin());
            }
            for (int i = 0; i < 3; i++)
            {
                list.Add(new Goldfish());
            }
            for (int i = 0; i < 3; i++)
            {
                list.Add(new Eel());
            }
        }
    }
    interface iSwimmable
    {
        void Swim();
    }
    abstract class Creature
    {

    }
    abstract class Mammal : Creature
    {

    }
    abstract class Birds : Creature
    {

    }
    abstract class Fish : Creature
    {

    }
    class Monkey : Mammal { }
    class Whale : Mammal, iSwimmable
    {
        public void Swim()
        {
            Console.WriteLine($"[{nameof(Whale)}]");
        }
    }
    class Dolphin : Mammal { }
    class Eagle : Birds { }
    class Sparrow : Birds { }
    class Pigeon : Birds { }
    class Penguin : Birds, iSwimmable
    {
        public void Swim()
        {
            Console.WriteLine($"[{nameof(Penguin)}]");
        }
    }
    class Goldfish : Fish, iSwimmable
    {
        public void Swim()
        {
            Console.WriteLine($"[{nameof(Goldfish)}]");
        }
    }
    class Eel : Fish, iSwimmable
    {
        public void Swim()
        {
            Console.WriteLine($"[{nameof(Eel)}]");
        }
    }
}
