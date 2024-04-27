namespace ConsoleHelper;

using HarmonyLib;

[HarmonyPatch(typeof(Terminal))]
static class TerminalPatch {
  [HarmonyPrefix]
  [HarmonyPatch(nameof(Terminal.IsCheatsEnabled))]
  static bool IsCheatsEnabledPrefix(ref bool __result) {
    __result = true;
    return false;
  }

  [HarmonyPrefix]
  [HarmonyPatch(nameof(Terminal.InputText))]
  static void InputTextPrefix() {
    ConsoleHelper.IsInputtingText = true;
  }

  [HarmonyPostfix]
  [HarmonyPatch(nameof(Terminal.InputText))]
  static void InputTextPostfix() {
    ConsoleHelper.IsInputtingText = false;
  }
}
