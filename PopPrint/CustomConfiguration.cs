using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;

namespace PopPrint
{
    class CustomConfiguration : IConfigurationSectionHandler
    {
        public object Create(object parent, object configContext, XmlNode section)
        {
            throw new NotImplementedException();
        }
    }
}
