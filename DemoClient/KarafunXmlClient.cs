using System;
using System.Configuration;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KarafunApi
{
  public class Karafun
  {
    static readonly string TcpServer = ConfigurationManager.AppSettings["TcpServer"];
    static readonly int TcpServerPort = Convert.ToInt32(ConfigurationManager.AppSettings["TcpServerPort"]);

    public static async Task<XElement> SendAsync(XElement request)
    {
      using (var client = new TcpClient())
      {
        await client.ConnectAsync(TcpServer, TcpServerPort);
        var request_bytes = Encoding.ASCII.GetBytes(request.ToString());
        using (var stream = client.GetStream())
        {
          await stream.WriteAsync(request_bytes, 0, request_bytes.Length);
          var buffer = new byte[1000];
          var response_bytes = await stream.ReadAsync(buffer, 0, buffer.Length);
          var response_string = Encoding.ASCII.GetString(buffer, 0, response_bytes);
          return XElement.Parse(response_string);
        }
      }
    }

    public static XElement Send(XElement request)
    {
      return SendAsync(request).Result;
    }
  }
}
