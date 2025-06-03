using System.Collections.Generic;
using System.Linq;

namespace CountItemOccurrencesApi.Helpers
{
    public static class ItemCounter
    {
        public static Dictionary<string, int> CountItems(List<string> items)
        {
            return items.GroupBy(i => i)
                        .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}
