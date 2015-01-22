using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BoulderWhiteRock
{
    public partial class BWRDataAccess
	{
        string connectionString = "";

        //public DataAccess()
        //{
        //}

        //public DataAccess(string connectionString)
        //{
        //    this.connectionString = connectionString;
        //}

        public SqlConnection CreateConnection()
        {
            if (!String.IsNullOrEmpty(connectionString)) return new SqlConnection(connectionString);

            var cs = ConfigurationManager.ConnectionStrings["WaterRights"];
            if (cs != null)
                connectionString = cs.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                var webConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(null);
                if (webConfig != null && webConfig.ConnectionStrings.ConnectionStrings.Count > 0)
                {
                    cs = webConfig.ConnectionStrings.ConnectionStrings["WaterRights"];
                    if (cs != null)
                        connectionString = cs.ConnectionString;
                }
            }

            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("Connection string not found: WaterRights");

            return new SqlConnection(connectionString);
        }

        private int _timeout = -1;
        private int TimeOut
        {
            get
            {
                if (_timeout == -1)
                {
                    try
                    {
                        _timeout = System.Configuration.ConfigurationManager.AppSettings["WRDatabaseTimeoutInSeconds"] == null ? 30 : Int32.Parse(System.Configuration.ConfigurationManager.AppSettings["wrDatabaseTimeoutInSeconds"]);
                    }
                    catch (Exception)
                    {
                        _timeout = 30;
                    }
                }
                return _timeout;
            }
        }

        public String GetHomeText()
        {
            String text = "";
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspGetBWRHome", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            text = rdr["Home"].ToString();
                            text = text = Regex.Replace(text, @"(?:\r\n *){1,2} *", "<br />");
                        }
                    }
                }
            }
            return text;
        }

        public String GetWaterSharesText()
        {
            String text = "";
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspGetBWRWaterShares", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            text = rdr["WaterShares"].ToString();
                            text = text = Regex.Replace(text, @"(?:\r\n *){1,2} *", "<br />");
                        }
                    }
                }
            }
            return text;
        }

        public String GetBoardOfDirectorsText()
        {
            String text = "";
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspGetBWRBoardOfDirectors", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            text = rdr["BoardOfDirectors"].ToString();
                            text = text = Regex.Replace(text, @"(?:\r\n *){1,2} *", "<br />");
                        }
                    }
                }
            }
            return text;
        }

        public String GetWaterStatisticsText()
        {
            String text = "";
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspGetBWRWaterStatistics", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            text = rdr["WaterStatistics"].ToString();
                            text = text = Regex.Replace(text, @"(?:\r\n *){1,2} *", "<br />");
                        }
                    }
                }
            }
            return text;
        }

        public String GetNewsAndEventsText()
        {
            String text = "";
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspGetBWRNewsAndEvents", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            text = rdr["NewsAndEvents"].ToString();
                            text = text = Regex.Replace(text, @"(?:\r\n *){1,2} *", "<br />");
                        }
                    }
                }
            }
            return text;
        }

        public String GetContactUsText()
        {
            String text = "";
            using (SqlConnection conn = CreateConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("uspGetBWRContactUs", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            text = rdr["ContactUs"].ToString();
                            text = Regex.Replace(text, @"(?:\r\n *){1,2} *", "<br />");
                        }
                    }
                }
            }
            return text;
        }
    }
}
