namespace UnityEngine.AdaptivePerformance
{
    internal static class APLog
    {
        public static bool enabled = false;

        [System.Diagnostics.Conditional("DEVELOPMENT_BUILD")]
        public static void Debug(string format, params object[] args)
        {
            if (enabled)
                UnityEngine.Debug.Log(System.String.Format("Adaptive Performance: " + format, args));
        }
    }
}
