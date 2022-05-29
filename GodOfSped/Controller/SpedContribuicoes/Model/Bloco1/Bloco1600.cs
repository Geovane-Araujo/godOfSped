
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1600
{
    public String REG { get; } = "1600";
    
    public String PER_APUR_ANT { get; set; } = "";
    
    public String NAT_CONT_REC { get; set; } = "";
    
    public String VL_CONT_APUR { get; set; } = "";
    
    public String VL_CRED_COFINS_DESC { get; set; } = "";
    
    public String VL_CONT_DEV { get; set; } = "";
    
    public String VL_OUT_DED { get; set; } = "";
    
    public String VL_CONT_EXT { get; set; } = "";
    
    public String VL_MUL { get; set; } = "";
    
    public String VL_JUR { get; set; } = "";
    
    public String DT_RECOL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{PER_APUR_ANT}|{NAT_CONT_REC}|{VL_CONT_APUR}|{VL_CRED_COFINS_DESC}|{VL_CONT_DEV}|{VL_OUT_DED}|" +
                     $"{VL_CONT_EXT}|{VL_MUL}|{VL_JUR}|{DT_RECOL}|";
        
        return ret;
    }
}