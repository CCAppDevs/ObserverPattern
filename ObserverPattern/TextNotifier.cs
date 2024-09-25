using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class TextNotifier : ISchoolStatusSubscriber
    {
        public void Update(bool state)
        {
            Console.WriteLine("The School is open: " + state);

            if (!state)
            {
                Console.WriteLine("School is closed. Sending Text Message.");
            }
        }
    }
}
