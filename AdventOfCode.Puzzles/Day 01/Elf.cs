namespace AdventOfCode.Puzzles.Day_01;

public class Elf
{
    public FoodCalories Calories { get; set; } = new FoodCalories();
    public int TotalCalories => Calories.Total;

    public void AddCalories(int calorieValue)
    {
        Calories.AddCalorieValue(calorieValue);
    }
}