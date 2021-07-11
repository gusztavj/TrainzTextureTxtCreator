using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainzTextureTxtCreator
{
    class AlphaTypes: List<AlphaType>
    {
        public AlphaTypes()
        {
            this.Add(new AlphaType("Omit this tag", AlphaTypeCodes.Omit));
            this.Add(new AlphaType("Explicitly set no alpha (opaque)", AlphaTypeCodes.None));
            this.Add(new AlphaType("Clamped to yes/no (masked)", AlphaTypeCodes.Clamp));
            this.Add(new AlphaType("Blended (semitransparent)", AlphaTypeCodes.Blend));
        }
    }

    enum AlphaTypeCodes  { Omit = 0, None = 1, Clamp = 2, Blend = 3}

    class AlphaType
    {
        public string Name { get; set; }
        public AlphaTypeCodes Value { get; set; }

        public AlphaType(string name, AlphaTypeCodes value)
        {
            Name = name;
            Value = value;
        }
    }
}
