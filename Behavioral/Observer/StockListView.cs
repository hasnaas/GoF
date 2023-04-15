using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    internal class StockListView : Observer
    {
        private List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void UpdateView()
        {
            Console.WriteLine("StockListView content");
            foreach (Stock stock in stocks)
                Console.WriteLine(stock);
        }
        public void Update()
        {
            Console.WriteLine("Updating stocklistview data");
            UpdateView();
        }
    }
}
