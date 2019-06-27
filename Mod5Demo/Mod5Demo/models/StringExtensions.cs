using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo.models
{
    static class StringExtensions
    {
        static public string PigLatin(this string Info)
        {
            string result = Info.Substring(1) + Info.Substring(0, 1) + "ay";
            return result;
        }

    }
}
