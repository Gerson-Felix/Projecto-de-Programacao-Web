using System.Web.Optimization;

namespace Vitty.App_Start
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Assets/js/jquery-{version}.js",
                        "~/Assets/js/bootbox.js",
                        "~/Assets/js/bootstrap.js",
                        "~/Assets/js/dataTables/jquery.datatables.js",
                        "~/Assets/js/dataTables/datatables.bootstrap.js",
                        "~/Assets/js/typeahead.bundle.js",
                        "~/Assets/js/toastr.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Assets/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Assets/modernizr-*"));
            
            bundles.Add(new StyleBundle("~/css").Include(
                      
                      "~/Assets/css/bootstrap.css",
                      "~/Assets/css/bootstrap-theme.css",
                      "~/Assets/css/dataTables/css/dataTables.bootstrap.css",
                      "~/Assets/css/typeahead.css",
                      "~/Assets/css/toastr.css",
                      "~/Assets/css/site.css"));
        }
    }
}
