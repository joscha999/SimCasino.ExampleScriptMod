using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace Joscha999.SimCasino.ExampleHarmonyMod {
	[HarmonyPatch(typeof(TechTreeLevel), "ValidateCanAccept")]
	public class TechTreeLevelValidateCanAcceptPatch {
		public static bool Prefix(TechTreeLevel __instance, ref bool __result) {
			Debug.Log("Patch Executed");
			//can't accept if already done/accepted
			if (__instance.isAccepted)
				return false;

			__result = true;
			return false; //skip rest of method
		}
	}
}