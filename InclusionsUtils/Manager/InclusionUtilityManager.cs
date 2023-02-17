using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace InclusionsUtils.Manager
{
    public class InclusionUtilityManager
    {

        private readonly Regex _defendantRegex = new Regex(@"([DEMANDADO])\w+", RegexOptions.IgnoreCase);
        private readonly Regex _complainantRegex = new Regex(@"([DEMANDANTE])\w+", RegexOptions.IgnoreCase);

        public Dictionary<string, string> ConvertParts(String parts)
        {
            Dictionary<string, string> cachedParts = new Dictionary<string, string>();
            List<String> defandants = new List<String>();
            List<String> complainants = new List<String>();


            String[] partsArray = parts.Split('\n');
            foreach (String part in partsArray)
            {
                String[] realPart = part.Split('	');
                if (realPart.Length != 2)
                {
                    continue;
                }

                if (_defendantRegex.IsMatch(realPart[0]))
                {
                    defandants.Add(realPart[1]);
                }

                if (_complainantRegex.IsMatch(realPart[0]))
                {
                    complainants.Add(realPart[1]);
                }
            }

            cachedParts["DEMANDADO"] = string.Join(" | ", defandants);
            cachedParts["DEMANDANTE"] = string.Join(" | ", complainants);

            return cachedParts;
        }


    }
}
