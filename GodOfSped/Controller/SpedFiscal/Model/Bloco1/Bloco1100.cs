namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1100
{
    public String REG { get; set; } = "1100";

    public String IND_DOC { get; set; }

    public String NRO_DE { get; set; }

    public String DT_DE { get; set; }

    public String NAT_EXP { get; set; }

    public String NRO_RE { get; set; }

    public String DT_RE { get; set; }

    public String CHC_EMB { get; set; }

    public String DT_CHC { get; set; }

    public String DT_AVB { get; set; }

    public String TP_CHC { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{DT_DE}|{NAT_EXP}|{IND_DOC}|{NRO_DE}|{NRO_RE}|{DT_RE}|{CHC_EMB}|{DT_CHC}|{DT_AVB}|{TP_CHC}|";
        
        return ret;
    }

    
}