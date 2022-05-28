
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1501
{
    public String REG { get; } = "1501";
    
    public String COD_PART { get; set; } = "";
    
    public String COD_ITEM { get; set; } = "";
    
    public String COD_MOD { get; set; } = "";
    
    public String SER { get; set; } = "";
    
    public String SUB_SER { get; set; } = "";
    
    public String NUM_DOC { get; set; } = "";
    
    public String DT_OPER { get; set; } = "";
    
    public String CHV_NFE { get; set; } = "";
    
    public String VL_OPER { get; set; } = "";
    
    public String CFOP { get; set; } = "";
    
    public String NAT_BC_CRED { get; set; } = "";
    
    public String IND_ORIG_CRED { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String COD_CCUS { get; set; } = "";
    
    public String DESC_COMPL { get; set; } = "";
    
    public String PER_ESCRIT { get; set; } = "";
    
    public String CNPJ { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART}|{COD_ITEM}|{COD_MOD}|{SER}|{SUB_SER}|{NUM_DOC}|{DT_OPER}|{CHV_NFE}|" +
                     $"{VL_OPER}|{CFOP}|{NAT_BC_CRED}|{IND_ORIG_CRED}|{CST_COFINS}|" +
                     $"{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|{COD_CTA}|{COD_CCUS}|{DESC_COMPL}|{PER_ESCRIT}|{CNPJ}|";
        
        return ret;
    }
}