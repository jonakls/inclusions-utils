using System;
using System.Collections.Generic;
namespace InclusionsUtils.Manager
{
    public class InclusionUtilityManager
    {

        public Dictionary<string, string> ConvertParts(String parts)
        {
            Dictionary<string, string> cachedParts = new Dictionary<string, string>();
            List<String> defendants = new List<String>();
            List<String> complainants = new List<String>();

            String[] partsArray = parts.Replace("\r", "").Split('\n');
            foreach (String part in partsArray)
            {
                String[] realPart = part.Split('	');
                if (realPart.Length != 2)
                    continue;

                switch(realPart[0].ToLower())
                {
                    case "demandado":
                        defendants.Add(realPart[1]);
                        break;
                    case "demandante":
                        complainants.Add(realPart[1]);
                        break;
                }
            }

            cachedParts["DEMANDADO"] = string.Join(" | ", defendants);
            cachedParts["DEMANDANTE"] = string.Join(" | ", complainants);

            return cachedParts;
        }


    }
}
