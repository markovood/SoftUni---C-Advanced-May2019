using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        private int daysDifference;


        public int CalculateDifference(string firstDate, string secondDate)
        {
            DateTime date1;
            DateTime date2;
            if (DateTime.TryParse(firstDate, out date1))
            {
                if (DateTime.TryParse(secondDate, out date2))
                {
                    return Math.Abs((int)(date1 - date2).TotalDays);
                }
                else
                {
                    throw new ArgumentException("Date cannot be parsed...", "secondDate");
                }
            }
            else
            {
                throw new ArgumentException("Date cannot be parsed...", "firstDate");
            }
        }
    }
}
