
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM300
{
    public String REG { get; } = "M300";
    
    public String COD_CONT { get; set; } = "";
    
    public String VL_CONT_APUR_DIFER { get; set; } = "";
    
    public String NAT_CRED_DESC { get; set; } = "";
    
    public String VL_CRED_DESC_DIFER { get; set; } = "";
    
    public String VL_CONT_DIFER_ANT { get; set; } = "";
    
    public String PER_APUR { get; set; } = "";
    
    public String DT_RECEB { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_CONT}|{VL_CONT_APUR_DIFER}|{NAT_CRED_DESC}|{VL_CRED_DESC_DIFER}|{VL_CONT_DIFER_ANT}|{PER_APUR}|" +
                     $"{DT_RECEB}|";
        
        return ret;
    }
}