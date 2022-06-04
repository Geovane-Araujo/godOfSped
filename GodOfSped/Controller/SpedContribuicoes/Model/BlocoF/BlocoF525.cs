
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF525
{
    public String REG { get; } = "F525";
    
    public String VL_REC { get; set; } = "";
    
    public String IND_REC { get; set; } = "";
    
    public String CNPJ_CPF { get; set; } = "";
    
    public String NUM_DOC { get; set; } = "";
    
    public String COD_ITEM { get; set; } = "";
    
    public String VL_REC_DET { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_REC}|{IND_REC}|{CNPJ_CPF}|{NUM_DOC}|{COD_ITEM}|{VL_REC_DET}|" +
                     $"{CST_PIS}|{CST_COFINS}|{INFO_COMPL}|{COD_CTA}|";
        return ret;
    }
}