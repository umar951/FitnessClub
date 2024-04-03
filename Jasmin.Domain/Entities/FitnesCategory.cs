namespace Studio9Fitnes_Clud.Domain.Entities;

public class FitnesCategory
{
    public string Uslugi { get; set; }
    public List<FitnesCategoryLink> FitnesCategoryLinks { get; set; } = new ();
}