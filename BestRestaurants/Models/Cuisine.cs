using System.Collections.Generic;

namespace BestBestRestausrants.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurant = new HashSet<Restaurant>();
    }

    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}