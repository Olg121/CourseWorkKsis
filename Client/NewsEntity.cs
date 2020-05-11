using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class NewsEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Text { get; set; }
        public long Id { get; set; }
        public override string ToString()
        {
            return Name; 
        }
    }

    public class NewsEntityLite
    {
        public string Name { get; set; }
        public long Id { get; set; }
    }
}
