namespace GoldyGopher.Services;
using GoldyGopher.Models;
using GoldyGopher.Utilities;
public class Numbers : INumbers
{
    public NumberOutput CalculateGoldyGopher(NumberInput input)
    {
        String output = ""; // output collector.
        Utilities utilities = new Utilities(); // create an instance of Utilities class

        for (int i = input.LowerNumber; i <= input.UpperNumber; i++) // looping through the range of numbers
        {
            output = output + utilities.GoldyGopher(i); // use the instance to call the method
        }

        return new NumberOutput { GoldyGopherString = output }; // returning the generated output string to UI page
    }
}
