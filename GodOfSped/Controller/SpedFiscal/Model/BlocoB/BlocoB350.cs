namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB350
{
    public String REG { get; set; } = "B350";
    
    public String COD_CTD { get; set; }
    
    public String CTA_ISS { get; set; }
    
    public String CTA_COSIF { get; set; }
    
    public String QTD_OCOR { get; set; }
    
    public String COD_SERV { get; set; }
    
    public String VL_CONT { get; set; }
    
    public String VL_BC_ISS { get; set; }
    
    public String ALIQ_ISS { get; set; }
    
    public String VL_ISS { get; set; }
    
    public String COD_INF_OBS { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_CTD}|{CTA_ISS}|{CTA_COSIF}|{QTD_OCOR}|{COD_SERV}|{VL_CONT}|{VL_BC_ISS}|{ALIQ_ISS}|{VL_ISS}|{COD_INF_OBS}";
        
        return ret;
    }
}