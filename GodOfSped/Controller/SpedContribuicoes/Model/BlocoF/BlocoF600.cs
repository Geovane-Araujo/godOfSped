
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF600
{
    public String REG { get; } = "F600";
    
    public String IND_NAT_RET { get; set; } = "";
    
    public String DT_RET { get; set; } = "";
    
    public String VL_BC_RET { get; set; } = "";
    
    public String VL_RET { get; set; } = "";
    
    public String COD_REC { get; set; } = "";
    
    public String IND_NAT_REC { get; set; } = "";
    
    public String CNPJ { get; set; } = "";
    
    public String VL_RET_PIS { get; set; } = "";
    
    public String VL_RET_COFINS { get; set; } = "";
    
    public String IND_DEC { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_NAT_RET}|{DT_RET}|{VL_BC_RET}|{VL_RET}|{COD_REC}|{IND_NAT_REC}|" +
                     $"{CNPJ}|{VL_RET_PIS}|{VL_RET_COFINS}|{IND_DEC}|";
        return ret;
    }
}