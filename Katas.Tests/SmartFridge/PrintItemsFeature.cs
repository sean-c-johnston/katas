namespace Katas.SmartFridge;

public class PrintItemsFeature
{
    [Fact]
    public void PrintItemsContainedInTheFridge()
    {
        var clock = new FridgeClock(2021, 10, 18);
        var fridge = new SmartFridge();
        var display = new FridgeDisplay();

        fridge.Open();
        fridge.Add(name: "Milk", expiry: "21/10/21", condition: "sealed");
        fridge.Add(name: "Cheese", expiry: "18/11/21", condition: "sealed");
        fridge.Add(name: "Beef", expiry: "20/10/21", condition: "sealed");
        fridge.Add(name: "Lettuce", expiry: "22/10/21", condition: "sealed");
        fridge.Close();

        clock.EndDay();

        fridge.Open();
        fridge.Close();

        fridge.Open();
        fridge.Close();
        
        fridge.Open();
        fridge.Remove(name: "Milk");
        fridge.Close();

        fridge.Open();
        fridge.Add(name: "Milk", expiry: "26/10/21", condition: "opened");
        fridge.Add(name: "Peppers", expiry: "23/10/21", condition: "opened");
        fridge.Close();

        clock.EndDay();

        fridge.Open();
        fridge.Remove(name: "Beef");
        fridge.Remove(name: "Lettuce");
        fridge.Close();
        
        fridge.Open();
        fridge.Add(name: "Lettuce", expiry: "22/10/21", condition: "opened");
        fridge.Close();

        fridge.Open();
        fridge.Close();

        clock.EndDay();

        fridge.UpdateDisplay();
        
        Received.InOrder(() =>
        {
            display.Print("EXPIRED: Milk");
            display.Print("Lettuce: 0 days remaining");
            display.Print("Peppers: 1 day remaining");
            display.Print("Cheese: 31 days remaining");    
        });
        
    }
}