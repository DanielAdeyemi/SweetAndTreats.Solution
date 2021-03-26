using System.Collections.Generic;

namespace SweetAndTreat.Models
{
  public class Treat
  {
    public Treat()
    {
      JoinEntities = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}