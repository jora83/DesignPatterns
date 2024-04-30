using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class BrowseHistory
    {
        private List<string> Urls = new List<string>();

        public IIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public void Push(string url)
        {
            Urls.Add(url);
        }

        public string Pop()
        {
            var lastIndex = Urls.Count - 1;
            var lastUrl = Urls[lastIndex];
            Urls.RemoveAt(lastIndex);

            return lastUrl;
        }

        public class ListIterator : IIterator
        {
            private BrowseHistory history;
            private int index;

            public ListIterator(BrowseHistory history)
            {
                this.history = history;
            }
            public string Current()
            {
                return history.Urls[index];
            }

            public bool HasNext()
            {
                return (index< history.Urls.Count);
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
