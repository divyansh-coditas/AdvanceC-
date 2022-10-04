using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Books
    {
        public List<Books> book = new List<Books>();
        public string Title { get; set; }

        public int price { get; set; }
    }
}
