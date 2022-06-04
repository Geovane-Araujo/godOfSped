
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM615
{
    public String REG { get; } = "M615";
    
    public String IND_AJ_BC { get; set; } = "";
    
    public String VL_AJ_BC { get; set; } = "";
    
    public String COD_AJ_BC { get; set; } = "";
    
    public String NUM_DOC { get; set; } = "";
    
    public String DESCR_AJ_BC { get; set; } = "";
    
    public String DT_REF { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String CNPJ { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_AJ_BC}|{VL_AJ_BC}|{COD_AJ_BC}|{NUM_DOC}|{DESCR_AJ_BC}|{DT_REF}|" +
                     $"{COD_CTA}|{CNPJ}|{INFO_COMPL}|";
        
        return ret;
    }
}