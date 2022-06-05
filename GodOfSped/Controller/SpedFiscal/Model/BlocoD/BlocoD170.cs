namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD170
{
    public String REG { get; set; } = "D170";
    
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
        String ret = $"|{REG}|{COD_PART_CONSG}|{COD_PART_RED}|{COD_MUN_ORIG}|{COD_MUN_DEST}|" +
                     $"{OTM}|{IND_NAT_FRT}|{VL_LIQ_FRT}|{VL_GRIS}|{VL_PDG}|" +
                     $"{VL_OUT}|{VL_FRT}|{VEIC_ID}|{UF_ID}|";
        
        return ret;
    }
}