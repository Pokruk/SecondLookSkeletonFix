using HarmonyLib;

namespace SecondLookSkeletonFix.Patches {
    [HarmonyPatch(typeof(SecondLookSkeleton))]
    [HarmonyPatch("SetTappedState", MethodType.Normal)]
    internal class GhostNotLoadedFix {
        public static bool Prefix(SecondLookSkeleton __instance) {
            if (__instance.spookyText == null) {
                return false;
            }
            return true;
        }
    }
}
