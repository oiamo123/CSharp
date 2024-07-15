using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /// <summary>
    /// repository of static data access methods for working with States table 
    /// in MMABooks database
    /// </summary>
    public static class StateDB
    {
        /// <summary>
        /// retries all states ordered alphabetically by name
        /// </summary>
        /// <returns>list of states</returns>
        public static List<State> GetStates()
        {
            using(MMABooksContext db = new MMABooksContext())
            {
                return db.States.OrderBy(s => s.StateName).ToList();
            }
        }

    }
}
