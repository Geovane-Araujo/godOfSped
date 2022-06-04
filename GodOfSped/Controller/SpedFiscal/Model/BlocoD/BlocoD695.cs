﻿namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD695
{
    public String REG { get; set; } = "D695";

    public String COD_MOD { get; set; }

    public String SER { get; set; }

    public String NRO_ORD_INI { get; set; }
    
    public String NRO_ORD_FIN { get; set; }

    public String DT_DOC_INI { get; set; }

    public String DT_DOC_FIN { get; set; }

    public String NOM_MEST { get; set; }

    public String CHV_COD_DIG { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{SER}|{NRO_ORD_INI}|{NRO_ORD_FIN}|{DT_DOC_INI}|{DT_DOC_FIN}|{NOM_MEST}|{CHV_COD_DIG}|";
     
        return ret;
    }
}