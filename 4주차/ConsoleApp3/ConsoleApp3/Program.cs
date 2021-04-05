using ConsoleApp3;
using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            world.Init();

            foreach(Creature target in world.list)
            {
                if(target is iSwimmable)
                {
                    (target as iSwimmable).swim();
                    Console.WriteLine($"[{target}]");
                }
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
        void swim();
    }
    abstract class Creature
    {

    }
    abstract class Mammal : Creature
    {
    }
    abstract class Brids : Creature
    {

    }
    abstract class FIsh : Creature
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
    class Dolphin : Mammal, iSwimmable
    {
        public void swim()
        {
            throw new NotImplementedException();
        }
    }
    class Eagle : Brids { }
    class Sparrow : Brids { }
    class Pigeon : Brids { }
    class Penguin : Brids, iSwimmable
    {
        public void swim()
        {
            throw new NotImplementedException();
        }
    }
    class Goldfish : FIsh, iSwimmable
    {
        public void swim()
        {
            throw new NotImplementedException();
        }
    }
    class Eel : FIsh, iSwimmable
    {
        public void swim()
        {
            throw new NotImplementedException();
        }
    }
}
