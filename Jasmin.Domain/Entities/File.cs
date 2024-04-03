namespace Studio9Fitnes_Clud.Domain.Entities;

public class File:Entity
{
    public string Name { get; set; }
    public long Size { get; set; }
    public string Extension => Path.GetExtension(Name);
    public string Base64 { get; set; } = "";
    public string StrogeId { get; set; }
}