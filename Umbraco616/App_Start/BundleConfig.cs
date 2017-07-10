﻿using System.Web.Optimization;

namespace Umbraco616
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/styles")
                .Include("~/Content/Style.css"));

            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include("~/Scripts/Script.js"));
        }
    }
}