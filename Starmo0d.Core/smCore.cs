using System;
using StardewModdingAPI;

namespace Starmo0d.Core
{
    internal class smCore : Mod
    {
        public override void Entry(IModHelper helper)
        {
            Monitor.Log(helper.Translation.Get("common.starting"), LogLevel.Debug);

            I18n.Init(helper.Translation);


            Monitor.Log(helper.Translation.Get("common.started"), LogLevel.Debug);
        }
    }
}
