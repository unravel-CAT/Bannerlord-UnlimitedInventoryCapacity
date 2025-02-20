using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using HarmonyLib;
using Newtonsoft;
using TaleWorlds.MountAndBlade;
using Newtonsoft.Json;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using Module = TaleWorlds.MountAndBlade.Module;

namespace UnlimitedInventoryCapacity
{
    public class Main : MBSubModuleBase
    {
        public static int InventoryCapacity = 999999999;
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            try
            {
                new Harmony("UnlimitedInventoryCapacity").PatchAll();
            }
            catch (Exception ex)
            {
                InformationManager.DisplayMessage(new InformationMessage("UnlimitedInventoryCapacity error"));
            }
        }
    }
}
