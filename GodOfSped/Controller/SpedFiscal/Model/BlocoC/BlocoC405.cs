namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC405
{
    public String REG { get; set; } = "C405";
    
    public String DT_DOC { get; set; }
    
    public String CRO { get; set; }
    
    public String CRZ { get; set; }
    
    public String NUM_COO_FIN { get; set; }
    
    public String GT_FIN { get; set; }
    
    public String VL_BRT { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{DT_DOC}|{CRO}|{CRZ}|{NUM_COO_FIN}|{GT_FIN}|{VL_BRT}|";
        
        return ret;
    }
}