using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class EmployeeProductivityFormatProvider : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            int rating = (int)arg;

            if (rating == 0)
            {
                return $"{rating} (new employee)";
            }

            if (rating < 0)
            {
                return $"{rating} (Bad employee)";
            }

            else
            {
                return $"{rating} (Good employee)";
            }

        }

        public object GetFormat(Type formatType)
        {
            if(formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            return null;
        }
    }

}
