namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC460
{
    public String REG { get; set; } = "C460";
    
    public String COD_MOD { get; set; }
    
    public String COD_SIT { get; set; }
    
    public String NUM_DOC { get; set; }
    
    public String DT_DOC { get; set; }
    
    public String VL_DOC { get; set; }
    
    public String VL_PIS { get; set; }
    
    public String VL_COFINS { get; set; }
    
    public String CPF_CNPJ { get; set; }

    public String NOM_ADQ { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{COD_SIT}|{NUM_DOC}|{DT_DOC}|{VL_DOC}|{VL_PIS}|{VL_COFINS}|{CPF_CNPJ}|{NOM_ADQ}|";
        
        return ret;
    }
}