using HarmonyLib;
using NeosModLoader;
using FrooxEngine.UIX;

namespace FixUIXButton
{
    public class FixUIXButton : NeosMod
    {
        public override string Name => "FixUIXButton";
        public override string Author => "art0007i";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/art0007i/FixUIXButton/";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("me.art0007i.FixUIXButton");
            harmony.PatchAll();

        }
        [HarmonyPatch(typeof(RectTransform), "BuildInspectorUI")]
        class FixUIXButtonPatch
        {
            public static void Postfix(UIBuilder ui, RectTransform __instance)
            {
                var btn = ui.Button("Fix UIX");
                btn.LocalPressed += (button, data) => {
                    AccessTools.Field(__instance.GetType(), "_registeredCanvas").SetValue(__instance, null);
                    AccessTools.Method(__instance.GetType(), "RegisterCanvas").Invoke(__instance, null);
                };
            }
        }
    }
}