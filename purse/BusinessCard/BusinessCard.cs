

public class BusinessCard
{
    private string cardNumber;

    public BusinessCard(string cardNumber1)
    {
        this.cardNumber = cardNumber1;
    }

    public string CardInfo()
    {
        return "Business card number:"+ cardNumber;
    }
}
