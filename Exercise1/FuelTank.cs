using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class FuelTank
    {
        private int capacity;
        private int amount;
        private int get;
        public FuelTank(int capacity)

        {
            this.capacity = capacity;
        }

        public void Fill(int amount)
        {
            this.amount = amount;
        }
        
        public int GetAmount(int get)
        {
            return 0;
        }    
        
    }
}
