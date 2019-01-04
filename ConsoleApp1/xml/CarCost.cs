using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml
{
    class CarCost
    {
        public CarCost(string id, string uptime, string downtime, float price)
        {
            this.ID = id;
            this.UpTime = uptime;
            this.DownTime = downtime;
            this.Price = price;
        }
        public string ID { get; set; }
        public string UpTime { get; set; }
        public string DownTime { get; set; }
        public float Price { get; set; }

    }
}
