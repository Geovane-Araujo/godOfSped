namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC500
{
    public String REG { get; set; } = "C500";

    public String IND_OPER { get; set; }
    
    public String IND_EMIT { get; set; }
    
    public String COD_PART  { get; set; }
    
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
    
    public String TP_LIGACAO  { get; set; }
   
    public String COD_GRUPO_TENSAO { get; set; }
    
    public String CHV_DOCe { get; set; }
    
    public String FIN_DOCe { get; set; }

    public String CHV_DOCe_REF { get; set; } 

    public String IND_DEST { get; set; }  

    public String COD_MUN_DEST { get; set; }   

    public String COD_CTA { get; set; } 

    public String COD_MOD_DOC_REF { get; set; }  
     
    public String HASH_DOC_REF { get; set; } 
    
    public String SER_DOC_REF { get; set; }  
    
    public String NUM_DOC_REF { get; set; }    

    public String MES_DOC_REF { get; set; } 

    public String ENER_INJET { get; set; } 

    public String OUTRAS_DED { get; set; } 

    public String ToString()
    {
        String ret = $"|{REG}|{IND_OPER}|{IND_EMIT}|{COD_PART}|{COD_MOD}|{COD_SIT}|{SER}|{SUB}|{COD_CONS}|{NUM_DOC}|{DT_DOC}|{DT_E_S}|{VL_DOC}|{VL_DESC}|{VL_FORN}|{VL_SERV_NT}|{VL_TERC}|{VL_DA}|{VL_ICMS}|{VL_BC_ICMS_ST}|{VL_ICMS_ST}|{COD_INF}|{VL_PIS}|{VL_COFINS}|{TP_LIGACAO}|{COD_GRUPO_TENSAO}|{CHV_DOCe}|{FIN_DOCe}|{CHV_DOCe_REF}|{IND_DEST}|{COD_MUN_DEST}|{COD_CTA}|{COD_MOD_DOC_REF}|{HASH_DOC_REF}|{SER_DOC_REF}|{NUM_DOC_REF}|{MES_DOC_REF}|{ENER_INJET}|{OUTRAS_DED}";
        
        return ret;
    }
}