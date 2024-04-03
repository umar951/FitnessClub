namespace Studio9Fitnes_Clud.Domain.Entities;

public class CartItem:Entity
{
    public long CammodityId { get; set; }
    public int Count { get; set; }
    public long CartId { get; set; }
    // public  Cart? Cart { get; set; }
    public Fitnes? Fitnes { get; set; }
}