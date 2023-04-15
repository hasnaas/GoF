using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    public class StatusBar : Observer
    {
        private List<Stock> stocks=new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
            stock.AddObserver(this);
        }
        public void UpdateView()
        {
            Console.WriteLine("Status Bar content");
            foreach (Stock stock in stocks)
                Console.WriteLine(stock);
        }
        public void Update()
        {
            Console.WriteLine("Updating status bar data");
            UpdateView();
        }
    }
}
