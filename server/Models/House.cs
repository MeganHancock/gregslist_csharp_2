namespace gregslist_csharp_2.Models;

public class House
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Title { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Price { get; set; }
    public bool OwnedOutright { get; set; }
    public string CreatorId { get; set; }
}

