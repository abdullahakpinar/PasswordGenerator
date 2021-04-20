using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class PasswordGeneratorRequest
    {
        public PasswordGeneratorRequest()
        {
            MinLength = 5;
            MaxLength = 10;
            IsUpperChars = true;
            IsLowerChars = true;
            IsSpecialChars = true;
        }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public bool IsUpperChars { get; set; }
        public bool IsLowerChars { get; set; }
        public bool IsNumberChars { get; set; }
        public bool IsSpecialChars { get; set; }
        public string AllowChars { get; set; }
        public string DenyChars { get; set; }


    }
}
