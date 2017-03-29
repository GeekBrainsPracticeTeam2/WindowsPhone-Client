using System;
using System.Collections.Generic;
using WindowsUWP.Helpers;

namespace WindowsUWP.models
{
    public class TotalStatis
    {
        public int siteId { get; set; }
        public List<PersonStats> statistics { get; set; }

        public string siterUrl
        {
            get
            {
                if(siterUrl == null)
                {
                    siterUrl = DBhelper.GetSiteUrl(siteId);
                    return siterUrl;
                }
                return siterUrl;
            }
            protected set
            {
                
            }
        }
    }
}
