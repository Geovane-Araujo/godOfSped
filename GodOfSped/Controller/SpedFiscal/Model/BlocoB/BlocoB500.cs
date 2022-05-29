namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB500
{
    public String REG { get; set; } = "B500";
    
    public String VL_REC { get; set; }
    
    public String QTD_PROF { get; set; }
    
    public String VL_OR { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_REC}|{QTD_PROF}|{VL_OR}";
        
        return ret;
    }
}