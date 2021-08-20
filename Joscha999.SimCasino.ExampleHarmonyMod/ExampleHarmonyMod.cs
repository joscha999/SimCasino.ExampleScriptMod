using HarmonyLib;
using SimCasino.Modding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Joscha999.SimCasino.ExampleHarmonyMod {
	public class ExampleHarmonyMod : BaseMod {
		public override string InternalName => "Joscha999.ExampleHarmonyMod";

		private Harmony Harmony;

		public override void OnLoad(GameEnvironment gameState) {
			Debug.Log("Loaded ExampleHarmonyMod");
			Harmony = new Harmony(InternalName);
			Harmony.PatchAll(Assembly.GetExecutingAssembly());
		}
	}
}