
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM630
{
    public String REG { get; } = "M630";
    
    public String CNPJ { get; set; } = "";
    
    public String VL_VEND { get; set; } = "";
    
    public String VL_NAO_RECEB { get; set; } = "";
    
    public String VL_CONT_DIF { get; set; } = "";
    
    public String VL_CRED_DIF { get; set; } = "";
    
    public String COD_CRED { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CNPJ}|{VL_VEND}|{VL_NAO_RECEB}|{VL_CONT_DIF}|{VL_CRED_DIF}|{COD_CRED}|";
        
        return ret;
    }
}