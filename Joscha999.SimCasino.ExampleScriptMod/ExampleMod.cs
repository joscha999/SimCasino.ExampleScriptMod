using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimCasino.Modding;
using UnityEngine;

namespace Joscha999.SimCasino.ExampleScriptMod {
	public class ExampleMod : BaseMod {
		public override string InternalName => "Joscha999.ExampleScriptMod";

		public override void OnTick() {
			if (Game.current != null && Input.GetKey(KeyCode.LeftShift)) {
				if (Input.GetKeyDown(KeyCode.PageUp))
					Game.current._money.current_balance += 100_000;
				if (Input.GetKeyDown(KeyCode.PageDown))
					Game.current._money.current_balance -= 100_000;
			}
		}
	}
}