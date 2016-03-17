using System;
using System.Web.Optimization;


[assembly: WebActivator.PostApplicationStartMethod(
    typeof(MvcApplication2.App_Start.MovieConfig), "PreStart")]

namespace MvcApplication2.App_Start
{
    public static class MovieConfig
    {
        public static void PreStart()
        {
            // Add your start logic here
            MovieBundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}