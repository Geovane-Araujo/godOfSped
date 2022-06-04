namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC810
{
    public String REG { get; set; } = "C810";
    
    public String NUM_ITEM { get; set; }
    
    public String COD_ITEM { get; set; }
    
    public String QTD  { get; set; }
    
    public String UNID { get; set; }
    
    public String VL_ITEM { get; set; }
    
    public String CST_ICMS { get; set; }

    public String CFOP { get; set; }   

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_ITEM}|{COD_ITEM}|{QTD}|{VL_ITEM}|{UNID}|{CST_ICMS}|{CFOP}|";
        
        return ret;
    }
}