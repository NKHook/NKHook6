using System;
using System.Reflection;
using System.Linq.Expressions;
using Harmony;

namespace NKHook6_Impl.Extensions {
    public static class MethodExt {
        public static HarmonyInstance harmonyInstance = HarmonyInstance.Create("NKHook6.Harmony.Instance");

        public static void Prefix(this MethodInfo methodInfo, MethodInfo prefix) => harmonyInstance.Patch(methodInfo, new(prefix), null, null);

        public static void Postfix(this MethodInfo methodInfo, MethodInfo postfix) => harmonyInstance.Patch(methodInfo, null, new(postfix), null);

        public static void Transpile(this MethodInfo methodInfo, MethodInfo transpiler) => harmonyInstance.Patch(methodInfo, null, null, new(transpiler));
    }
}