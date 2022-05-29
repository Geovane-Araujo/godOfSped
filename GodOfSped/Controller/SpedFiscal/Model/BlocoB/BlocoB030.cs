namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB030
{
    public String REG { get; set; } = "B030";
    
    public String COD_MOD { get; set; }
    
    public String SER { get; set; }
    
    public String NUM_DOC_INI { get; set; }
    
    public String NUM_DOC_FIN { get; set; }
    
    public String DT_DOC { get; set; }
    
    public String QTD_CANC { get; set; }
    
    public String VL_CONT { get; set; }
    
    public String VL_ISNT_ISS { get; set; }
    
    public String VL_BC_ISS { get; set; }
    
    public String VL_ISS { get; set; }
    
    public String COD_INF_OBS { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{SER}|{NUM_DOC_INI}|{NUM_DOC_FIN}|{DT_DOC}|{QTD_CANC}|{VL_CONT}|{VL_ISNT_ISS}|{VL_BC_ISS}|{	VL_ISS}|{COD_INF_OBS}|";
        
        return ret;
    }
}