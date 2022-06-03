
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC170
{
    public Int32 IDNOTA;
    public String REG { get; } = "C170";
    
    public String NUM_ITEM { get; set; } = "";
    
    public String COD_ITEM { get; set; } = "";
    
    public String DESCR_COMPL { get; set; } = "";
    
    public String QTD { get; set; } = "";
    
    public String UNID { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    public String VL_DESC { get; set; } = "";
    
    public String IND_MOV { get; set; } = "";
    
    public String CST_ICMS { get; set; } = "";
    
    public String CFOP { get; set; } = "";
    
    public String COD_NAT { get; set; } = "";
    
    public String VL_BC_ICMS { get; set; } = "";
    
    public String ALIQ_ICMS { get; set; } = "";
    
    public String VL_ICMS { get; set; } = "";
    
    public String VL_BC_ICMS_ST { get; set; } = "";
    
    public String ALIQ_ST { get; set; } = "";
    
    public String VL_ICMS_ST { get; set; } = "";
    
    public String IND_APUR { get; set; } = "";
    
    public String CTS_IPI { get; set; } = "";
    
    public String COD_ENQ { get; set; } = "";
    
    public String VL_BC_IPI { get; set; } = "";
    
    public String ALIQ_IPI { get; set; } = "";
    
    public String VL_IPI { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALQ_PIS { get; set; } = "";
    
    public String QUANT_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS_QUANT { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String QUANT_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS_QUANT { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NUM_ITEM}|{COD_ITEM}|{DESCR_COMPL}|{QTD.Replace(".",",")}|{UNID}|" +
                     $"{VL_ITEM.Replace(".",",")}|" +
                     $"{VL_DESC.Replace(".",",")}|" +
                     $"{IND_MOV}|" +
                     $"{CST_ICMS}|" +
                     $"{CFOP}|" +
                     $"{COD_NAT}|" +
                     $"{VL_BC_ICMS.Replace(".",",")}|" +
                     $"{ALIQ_ICMS.Replace(".",",")}|" +
                     $"{VL_ICMS.Replace(".",",")}|" +
                     $"{VL_BC_ICMS_ST.Replace(".",",")}|" +
                     $"{ALIQ_ST.Replace(".",",")}|" +
                     $"{VL_ICMS_ST.Replace(".",",")}|" +
                     $"{IND_APUR}|" +
                     $"{CTS_IPI}|" +
                     $"{COD_ENQ}|" +
                     $"{VL_BC_IPI.Replace(".",",")}|" +
                     $"{ALIQ_IPI.Replace(".",",")}|" +
                     $"{VL_IPI.Replace(".",",")}|" +
                     $"{CST_PIS}|" +
                     $"{VL_BC_PIS.Replace(".",",")}|{ALQ_PIS.Replace(".",",")}|{QUANT_BC_PIS.Replace(".",",")}|" +
                     $"{ALIQ_PIS_QUANT.Replace(".",",")}|{VL_PIS.Replace(".",",")}|" +
                     $"{CST_COFINS}|{VL_BC_COFINS.Replace(".",",")}|{ALIQ_COFINS.Replace(".",",")}|" +
                     $"{QUANT_BC_COFINS.Replace(".",",")}|{ALIQ_COFINS_QUANT.Replace(".",",")}|" +
                     $"{VL_COFINS.Replace(".",",")}|{COD_CTA}|";
        return ret;
    }
}