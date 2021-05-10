//#define APPENDTIME
//#undef APPENDTIME

using System;
using System.Reflection;

namespace Utilities
{
    public static class TypeUtils
    {
        public static string GetNamespace(object o)
        {
            string result = "";

#if DEBUG
            result += "[DEBUG BUILD] ";
#endif

#if RELEASE
            result += "[RELEASE BUILD] ";
#endif

#if NETCOREAPP2_0
            result += $"{o.GetType().GetTypeInfo().Namespace} (NETCOREAPP2_0 dll)";
#elif NET40
            result +=$"{o.GetType().Namespace} (NET40 dll)";
#else
            throw new NotSupportedException();
#endif

#if APPENDTIME
            result += $" Time:{DateTime.Now.ToShortTimeString()}";
#endif

            AppendDate(ref result);

            return result;
        }

        private static void AppendDate(ref string result)
        {
            result += " " + DateTime.Now.ToShortDateString();
        }
    }
} 
