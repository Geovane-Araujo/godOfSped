namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB440
{
    public String REG { get; set; } = "B440";
    
    public String IND_OPER { get; set; }
    
    public String COD_PART { get; set; }
    
    public String VL_CONT_RT { get; set; }
    
    public String VL_BC_ISS_RT { get; set; }
    
    public String VL_ISS_RT { get; set; } 

    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{COD_PART}|{VL_CONT_RT}|{VL_BC_ISS_RT}|{VL_ISS_RT}|";
        
        return ret;
    }
}