using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class EmailClient
    {
        private List<EmailProvider> providers = new List<EmailProvider>();

        public void AddProvider(EmailProvider provider)
        {
            providers.Add(provider);
        }

        public void DownloadEmails()
        {
            foreach (var provider in providers)
                provider.DownloadEmails();
        }
    }
}
