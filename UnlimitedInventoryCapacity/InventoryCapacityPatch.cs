using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.Library;

namespace UnlimitedInventoryCapacity
{
    [HarmonyPatch(typeof(DefaultInventoryCapacityModel), "CalculateInventoryCapacity")]
    public class InventoryCapacityPatch
    {
        private static bool Prefix(ref ExplainedNumber __result)
        {
            ExplainedNumber explainedNumber = new ExplainedNumber(Main.InventoryCapacity);
            __result = explainedNumber;
            return false;
        }
    }
}
