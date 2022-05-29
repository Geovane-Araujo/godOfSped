namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB420
{
    public String REG { get; set; } = "B420";
    
    public String VL_CONT { get; set; }
    
    public String VL_BC_ISS { get; set; }
    
    public String ALIQ_ISS { get; set; }
    
    public String VL_ISNT_ISS { get; set; }
    
    public String VL_ISS { get; set; }
    
    public String COD_SERV { get; set; }  

    public String ToString()
    {
        String ret = $"|{REG}|{VL_CONT}|{VL_BC_ISS}|{ALIQ_ISS}|{VL_ISNT_ISS}|{VL_ISS}|{COD_SERV}|";
        
        return ret;
    }
}