using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotPOE
{
    class ActivityLog
    {
        public static List<string> LogEntries = new List<string>();


        public static void AddEntry(string entry)
        {
            LogEntries.Add($"{LogEntries.Count + 1}. {entry}");

        }
        public static List<string> getRecentEntries()
        {
            int count = LogEntries.Count;
            int startIndex = Math.Max(0, count - 10);
            var recentEntries = LogEntries.GetRange(startIndex, count - startIndex);

            List<String> Renumber = new List<string>();
            for (int i = 0; i < recentEntries.Count; i++)
            {
                Renumber.Add($"{i + 1}. {recentEntries[i]}");
            }
            return Renumber;
        }
        public static void ClearLog()
        {
            LogEntries.Clear();
        }
    }
}
