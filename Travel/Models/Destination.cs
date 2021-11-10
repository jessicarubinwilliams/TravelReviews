using System;

namespace Travel.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string VisitDate { get; set; }
    public string Rating { get; set; }
    public string Review { get; set; }

  }
}