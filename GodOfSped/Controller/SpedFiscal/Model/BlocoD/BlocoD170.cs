namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD180
{
    public String REG { get; set; } = "D180";
    
    public String COD_PART_CONSG { get; set; }
    
    public String COD_PART_RED { get; set; }
    
    public String COD_MUN_ORIG  { get; set; }
    
    public String COD_MUN_DEST { get; set; }
    
    public String OTM { get; set; }
    
    public String IND_NAT_FRT { get; set; }

    public String VL_LIQ_FRT { get; set; }
    
    public String VL_GRIS { get; set; }

    public String VL_PDG { get; set; }

    public String VL_OUT { get; set; }

    public String VL_FRT { get; set; }  
    
    public String VEIC_ID { get; set; }

    public String UF_ID { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART_CONSG}|{COD_PART_RED}|{IND_NAT_FRT}|{OTM}|{VL_OUT}|{COD_MUN_ORIG}|{VL_LIQ_FRT}|{VL_GRIS}|{VL_PDG}|{COD_MUN_DEST}|{VL_FRT}|{COD_MOD}|{VEIC_ID}|{UF_ID}|";
        
        return ret;
    }
}