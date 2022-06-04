using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using GodOfSped.Model.SpedContribuicoes.Model;
using GodOfSped.Model.SpedContribuicoes.Repository;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class Bloco9
{

    
    public static List<String> Bloco9Ini(int asData)
    {
        List<String> retv = new List<string>();
        
        Bloco9001 blo001 = new();
        blo001.IND_MOV = asData.ToString();

        retv.Add(blo001.ToString());
        return retv;
    }
    
    public static List<String> Bloco9900(params Dictionary<String, List<String>>[] blocos)
    {
        List<String> retv = new List<string>();
        
        List<String> values = new();
        Bloco9900 blo9900 = new();
        foreach (Dictionary<String, List<String>> tableBloco0 in blocos)
        {
            Console.WriteLine("Ola");
            foreach (String table in tableBloco0.Keys)
            {
                values = new();
                blo9900 = new();
                blo9900.REG_BLC = table;

                values = (List<String>)tableBloco0[table];
                blo9900.QTD_REG_BLC = values.Count.ToString();
                if(values.Count > 0)
                    retv.Add(blo9900.ToString());
            }
        }

        blo9900 = new();
        blo9900.REG_BLC = "9001";
        blo9900.QTD_REG_BLC = (1).ToString();
        retv.Add(blo9900.ToString());
        
        blo9900 = new();
        blo9900.REG_BLC = "9990";
        blo9900.QTD_REG_BLC = (1).ToString();
        retv.Add(blo9900.ToString());
        
        blo9900 = new();
        blo9900.REG_BLC = "9999";
        blo9900.QTD_REG_BLC = (1).ToString();
        retv.Add(blo9900.ToString());
        
        blo9900.REG_BLC = "9900";
        blo9900.QTD_REG_BLC = (retv.Count+1).ToString();
        retv.Add(blo9900.ToString());
        
        
       
        return retv;
    }
    
    public static List<String> Bloco9990(List<String> blo9)
    {
        List<String> retv = new List<string>();
        
        Bloco9990 blo9990 = new();
        blo9990.QTD_LIN_9 = (blo9.Count+3).ToString();
        retv.Add(blo9990.ToString());
        return retv;
    }
    
    public static List<String> Bloco9999(List<String> blo9)
    {
        List<String> retv = new List<string>();
        
        Bloco9999 blo9999 = new();
        blo9999.QTD_LIN = (blo9.Count+1).ToString();
        retv.Add(blo9999.ToString());
        return retv;
    }
}