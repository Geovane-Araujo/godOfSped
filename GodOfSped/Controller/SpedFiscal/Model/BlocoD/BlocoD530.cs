namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD530
{
    public String REG { get; set; } = "D530";

    public String IND_SERV { get; set; }

    public String DT_INI_SERV { get; set; }

    public String DT_FIM_SERV { get; set; }
    
    public String PER_FISCAL { get; set; }

    public String COD_AREA { get; set; }

    public String TERMINAL { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{IND_SERV}|{DT_INI_SERV}|{DT_FIM_SERV}|{PER_FISCAL}|{COD_AREA}|{TERMINAL}|";
     
        return ret;
    }
}