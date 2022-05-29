
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM510
{
    public String REG { get; } = "M510";
    
    public String DET_VALOR_AJ { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String DET_BC_CRED { get; set; } = "";
    
    public String DET_ALIQ { get; set; } = "";
    
    public String DT_OPER_AJ { get; set; } = "";
    
    public String DESC_AJ { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{DET_VALOR_AJ}|{CST_COFINS}|{DET_BC_CRED}|{DET_ALIQ}|{DT_OPER_AJ}|{DESC_AJ}|" +
                     $"{COD_CTA}|{INFO_COMPL}|";
        
        return ret;
    }
}