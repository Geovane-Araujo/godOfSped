
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF700
{
    public String REG { get; } = "F700";
    
    public String IND_ORI_DED { get; set; } = "";
    
    public String IND_NAT_DED { get; set; } = "";
    
    public String VL_DED_PIS { get; set; } = "";
    
    public String VL_DED_COFINS { get; set; } = "";
    
    public String VL_BC_OPER { get; set; } = "";
    
    public String CNPJ { get; set; } = "";
    
    public String INF_COMP { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_ORI_DED}|{IND_NAT_DED}|{VL_DED_PIS}|{VL_DED_COFINS}|{VL_BC_OPER}|{CNPJ}|" +
                     $"{INF_COMP}|";
        return ret;
    }
}