using System;

namespace Travel.Models
{
  public class Destination
  {
    public int DestinationId { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public DateTime VisitDate { get; set; }
    public int Rating { get; set; }
    public string Review { get; set; }

  }
}