using System;

namespace InclusionsUtils.Utils
{
    public static class ConditionUtils
    {

        public static bool IsDefendants(String section)
        {
            return section.ToLower().Contains("demandado")
                   || section.ToLower().Contains("acusado")
                   || section.ToLower().Contains("demandada");
        }
        
        public static bool IsComplainants(String section)
        {
            return section.ToLower().Contains("demandante")
                   || section.ToLower().Contains("accionante")
                   || section.ToLower().Contains("actor")
                   || section.ToLower().Contains("deudor");
        }
        
    }
}