namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1200
{
    public String REG { get; set; } = "1200";

    public String COD_AJ_APUR { get; set; }

    public String SLD_CRED { get; set; }

    public String CRED_APR { get; set; }

    public String CRED_RECEB { get; set; }

    public String CRED_UTIL { get; set; }

    public String SLD_CRED_FIM { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{CRED_APR}|{CRED_RECEB}|{COD_AJ_APUR}|{SLD_CRED}|{CRED_UTIL}|{SLD_CRED_FIM}|";
        
        return ret;
    }

    
}