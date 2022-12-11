using System.Collections.ObjectModel;

namespace AdventOfCode.Puzzles.Day_01;

public class FoodCalories
{
    private readonly List<Calorie> calories = new List<Calorie>();

    public ReadOnlyCollection<Calorie> Calories => calories.AsReadOnly();

    public int Total => Calories.Sum(c => c.Value);

    public void AddCalorieValue(int calorieValue)
    {
        calories.Add(new Calorie(calorieValue));
    }
}