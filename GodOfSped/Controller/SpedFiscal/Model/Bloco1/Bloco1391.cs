namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1391
{
    public String REG { get; set; } = "1391";

    public String DT_REGISTRO { get; set; }

    public String QTD_MOID { get; set; }

    public String ESTQ_INI { get; set; }

    public String QTD_PRODUZ { get; set; }

    public String ENT_ANID_HID { get; set; }

    public String OUTR_ENTR { get; set; }

    public String PERDA { get; set; }

    public String CONS { get; set; }

    public String SAI_ANI_HID { get; set; }

    public String SAIDAS { get; set; }

    public String ESTQ_FIN { get; set; }

    public String ESTQ_INI_MEL { get; set; }

    public String PROD_DIA_MEL { get; set; }

    public String UTIL_MEL { get; set; }

    public String PROD_ALC_MEL { get; set; }

    public String OBS { get; set; }

    public String COD_ITEM { get; set; }

    public String TP_RESIDUO { get; set; }
    
    public String QTD_RESIDUO { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{ESTQ_INI}|{QTD_PRODUZ}|{DT_REGISTRO}|{QTD_MOID}|{ENT_ANID_HID}|{OUTR_ENTR}|{PERDA}|{CONS}|{SAI_ANI_HID}|{SAIDAS}|{ESTQ_FIN}|{ESTQ_INI_MEL}|{PROD_DIA_MEL}|{UTIL_MEL}|{PROD_ALC_MEL}|{OBS}|{COD_ITEM}|{TP_RESIDUO}|{QTD_RESIDUO}|";
        
        return ret;
    }

    
}