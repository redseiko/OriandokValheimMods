namespace ConsoleHelper;

using HarmonyLib;

[HarmonyPatch(typeof(ZNet))]
static class ZNetPatch {
  [HarmonyPostfix]
  [HarmonyPatch(nameof(ZNet.IsServer))]
  static void IsServerPostfix(ref bool __result) {
    if (ConsoleHelper.IsInputtingText) {
      __result = true;
    }
  }
}
