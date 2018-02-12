using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitest180127
{
    public class IsBirthday
    {
        //<summary>
        //使用時會出現解釋
        //</summary>
        public string Is91Birthday()
        {
            var today = GetToday();
            if (today.Day == 28 && today.Month == 11)
                return "Happy Birthday";

            return "No, Sorry";
        }

        protected virtual DateTime GetToday()
        {
            return DateTime.Today;
        }
    }
}
