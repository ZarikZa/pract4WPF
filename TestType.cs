using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testiki
{
    internal class TestType
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Variant1 { get; set; }
        public string Variant2 { get; set; }
        public string Variant3 { get; set; }
        public Pravilno TrueOtvet { get; set; } 

        public TestType(string name, string description, string variant1, string variant2, string variant3, Pravilno trueOtvet)
        {
            Name = name;
            Description = description;
            Variant1 = variant1;
            Variant2 = variant2;
            Variant3 = variant3;
            TrueOtvet = trueOtvet;
        }
    }                            
}                                
                                 