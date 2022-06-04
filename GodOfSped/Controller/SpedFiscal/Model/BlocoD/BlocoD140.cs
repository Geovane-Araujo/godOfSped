namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD140
{
    public String REG { get; set; } = "D140";
    
    public String COD_PART_CONSG { get; set; }
    
    public String COD_MUN_DEST { get; set; }
    
    public String COD_MUN_ORIG  { get; set; }
    
    public String IND_VEIC { get; set; }
    
    public String VEIC_ID { get; set; }
    
    public String IND_NAV { get; set; }

    public String VIAGEM { get; set; }
    
    public String VL_FRT_LIQ { get; set; }

    public String VL_DESP_PORT { get; set; }

    public String VL_DESP_CAR_DESC { get; set; }

    public String VL_OUT { get; set; }  
    
    public String VL_FRT_BRT { get; set; }

    public String VL_FRT_MM { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART_CONSG}|{IND_VEIC}|{IND_NAV}|{VL_FRT_BRT}|{VL_DESP_CAR_DESC}|{COD_MUN_ORIG}|{VIAGEM}|{VL_OUT_LIQ}|{VL_DESP_PORT}|{COD_MUN_DEST}|{VL_FRT}|{COD_MOD}|{VEIC_ID}|{VL_FRT_MM}|";
        
        return ret;
    }
}