using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;

namespace Umbraco616.Umbraco
{
    public class FoundationApplicationBase: UmbracoApplicationBase
    {
        protected override IBootManager GetBootManager()
        {
            return new FoundationBootManager(this);
        }

        public void Start(object sender, EventArgs e)
        {
            base.Application_Start(sender, e);
        }
    }
}