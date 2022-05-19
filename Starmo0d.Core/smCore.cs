using System;
using StardewModdingAPI;

namespace Starmo0d.Core
{
    internal class SMCore : Mod
    {
        public override void Entry(IModHelper helper)
        {
            // initialize mod translation class builder
            I18n.Init(helper.Translation);

            Monitor.Log(I18n.General_Starting(), LogLevel.Info);


            // .... start logic ....
            global::System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));


            Monitor.Log(I18n.General_Started(), LogLevel.Info);
        }
    }
}
