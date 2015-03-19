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
    private const string COLOR_SCHEME = "ColorScheme";
    
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

    //
    public void get_colors_data(TQueryData query_data, ref TColorsData[] colors_data)
    {
        string query = "SELECT ";
        string where = " WHERE";

        // Create begin of query string
        query += MODEL_DATA + ".colorId, " +
                 CAR_FACTORY + ".name, " + 
                 MODEL_DATA + ".colorName, " + 
                 MODEL_DATA + ".id";

        query += " FROM " + MODEL_DATA + ", " + CAR_FACTORY;

        // Create query conditions by text field's values

        // Check color code field
        if (query_data.ColorCode != "")
        {
            where += String.Format(" {1}.colorId = \'{0}\'", query_data.ColorCode, MODEL_DATA);
        }
        else
        {
            where += String.Format(" {0}.colorId LIKE \'%\'", MODEL_DATA);
        }

        // Check manufacturer field
        if (query_data.Manufacturer != "")
        {
            where += String.Format(" AND {1}.name = \'{0}\'", query_data.Manufacturer, CAR_FACTORY);
        }
        else
        {
            where += String.Format(" AND {0}.name LIKE \'%\'", CAR_FACTORY);
        }

        // Check color name field
        if (query_data.ColorName != "")
        {
            where += String.Format(" AND {1}.colorName = \'{0}\'", query_data.ColorName, MODEL_DATA);
        }
        else
        {
            where += String.Format(" AND {0}.colorName LIKE \'%\'", MODEL_DATA);
        }

        where += String.Format(" AND {0}.id = {1}.carFatoryId", CAR_FACTORY, MODEL_DATA);

        where += String.Format(" ORDER BY {0}.colorId", MODEL_DATA);

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
                colors_data[data_count - 1].modelColorId = dr["id"].ToString();
            }
        }
    }

    //
    public void get_formulas_data(TColorsData colors_data, ref TFormulasData[] formulas_data)
    {
        string query = "SELECT ";
        string where = " WHERE";

        query += "modelColorId, " +
                 "year, " +
                 "stockCode, " +
                 "formulaCode, " + 
                 "variant, " +
                 "brand, " + 
                 "coat, " + 
                 "model, " + 
                 "source, " + 
                 "date, " + 
                 "colorindex";

        query += " FROM " + COLOR_SCHEME;

        where += String.Format(" modelColorId = \'{0}\' ", colors_data.modelColorId);

        query += where;

        OleDbCommand command = new OleDbCommand();

        command.Connection = connection;
        command.CommandText = query;

        OleDbDataReader dr = command.ExecuteReader();

        int formulas_count = 0;

        if (dr.HasRows)
        {
            while (dr.Read())
            {
                formulas_count++;

                Array.Resize(ref formulas_data, formulas_count);

                formulas_data[formulas_count - 1].ColorCode = colors_data.ColorCode;
                formulas_data[formulas_count - 1].Brand = dr["brand"].ToString();
                formulas_data[formulas_count - 1].Coat = dr["coat"].ToString();
                formulas_data[formulas_count - 1].Variant = dr["variant"].ToString();
                formulas_data[formulas_count - 1].Model = dr["model"].ToString();
                formulas_data[formulas_count - 1].Year = dr["year"].ToString();
                formulas_data[formulas_count - 1].Source = dr["source"].ToString();
                formulas_data[formulas_count - 1].CreatedDate = dr["date"].ToString();
                formulas_data[formulas_count - 1].FormulaCode = dr["formulaCode"].ToString();
                formulas_data[formulas_count - 1].StockCode = dr["stockCode"].ToString();
                formulas_data[formulas_count - 1].ColorIndex = dr["colorindex"].ToString();
            }
        }
    }
}