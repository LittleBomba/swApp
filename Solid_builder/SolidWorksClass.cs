using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace Solid_builder
{
    internal class SolidWorksClass
    {
        private static SldWorks swApp;

        private SolidWorksClass() {

        }

        internal async static Task<SldWorks> getApplicationAsync() {
            if (swApp == null) {
                return await Task<SldWorks>.Run(() =>
                {
                    swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application")) as SldWorks;
                    swApp.Visible = true;

                    return swApp;
                });
            }

            return swApp;
        }

        //internal static SldWorks getApplication()
        //{
        //    if (swApp == null)
        //    {
        //        swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application")) as SldWorks;
        //        swApp.Visible = true;

        //        return swApp;
        //    }

        //    return swApp;
        //}

        internal static void Dipose() {
            if (swApp != null) {
                swApp.ExitApp();
                swApp = null;
            }
        }
    }

}
