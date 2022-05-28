
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1900
{
    public String REG { get; } = "1900";
    
    public String CNPJ { get; set; } = "";
    
    public String COD_MOD { get; set; } = "";
    
    public String SER { get; set; } = "";
    
    public String SUB_SER { get; set; } = "";
    
    public String COD_SIT { get; set; } = "";
    
    public String VL_TOT_REC { get; set; } = "";
    
    public String QUANT_DOC { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String CFOP { get; set; } = "";
    
    public String INF_COMPL { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CNPJ}|{COD_MOD}|{SER}|{SUB_SER}|{COD_SIT}|{VL_TOT_REC}|" +
                     $"{QUANT_DOC}|{CST_PIS}|{CST_COFINS}|{CFOP}|{INF_COMPL}|{COD_CTA}|";
        
        return ret;
    }
}