namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0200
{
    public String REG { get; set; } = "0200";
    
    public String COD_ITEM { get; set; }
    
    public String DESCR_ITEM { get; set; }
    
    public String COD_BARRA { get; set; }
    
    public String COD_ANT_ITEM { get; set; }
    
    public String UNID_INV { get; set; }
    
    public String TIPO_ITEM { get; set; }
    
    public String COD_NCM { get; set; }
    
    public String EX_IPI { get; set; }
    
    public String COD_GEN { get; set; }
    
    public String COD_LST { get; set; }
    
    public String ALIQ_ICMS { get; set; }
    
    public String CEST { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM}|{DESCR_ITEM}|{COD_BARRA}|{COD_ANT_ITEM}|{UNID_INV}|{TIPO_ITEM}|{COD_NCM}|{EX_IPI}|{COD_GEN}|{COD_LST}|{ALIQ_ICMS}|{CEST}|";
        
        return ret;
    }
}