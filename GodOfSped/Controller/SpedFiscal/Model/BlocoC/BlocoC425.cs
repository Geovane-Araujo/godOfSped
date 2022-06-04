namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC425
{
    public String REG { get; set; } = "C425";
    
    public String COD_ITEM { get; set; }
    
    public String QTD { get; set; }
    
    public String UNID { get; set; }
    
    public String VL_ITEM { get; set; }
    
    public String VL_PIS { get; set; }
    
    public String VL_COFINS { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM}|{QTD}|{UNID}|{VL_ITEM}|{VL_PIS}|{VL_COFINS}|";
        
        return ret;
    }
}