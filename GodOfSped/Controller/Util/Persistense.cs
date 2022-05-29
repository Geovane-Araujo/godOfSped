using System.Collections;
using System.Data.SqlClient;

namespace GodOfSped.Model.SpedContribuicoes;

public class Persistense
{
    public static Object GetAll(SqlConnection con, String sql)
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