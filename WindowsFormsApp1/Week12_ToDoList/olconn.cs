using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace Win
{
    class olconn
    {
        string sql = ConfigurationManager.ConnectionStrings["todo"].ConnectionString;
        OleDbConnection G_con;
        OleDbCommand G_com;
        OleDbDataAdapter G_da;
        DataSet G_ds;

        #region  构造函数

        public olconn()
        {

        }

        #endregion

        public OleDbConnection GetCon()
        {
            G_con = new OleDbConnection(sql);
            G_con.Open();
            return G_con;
        }

        public bool GetExecute(string cmdtxt)
        {
            G_com = new OleDbCommand(cmdtxt, GetCon());
            G_com.ExecuteNonQuery();
            G_con.Close();
            G_con.Dispose();
            return true;
        }

        public DataSet GetDs(string cmdtxt)
        {
            G_da = new OleDbDataAdapter(cmdtxt, GetCon());
            G_ds = new DataSet();
            G_da.Fill(G_ds);
            G_con.Close();
            G_con.Dispose();
            return G_ds;
        }

        public OleDbDataReader Getreeader(string cmdtxt)
        {
            G_com = new OleDbCommand(cmdtxt, GetCon());
            OleDbDataReader P_dr;
            P_dr = G_com.ExecuteReader(CommandBehavior.CloseConnection);
            return P_dr;
        }

        public DataSet ExecuteDataSet(string cmdtxt)
        {
            G_com = new OleDbCommand(cmdtxt, GetCon());
            OleDbDataAdapter da = new OleDbDataAdapter(G_com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            G_con.Close();
            G_con.Dispose();
            return ds;
        }
    }
}
