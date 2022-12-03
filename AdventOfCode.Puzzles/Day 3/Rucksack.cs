namespace AdventOfCode.Puzzles.Day_3;

public class Rucksack
{
    public Compartment Compartment1 { get; set; } = new Compartment();
    public Compartment Compartment2 { get; set; } = new Compartment();

    public char FindOutOfPlaceItem()
    {
        return FindOutOfPlaceItem(Compartment1, Compartment2);
    }
        
    private char FindOutOfPlaceItem(Compartment compartmentOne, Compartment compartmentTwo)
    {
        var itemsCompartmentOne = compartmentOne.Items;
        var itemsCompartmentTwo = compartmentTwo.Items;

        var outOfPlaceItem = itemsCompartmentOne.Intersect(itemsCompartmentTwo).First();

        return outOfPlaceItem;
    }
}