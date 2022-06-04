namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC165
{
    public String REG { get; set; } = "C165";
    
    public String COD_PART { get; set; }
    
    public String VEIC_ID { get; set; }
    
    public String COD_AUT { get; set; }
    
    public String NR_PASSE { get; set; }
    
    public String HORA { get; set; }
    
    public String TEMPER { get; set; }
    
    public String QTD_VOL { get; set; }
    
    public String PESO_BRT { get; set; }
    
    public String PESO_LIQ { get; set; }
    
    public String NOM_MOT { get; set; }
    
    public String CPF { get; set; }
    
    public String UF_ID { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_PART}|{VEIC_ID}|{COD_AUT}|{NR_PASSE}|{HORA}|{TEMPER}|{QTD_VOL}|{PESO_BRT}|{PESO_LIQ}|{NOM_MOT}|{CPF}|{UF_ID}|";
        
        return ret;
    }
}