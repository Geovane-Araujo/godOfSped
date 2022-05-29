
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC195
{
    public String REG { get; } = "C195";
    
    public String CNPJ_CPF_PART { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    
    public String CFOP { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    public String VL_DESC { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String QUANT_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS_QUANT { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CNPJ_CPF_PART}|{CST_COFINS}|{CFOP}|{VL_ITEM}|{VL_DESC}|{VL_BC_COFINS}|" +
                     $"{ALIQ_COFINS}|{QUANT_BC_COFINS}|{ALIQ_COFINS_QUANT}|{VL_COFINS}|" +
                     $"{COD_CTA}|";
        return ret;
    }
}