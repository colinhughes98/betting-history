using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BettingAPI.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> NullSafeIEnumerable<T>(this IEnumerable<T> obj)
        {
            if (obj == null) yield break;
            foreach (T item in obj)
            {
               yield return item;
            }
        }
    }
}