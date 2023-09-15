using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.DomainModel
{
    public static class ItemSplitter
    {
        public static List<int> ToSplitInt(this string Content)
        {
            var ContentSplit = Content.Split(",");
            List<int> ContentSplitInt = new List<int>();
            foreach (var item in ContentSplit)
            {
                if (item != "")
                {
                    var ConvertedValue = Convert.ToInt32(item);
                    ContentSplitInt.Add(ConvertedValue);
                }

            }
            return ContentSplitInt;
        }
    }
}
