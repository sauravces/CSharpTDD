using System.Net.NetworkInformation;

namespace Calculator
{
    public class Date_Object
    {
        private readonly IDNS _dNS;

        public Date_Object(IDNS dNS)
        {
            _dNS = dNS;
        }

        public string SendDNSStatus()
        {
            var DnsSuccess = _dNS.SendDNS();
            if (DnsSuccess)
            {
                return "Success";
            }
            else
            {
                return "Failed";
            }

        }
        public DateTime GetDate()
        {
            return DateTime.Now;
        }

        public PingOptions GetObject() => new PingOptions()
        {
            DontFragment = true,
            Ttl= 1
        };

        public IEnumerable<PingOptions> GetRecentPings()
        {
            IEnumerable<PingOptions> recentOptions = new[]
            {
             new PingOptions()
              {
               DontFragment = true,
               Ttl= 1
              },
             new PingOptions()
              {
               DontFragment = true,
               Ttl= 2
              },
             new PingOptions()
              {
               DontFragment = false,
               Ttl= 3
              }
            };
            return recentOptions;
         }

        public String GetString()
        {
            return "Saurav";
        }
    }
}
