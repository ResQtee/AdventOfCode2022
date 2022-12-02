﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode.Puzzles.Day_1;

namespace AdventOfCode2022.CLI
{
    internal class Day1
    {
        public static void Print()
        {
            FoodExpedition expedition = new FoodExpedition();
            Console.WriteLine("----- Day 1 -----");

            Console.WriteLine("Example:");
            expedition = expedition.CreateExpeditionFromFile(@".\day 1\input\example.txt");
            var highestCalorieElf = expedition.WhoHasTheHighestCalorieCount();
            Console.WriteLine(highestCalorieElf == null
                ? "The elves all left."
                : $"Highest calorie count is: {highestCalorieElf.TotalCalories}");

            var top3Elves = expedition.Top3HighestCalorieCountElves();
            Console.WriteLine(highestCalorieElf == null
                ? "The elves all left."
                : $"Top 3 total calorie count is: {top3Elves.Sum(elf => elf.TotalCalories)}");

            Console.WriteLine();
            Console.WriteLine("Puzzle:");
            expedition = expedition.CreateExpeditionFromFile(@".\day 1\input\expedition.txt");
            highestCalorieElf = expedition.WhoHasTheHighestCalorieCount();
            Console.WriteLine(highestCalorieElf == null
                ? "The elves all left."
                : $"Highest calorie count is: {highestCalorieElf.TotalCalories}");

            top3Elves = expedition.Top3HighestCalorieCountElves();
            Console.WriteLine(highestCalorieElf == null
                ? "The elves all left."
                : $"Top 3 total calorie count is: {top3Elves.Sum(elf => elf.TotalCalories)}");
        }
    }
}
