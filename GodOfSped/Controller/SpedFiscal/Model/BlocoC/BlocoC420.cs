namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC420
{
    public String REG { get; set; } = "C420";
    
    public String COD_TOT_PAR { get; set; }
    
    public String VLR_ACUM_TOT { get; set; }
    
    public String NR_TOT { get; set; }
    
    public String DESCR_NR_TOT { get; set; } 

    public String ToString()
    {
        String ret = $"|{REG}|{COD_TOT_PAR}|{VLR_ACUM_TOT}|{NR_TOT}|{DESCR_NR_TOT}|";
        
        return ret;
    }
}