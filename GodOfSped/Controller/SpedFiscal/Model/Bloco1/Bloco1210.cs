namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1210
{
    public String REG { get; set; } = "1210";

    public String TIPO_UTIL { get; set; }

    public String NR_DOC { get; set; }

    public String VL_CRED_UTIL { get; set; }

    public String CHV_DOCe { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{VL_CRED_UTIL}|{CHV_DOCe}|{TIPO_UTIL}|{NR_DOC}|";
        
        return ret;
    }

    
}