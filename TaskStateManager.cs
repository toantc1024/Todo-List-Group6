using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    public static class TaskStateManager
    {
        private static Dictionary<string, bool> checkedItems = new Dictionary<string, bool>();

        public static bool GetCheckedState(string key)
        {
            return checkedItems.ContainsKey(key) && checkedItems[key];
        }

        public static void SetCheckedState(string key, bool state)
        {
            checkedItems[key] = state;
        }
        public static void Clear()
        {
            checkedItems.Clear();
        }
    }
}
