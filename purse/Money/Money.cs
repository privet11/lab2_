public class Money
{
    string quantity;

    public Money(string number)
    {
        this.quantity = number;
    }
    public string info()
    {
        return "Quantity of money: " + quantity;
    }
}