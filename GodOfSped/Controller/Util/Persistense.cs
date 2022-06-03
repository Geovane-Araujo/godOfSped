using System.Collections;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace GodOfSped.Model.SpedContribuicoes;

public class Persistense
{
    
    public static T FindByOne<T>(SqlConnection con, String sql)
    {
        Object ret = new();

        ret = ConstructorCommand(con, sql, 1);
        var json = JsonConvert.SerializeObject(ret);
        T obj = JsonConvert.DeserializeObject<T>(json);
        return obj;
    }
    
    public static List<T> FindByAll<T>(SqlConnection con, String sql)
    {

        Object ret = new();
        ret = ConstructorCommand(con, sql, 2);
        var json = JsonConvert.SerializeObject(ret);
        List<T> obj = JsonConvert.DeserializeObject<List<T>>(json);

        return obj;
    }
    public static Object FindByOne(SqlConnection con, String sql)
    {
        Object obj = ConstructorCommand(con, sql,1);
        return obj;
    }
    public static Object FindByAll(SqlConnection con, String sql)
    {
        Object obj = ConstructorCommand(con, sql,2);
        return obj;
    }
    
    private static Object ConstructorCommand(SqlConnection con, string sql, int type)
    {
        SqlCommand command = new SqlCommand(sql, con);
        SqlDataReader dr = command.ExecuteReader();

        Hashtable table = new();
        List<Hashtable> tbl = new List<Hashtable>();

        if (type == 1)
        {
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    table.Add(dr.GetName(i), (Object)dr.GetValue(dr.GetOrdinal(dr.GetName(i))));
                }
            }
            command.Dispose();
            dr.Close();
            return table;
        }
        else if (type == 2)
        {
            while (dr.Read())
            {
                table = new();
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    table.Add(dr.GetName(i), (Object)dr.GetValue(dr.GetOrdinal(dr.GetName(i))));
                }
                tbl.Add(table);

            }
            command.Dispose();
            dr.Close();
            return tbl;
        }
        return false;
    }
}