namespace ConsoleHelper;

using System.Reflection;

using BepInEx;

using HarmonyLib;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public sealed class ConsoleHelper : BaseUnityPlugin {
  public const string PluginGuid = "RandyKnapp.Valheim.ConsoleHelper";
  public const string PluginName = "ConsoleHelper";
  public const string PluginVersion = "1.1.0";

  void Awake() {
    Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), harmonyInstanceId: PluginGuid);
  }

  public static bool IsInputtingText = false;
}
