namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1500
{
    public String REG { get; set; } = "1500";

    public String IND_OPER { get; set; }

    public String IND_EMIT { get; set; }

    public String COD_PART { get; set; }

    public String COD_MOD { get; set; }

    public String COD_SIT { get; set; }

    public String SER { get; set; }

    public String SUB { get; set; }

    public String COD_CONS { get; set; }

    public String NUM_DOC { get; set; }

    public String DT_DOC { get; set; }

    public String DT_E_S { get; set; }

    public String VL_DOC { get; set; }

    public String VL_DESC { get; set; }

     public String VL_FORN { get; set; } 

    public String VL_SERV_NT { get; set; }

    public String VL_TERC { get; set; }

    public String VL_DA { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String VL_ICMS { get; set; }

    public String VL_BC_ICMS_ST { get; set; }

    public String VL_ICMS_ST { get; set; }

    public String COD_INF { get; set; }

    public String VL_PIS { get; set; }

    public String VL_COFINS { get; set; }

    public String TP_LIGACAO { get; set; }

    public String COD_GRUPO_TENSAO { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART}|{COD_MOD}|{IND_OPER}|{IND_EMIT}|{COD_SIT}|{SER}|{SUB}|{COD_CONS}|{NUM_DOC}|{DT_DOC}|{DT_E_S}|{VL_DOC}|{VL_DESC}|{VL_FORN}|{VL_DA}|{VL_BC_ICMS}|{VL_SERV_NT}|{VL_TERC}|{VL_ICMS}|{VL_BC_ICMS_ST}|{VL_ICMS_ST}|{COD_INF}|{VL_PIS}|{VL_COFINS}|{TP_LIGACAO}|{COD_GRUPO_TENSAO}|";
        
        return ret;
    }

    
}