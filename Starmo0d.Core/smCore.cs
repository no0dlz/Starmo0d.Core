using System;
using StardewModdingAPI;

namespace Starmo0d.Core
{
    internal class SMCore : Mod
    {
        public override void Entry(IModHelper helper)
        {
            ///// OLD WAY

            //Monitor.Log(helper.Translation.Get("common.starting"), LogLevel.Debug);
            // .... start logic ....
            //Monitor.Log(helper.Translation.Get("common.started"), LogLevel.Debug);




            ///// NEW WAY
            
            // initialize mod translation class builder
            I18n.Init(helper.Translation);

            Monitor.Log(I18n.Common_Starting(), LogLevel.Info);


            // .... start logic ....
            global::System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));


            Monitor.Log(I18n.Common_Started(), LogLevel.Info);
        }
    }
}
