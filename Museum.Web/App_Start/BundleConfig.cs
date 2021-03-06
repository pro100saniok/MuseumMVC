﻿using System.Web.Optimization;

namespace Museum.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // slider js and css.
            bundles.Add(new ScriptBundle("~/bundles/slider").Include(
                "~/Scripts/JS/Slider/jquery.flexslider-min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/slider").Include(
                "~/Content/slider.css"
                ));
            //fancybox css and js.
            bundles.Add(new StyleBundle("~/Content/fancybox").Include(
                 "~/Content/fancybox/jquery.fancybox.css"));

            bundles.Add(new ScriptBundle("~/bundles/fancybox").Include(
              "~/Scripts/JS/Gallery/jquery.fancybox.js"));

            //gallery css and js.
            bundles.Add(new StyleBundle("~/Content/gallery").Include(
                  "~/Content/gallery.css"));

            bundles.Add(new ScriptBundle("~/bundles/gallery").Include(
            "~/Scripts/JS/Gallery/gallery.js"));

            //bookblock css and js.
            bundles.Add(new StyleBundle("~/Content/bookblock").Include(
                "~/Content/bookblock/bookblock.css"));

            bundles.Add(new ScriptBundle("~/bundles/bookblock").Include(
                "~/Scripts/JS/Bookblock/jquery.bookblock*"));

            //panorama css and js.
            bundles.Add(new StyleBundle("~/Content/panorama").Include(
                "~/Content/panorama/jquery.panorama.css"));

            bundles.Add(new ScriptBundle("~/bundles/panorama").Include(
            "~/Scripts/JS/Panorama/jquery.panorama.js"));

            bundles.Add(new ScriptBundle("~/bundles/advancedpanorama").Include(
            "~/Scripts/JS/Panorama/jquery.advanced-panorama.js"));
        }
    }
}
