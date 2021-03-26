using System.Collections.Generic;

namespace SweetAndTreat.Models
{
  public class Flavor
  {
    public Flavor()
    {
      JoinEntities = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}