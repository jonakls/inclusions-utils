using System;
using System.Collections.Generic;
using InclusionsUtils.Utils;

namespace InclusionsUtils.Manager
{
    public class InclusionUtilityManager
    {
        public Dictionary<string, string> ConvertParts(String parts, String option)
        {
            switch (option.ToLower())
            {
                case "rama judicial":
                    return ConvertPartsManager.FromJudicialBranch(parts);
                case "samai":
                    return ConvertPartsManager.FromSamai(parts);
                case "siglo xxi":
                    return ConvertPartsManager.FromCentury(parts);
                case "tyba":
                    return ConvertPartsManager.FromTyba(parts);
                default:
                    return ConvertPartsManager.FromJudicialBranch(parts);
            }
        }
    }
}
