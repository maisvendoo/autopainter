//-------------------------------------------------------------------
//
//      Module for color's data base access
//      (c) maisvendoo, 2015-03-17
//
//-------------------------------------------------------------------
using System;
using System.Data.OleDb;

//-------------------------------------------------------------------
//
//-------------------------------------------------------------------
public class CDBaccess
{
    // Constructor
    public CDBaccess()
    {
        //this.db_path = "E:\\";
        //this.db_filename = "yatu.mdb";
        //this.db_passwd = "yatu";
        this.db_provider = "Microsoft.Jet.OLEDB.4.0";

        connection = new OleDbConnection();
    }

    private const string MODEL_DATA = "ModelColor";
    private const string CAR_FACTORY = "CarFactory";
    
    /*private string db_path;
    private string db_passwd;
    private string db_filename;*/

    private string db_provider;

    private OleDbConnection connection;

    public int open(string db_path, string db_filename, string db_passwd)
    {
        int err_code = 0;
        connection.ConnectionString = "Provider=" +
                               db_provider + ";" +
                               "Data Source=" +
                               db_path + "\\" + db_filename + ";" +
                               "Jet OLEDB:Database Password=" +
                               db_passwd + ";";
        

        try
        {
            connection.Open();
        }
        catch (Exception ex)
        {
            err_code = -1;
        }
        finally
        {
            err_code = 0;
        }

        return err_code;
    }

    public void close()
    {
        connection.Close();
    }

    public void get_colors_data(TQueryData query_data, ref TColorsData[] colors_data)
    {
        string query = "SELECT ";
        string where = " WHERE";

        query += MODEL_DATA + ".colorId, " + CAR_FACTORY + ".name, " + MODEL_DATA + ".colorName";

        query += " FROM " + MODEL_DATA + ", " + CAR_FACTORY;

        if (query_data.ColorCode != "")
        {
            where += String.Format(" ModelColor.colorId = \'{0}\'", query_data.ColorCode);
        }
        else
        {
            where += " ModelColor.colorId LIKE \'%\'";
        }

        if (query_data.Manufacturer != "")
        {
            where += String.Format(" AND CarFactory.name = \'{0}\'", query_data.Manufacturer);
        }
        else
        {
            where += " AND CarFactory.name LIKE \'%\'";
        }

        if (query_data.ColorName != "")
        {
            where += String.Format(" AND ModelColor.colorName = \'{0}\'", query_data.ColorName);
        }
        else
        {
            where += " AND ModelColor.colorName LIKE \'%\'";
        }

        where += " AND CarFactory.id = ModelColor.carFatoryId";

        query += where;

        OleDbCommand command = new OleDbCommand();

        command.Connection = connection;
        command.CommandText = query;

        OleDbDataReader dr = command.ExecuteReader();

        int data_count = 0;

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                data_count++;

                Array.Resize(ref colors_data, data_count);

                colors_data[data_count - 1].ColorCode = dr["colorId"].ToString();
                colors_data[data_count - 1].Manufacturer = dr["name"].ToString();
                colors_data[data_count - 1].ColorName = dr["colorName"].ToString();
            }
        }
    }
}