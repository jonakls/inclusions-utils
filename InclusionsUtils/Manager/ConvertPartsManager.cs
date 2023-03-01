using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InclusionsUtils.Utils;

namespace InclusionsUtils.Manager
{
    public static class ConvertPartsManager
    {
        public static Dictionary<string, string> FromJudicialBranch(String parts)
        {
            Dictionary<string, string> cachedParts = new Dictionary<string, string>();
            List<String> defendants = new List<String>();
            List<String> complainants = new List<String>();

            String[] partsArray = parts.Split('\n');
            foreach (String part in partsArray)
            {
                String[] realPart = part.Split('	');
                if (realPart.Length != 2)
                    continue;
                
                if (ConditionUtils.IsDefendants(realPart[0]))
                {
                    defendants.Add(realPart[1].ToUpper()
                    );
                }
                
                if (ConditionUtils.IsComplainants(realPart[0]))
                {
                    complainants.Add(realPart[1].ToUpper()
                    );
                }
            }
            
            cachedParts["DEMANDADO"] = TextUtils.ConvertText(string.Join(" | ", defendants));
            cachedParts["DEMANDANTE"] = TextUtils.ConvertText(string.Join(" | ", complainants));

            return cachedParts;
        }
        
        public static Dictionary<string, string> FromSamai(String parts)
        {
            Dictionary<string, string> cachedParts = new Dictionary<string, string>();
            List<String> defendants = new List<String>();
            List<String> complainants = new List<String>();

            String[] partsArray = parts.Split('\n');
            foreach (String part in partsArray)
            {
                String[] realPart = part.Split('	');
                if (realPart.Length != 4)
                    continue;

                if (ConditionUtils.IsDefendants(realPart[0]))
                {
                    defendants.Add(realPart[2].ToUpper()
                    );
                }
                
                if (ConditionUtils.IsComplainants(realPart[0]))
                {
                    complainants.Add(realPart[2].ToUpper()
                    );
                }
            }
            
            cachedParts["DEMANDADO"] = TextUtils.ConvertText(string.Join(" | ", defendants));
            cachedParts["DEMANDANTE"] = TextUtils.ConvertText(string.Join(" | ", complainants));

            return cachedParts;
        }

        public static Dictionary<string, string> FromTyba(String parts)
        {
            Dictionary<string, string> cachedParts = new Dictionary<string, string>();
            List<String> defendants = new List<String>();
            List<String> complainants = new List<String>();
            String[] partsArray = parts.Split('\n');
            
            foreach (String part in partsArray)
            {
                String[] realPart = part.Split('	');
                if (realPart.Length != 6)
                    continue;

                if (ConditionUtils.IsDefendants(realPart[0]))
                {
                    defendants.Add(realPart[4].ToUpper()
                    );
                }
                
                if (ConditionUtils.IsComplainants(realPart[0]))
                {
                    complainants.Add(realPart[4].ToUpper()
                    );
                }
            }
            
            cachedParts["DEMANDADO"] = TextUtils.ConvertText(string.Join(" | ", defendants));
            cachedParts["DEMANDANTE"] = TextUtils.ConvertText(string.Join(" | ", complainants));
            
            return cachedParts;
        }
        
        public static Dictionary<string, string> FromCentury(String parts)
        {
            MessageBox.Show("No implementado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }
    }
}