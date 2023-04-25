using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class GmailAdapter : EmailProvider
    {
        private GmailClient _client=new GmailClient();

        public void DownloadEmails()
        {
            _client.Connect();
            _client.GetEmails();
            _client.Disconnect();
        }
    }
}
