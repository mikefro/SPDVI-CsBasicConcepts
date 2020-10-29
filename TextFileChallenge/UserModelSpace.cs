using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModelSpace
{
    class UserModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Boolean IsAlive { get; set; }

        public String DisplayText 
        {
            get
            {
                string aliveStatus = "is dead";

                if (IsAlive == true)
                {
                    aliveStatus = "is alive";
                }

                return $"{ LastName } {FirstName } is {Age} and {aliveStatus}";
            }    
        }
    }
}
