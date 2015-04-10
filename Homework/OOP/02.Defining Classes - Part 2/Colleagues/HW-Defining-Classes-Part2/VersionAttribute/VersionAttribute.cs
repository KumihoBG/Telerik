using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    /* 11.
  Create a [Version] attribute that can be applied to structures, 
  classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11)*/
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Struct)]
    public class VersionAttribute : Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public string GetVersion
        {
            get
            {
                return String.Format("{0}.{1}", major, minor);
            }
        }
    }
}
