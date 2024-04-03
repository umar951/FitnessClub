namespace Studio9Fitnes_Clud.Domain.Entities;

public class Cart:Entity
{
    public string Uid { get; set; }
    public List<CartItem> CartItems { get; set; } = new();
}