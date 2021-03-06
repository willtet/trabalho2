using System.Collections.Generic;
using System.Web.Optimization;

namespace ProjetoCap.Apresentacao
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            var bundleScript = new ScriptBundle("~/bundles/bootstrap").Include(
                "~/vendor/jquery/jquery_ui/jquery-ui.min.js", // nova dashboard
                "~/Scripts/select2.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootstrap-table-cookie.min.js",
                "~/Scripts/bootstrap-table.js",
                "~/Scripts/bootstrap-table-pt-BR.js",
                "~/Scripts/bootstrap-dialog.min.js",
                "~/Scripts/bootstrap-toggle.js",
                "~/Scripts/bootstrap-editable.js",
                "~/Scripts/bootstrap-table-editable.js",
                "~/vendor/plugins/globalize/src/core.js", // nova dashboard
                "~/vendor/plugins/daterange/daterangepicker.js", // nova dashboard
                "~/vendor/plugins/tagmanager/tagmanager.js", // nova dashboard
                "~/assets/js/utility/utility.js", // nova dashboard
                "~/assets/js/main.js", // nova dashboard
                "~/assets/js/demo.js", // nova dashboard
                "~/vendor/plugins/ladda/ladda.min.js", // nova dashboard

                // bootstrap-datetimepicker
                "~/Scripts/bootstrap-datetimepicker.min/moment-with-locales.js",
                "~/Scripts/bootstrap-datetimepicker.min/moment-timezone-with-data-2010-2020.min.js",
                "~/Scripts/bootstrap-datetimepicker.min/bootstrap-datetimepicker.js",

                "~/Scripts/toastr.js",
                "~/Scripts/linq.min.js",
              
                "~/Scripts/jquery.mask.js",
                "~/Scripts/TrataDataJson.js",
                "~/Scripts/jquery.maskMoney.js",
                "~/Scripts/bootstrap-filestyle.js",
                "~/Scripts/waitMe.js",
                "~/Scripts/genericos/CarregandoLoadGif.js",
                "~/Scripts/genericos/BotaoDireitoMouse.js", // PROJ71-253 - Chiprauski - 13/07/2018.
                "~/Scripts/genericos/NoBack.js",            // PROJ71-253 - Chiprauski - 13/07/2018.
                "~/Scripts/genericos/GerarRelatorio.js",
                "~/Scripts/jquery-migrate-1.0.0.js",
                "~/Scripts/accounting.js",
                "~/Scripts/numeral.js",
                "~/Scripts/numeral-pt-br.js",   
                "~/Scripts/languages.js",
                "~/Scripts/genericos/TrataNumerico.js",
                "~/Scripts/timerjs.js",
                "~/Scripts/respond.js",
                "~/Scripts/genericos/ModalBootstrapDialog.js",
                "~/Scripts/genericos/GerandoTipoRelatorioBase.js",
                "~/Scripts/genericos/MetodosPadrao.js",
                "~/Scripts/Util/CarregarDataAtual.js", // carregando a data atual em javascript
                "~/Scripts/genericos/Ticket.js",
                "~/Scripts/genericos/Utils.js"
              );

            bundleScript.Orderer = new AsIsBundleOrderer();
            bundles.Add(bundleScript);

            var bundleStyle = new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap-table.css",
                "~/Content/bootstrap-table-reorder-rows.css",
                "~/Content/bootstrap-dialog.min.css",
                "~/Content/bootstrap-toggle.css",
                "~/Content/dragtable.css",

                // bootstrap-datetimepicker
                "~/Content/bootstrap-datetimepicker.min/bootstrap-datetimepicker.css",
                "~/Content/bootstrap-datetimepicker-standalone.css",
                
                "~/Content/bootstrap-editable.css",
                "~/Content/animate.css",
                "~/Content/toastr.min.css",
                "~/Content/select2.css",
                "~/assets/admin-tools/admin-plugins/admin-panels/adminpanels.css",
                "~/assets/admin-tools/admin-forms/css/admin-forms.css",  // nova dashboard
                "~/vendor/plugins/daterange/daterangepicker.css", // nova dashboard
                "~/vendor/plugins/ladda/ladda.min.css", // nova dashboard
                "~/assets/skin/default_skin/css/theme.css", // nova dashboard
                "~/Content/font-awesome.css",
                //"~/Content/style.css",
                "~/Content/waitMe.css",
                "~/Content/datepicker.css");

            bundleStyle.Orderer = new AsIsBundleOrderer();
            bundles.Add(bundleStyle);

            BundleTable.EnableOptimizations = false;
        }

        public class AsIsBundleOrderer : IBundleOrderer
        {
            public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
            {
                return files;
            }
        }
    }
}
