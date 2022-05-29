namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC160
{
    public String REG { get; set; } = "C160";

    public String COD_PART { get; set; }

    public String VEIC_ID { get; set; }

    public String QTD_VOL { get; set; }

    public String QTD_PESO_BRT { get; set; }

    public String PESO_LIQ { get; set; }

    public String UF_ID { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART}|{VEIC_ID}|{QTD_VOL}|{QTD_PESO_BRT}|{PESO_LIQ}|{UF_ID}|";
        
        return ret;
    }
}