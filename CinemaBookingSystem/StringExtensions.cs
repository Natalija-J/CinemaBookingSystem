using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaBookingSystem
{
    public static class StringExtensions
    {
        //has to be static (class and methods!)
        //trying out extensions

        public static bool IsPasswordOK(this string text)
        {
            return !String.IsNullOrEmpty(text) && text.Length >= 8;
        }

    }
}
