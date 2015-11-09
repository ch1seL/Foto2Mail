using System.Web.Optimization;
using BundleTransformer.Core.Builders;
using BundleTransformer.Core.Bundles;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Resolvers;
using BundleTransformer.Core.Transformers;

namespace eOrders.WebSite
{

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            var cssTransformer = new StyleTransformer();
            var jsTransformer = new ScriptTransformer();

            var cssBundle = new StyleBundle("~/bundles/css");
            cssBundle.Include(
                "~/Content/bootstrap/bootstrap.less",
                "~/Content/font-awesome/font-awesome.less",
                "~/Content/animations/animations.css",
                "~/Content/Site.less"
                );
            cssBundle.Transforms.Add(cssTransformer);
            bundles.Add(cssBundle);

            var jqueryBundle = new ScriptBundle("~/bundles/jquery");
            jqueryBundle.Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-migrate-{version}.js"
                );
            jqueryBundle.Transforms.Add(jsTransformer);
            bundles.Add(jqueryBundle);

            var jqueryBackstretchBundle = new ScriptBundle("~/bundles/jqueryBackstretch");
            jqueryBackstretchBundle.Include("~/Scripts/jquery.backstretch.js");
            jqueryBackstretchBundle.Transforms.Add(jsTransformer);
            bundles.Add(jqueryBackstretchBundle);


            var jqueryAppearBundle = new ScriptBundle("~/bundles/jqueryAppear");
            jqueryAppearBundle.Include("~/Scripts/jquery.appear.js");
            jqueryAppearBundle.Transforms.Add(jsTransformer);
            bundles.Add(jqueryAppearBundle);


            var jqueryvalBundle = new ScriptBundle("~/bundles/jqueryval");
            jqueryvalBundle.Include(
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/jquery.validate-vsdoc.js");
            jqueryvalBundle.Transforms.Add(jsTransformer);
            bundles.Add(jqueryvalBundle);

            var modernizrBundle = new ScriptBundle("~/bundles/modernizr");
            modernizrBundle.Include("~/Scripts/modernizr-*");
            modernizrBundle.Transforms.Add(jsTransformer);
            bundles.Add(modernizrBundle);

            var bootstrapBundle = new ScriptBundle("~/bundles/bootstrap");
            bootstrapBundle.Include("~/Scripts/bootstrap.js");
            bootstrapBundle.Transforms.Add(jsTransformer);
            bundles.Add(bootstrapBundle);

            var otherScriptsBundle = new ScriptBundle("~/bundles/otherScripts");
            otherScriptsBundle.Include(
                "~/Scripts/jquery.easing.js",
                "~/Scripts/jquery.fittext.js",
                "~/Scripts/wow.js",
                "~/Scripts/creative.js"
                );
            otherScriptsBundle.Transforms.Add(jsTransformer);
            bundles.Add(otherScriptsBundle);

            //BundleTable.EnableOptimizations = true;
        }
    }
}