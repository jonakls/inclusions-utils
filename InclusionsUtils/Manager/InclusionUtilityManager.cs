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
                
                if (realPart[0].ToLower().Contains("demandado"))
                {
                    defendants.Add(realPart[1]
                        .Replace(".", "")
                        .ToUpper()
                    );
                }
                
                if (realPart[0].ToLower().Contains("demandante"))
                {
                    complainants.Add(realPart[1]
                        .Replace(".", "")
                        .ToUpper()
                    );
                }
            }
            
            cachedParts["DEMANDADO"] = ConvertText(string.Join(" | ", defendants));
            cachedParts["DEMANDANTE"] = ConvertText(string.Join(" | ", complainants));

            return cachedParts;
        }
        
        public String ConvertText(String text)
        {
            String convertedText = text;
            foreach (KeyValuePair<string, string> accent in Utils.TextUtils.Accents)
            {
                convertedText = convertedText.Replace(accent.Key, accent.Value);
            }

            return convertedText;
        }
    }
}
