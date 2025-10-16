﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class Die
    {
        private Random _generator;
        private int _roll;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }
        public Die(int roll)
        {
            _generator = new Random();
            _roll = roll;
        }

        public int Roll
        {
            get { return _roll; }
            set
            {
                if (value <= 0)
                    _roll = 1;
                else if (value > 6)
                    _roll = 6;
                else
                    _roll = value;
            }
        }

        public int RollDie1()
        {
            _roll = _generator.Next(1, 7);
            return _roll;


        }

        public int RollDie2()
        {
            _roll = _generator.Next(1, 7);

            return _roll;


        }










        public void Draw()
        {
            if (_roll == 1)
            {

                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
            else if (_roll == 2)
            {

                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 3)
            {

                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 4)
            {

                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 5)
            {

                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 6)
            {

                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| ? |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
        }


    }
}
