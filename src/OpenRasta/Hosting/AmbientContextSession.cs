using System;
using System.Collections.Generic;
using System.Text;
using OpenRasta.Web;

namespace OpenRasta.Hosting
{
    public class AmbientContextSession : IContextSession
    {
        public object this[string key]
        {
            get
            {
                return AmbientContext.Current[key];
            }
            set
            {
                AmbientContext.Current[key] = value;
            }
        }

        public int Timeout
        {
            get
            {
                return 0;
            }
            set
            {
                //do nothing
            }
        }
    }
}
