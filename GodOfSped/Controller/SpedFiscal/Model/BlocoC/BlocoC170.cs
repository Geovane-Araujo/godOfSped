namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC170
{
    public String REG { get; set; } = "C170"; 
    
    public String NUM_ITEM { get; set; }

    public String COD_ITEM { get; set; }

    public String DESCR_COMPL { get; set; }
    
    public String QTD { get; set; }  

    public String UNID { get; set; }

    public String VL_ITEM { get; set; }

    public String VL_DESC { get; set; }

    public String IND_MOV { get; set; }
    
    public String CST_ICMS { get; set; }

    public String CFOP { get; set; }

    public String COD_NAT { get; set; }

    public String VL_BC_ICMS { get; set; }

    public String ALIQ_ICMS { get; set; }

    public String VL_ICMS { get; set; }

    public String VL_BC_ST_I { get; set; }

    public String ALIQ_ST { get; set; }

    public String VL_ICMS_ST { get; set; }

    public String IND_APUR { get; set; }

    public String CTS_IPI { get; set; }

    public String COD_ENQ { get; set; }

    public String VL_BC_IPI { get; set; }

    public String ALIQ_IPI { get; set; }

    public String VL_IPI { get; set; }

    public String CST_PIS { get; set;}

    public String VL_BC_PIS { get; set;}

    public String ALQ_PIS { get; set;}

    public String QUANT_BC_PIS { get; set;}

    public String ALQ_PIS { get; set;}

    public String VL_PIS { get; set;}

    public String CST_COFINS { get; set;}

    public String VL_BC_COFINS { get; set;}

    public String ALIQ_COFINS { get; set;}

    public String QUANT_BC_COFINS { get; set;}

    public String RALIQ_COFINS { get; set;}

    public String VL_COFINS { get; set;}

    public String COD_CTA { get; set;}

    public String VL_ABAT_NT { get; set;}
    

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_ITEM}|{COD_ITEM}|{DESCR_COMPL}|{QTD}|{UNID}|{VL_ITEM}|{VL_DESC}|{IND_MOV}|{CST_ICMS}|{CFOP}|{COD_NAT}|{VL_BC_ICMS}|{ALIQ_ICMS}|{VL_ICMS}||{VL_BC_ST_I}|{ALIQ_ST}|{VL_ICMS_ST}||{IND_APUR}|{CTS_IPI}|{COD_ENQ}|{VL_BC_IPI}|{ALIQ_IPI}|{VL_IPI}|{CST_PIS}|{VL_BC_PIS}|{ALQ_PIS}|{QUANT_BC_PIS}|{ALQ_PIS}|{VL_PIS}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{QUANT_BC_COFINS}|{RALIQ_COFINS}|{VL_COFINS}|{COD_CTA}|{VL_ABAT_NT}|";
        
        return ret;
    }
}