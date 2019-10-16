using System;
using System.Xml.Linq;

namespace DemoClient
{
  public class Song
  {
    public string id { get; private set; }
    public string title { get; private set; }
    public string artist { get; private set; }
    public int year { get; private set; }
    public decimal duration { get; private set; }

    public static Song Parse(XElement item)
    {
      return new Song
      {
        id = item.Attribute("id").Value,
        title = item.Element("title").Value,
        artist = item.Element("artist").Value,
        year = Convert.ToInt32(item.Element("year").Value),
        duration = Convert.ToDecimal(item.Element("duration").Value),
      };
    }

    public string display_text => $"{artist} - {title} ({year})";
  }
}
