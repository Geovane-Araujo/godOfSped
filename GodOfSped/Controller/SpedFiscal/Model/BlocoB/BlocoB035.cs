namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB035
{
    public String REG { get; set; } = "B035";
    
    public String VL_CONT_P { get; set; }
    
    public String VL_BC_ISS_P { get; set; }
    
    public String ALIQ_ISS { get; set; }
    
    public String VL_ISS_P { get; set; }
    
    public String VL_ISNT_ISS_P { get; set; }
    
    public String COD_SERV { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{VL_CONT_P}|{VL_BC_ISS_P}|{ALIQ_ISS}|{VL_ISS_P}|{VL_ISNT_ISS_P}|{COD_SERV}|";
        
        return ret;
    }
}