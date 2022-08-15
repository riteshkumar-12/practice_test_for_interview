using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{

    //Notes

    //1. Lazy loading  is a concept where we delay the loading of object until the point where we need it.Putting in simple
    //words on demand ibject loading rather than loading thr objects unnecessarily.


    //Advantages of lazy loading
    //1. Minimizes startup time of application.
    //2. Application consumes less memory because of on-demand loading.
    //3. Unnecessary database SQL execution is avoided.

    //Lazy Loading is the default behavior of Entity Framework.That means the related entities or child entities are loaded only when it is being accessed for the first time.
    //That means in simple words we can say that Lazy loading simply delaying the loading of related entities until you specifically request for it.


    class LazyLoading
    {

        private Lazy<List<customer>> _cust = null;
    }

    class customer
    {
        public string Name;
        public string Address;
        public string Location;
    }
}
