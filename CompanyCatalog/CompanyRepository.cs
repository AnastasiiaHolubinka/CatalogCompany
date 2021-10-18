using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyCatalog
{
    public class CompanyRepository
    {
        public List<Company> companyRepository { get; set; }
        public CompanyRepository()
        {
            companyRepository = GetCompanyRepo();
        }

        public List<Company> GetCompanyRepo()
        {
            List<Company> listOfCompany = new List<Company>();

            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in CompanyCatalog->Properties-?Settings.settings");
                }

                SqlCommand query = new SqlCommand("SELECT * from Company", conn);
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Company m = new Company();
                    m.Id = (int)row["id"];
                    m.CompanyName = row["CompanyName"].ToString();
                    m.CompanyAddress = row["CompanyAddress"].ToString();
                    m.FoundationYear = (int)row["FoundationYear"];
                    m.AnnualRevenue = (int)row["AnnualRevenue"];
                    m.BusinessType = row["BusinessType"].ToString();
                    

                    listOfCompany.Add(m);
                }

                return listOfCompany;
            }
        }

        public List<Company> GetCompanyRepoSearch(string searchQuery)
        {
            List<Company> listOfCompany = new List<Company>();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in CompanyCatalog->Properties-?Settings.settings");
                }
                SqlCommand query = new SqlCommand("retRecords", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("TitlePhrase", SqlDbType.VarChar);
                param.Value = searchQuery;
                query.Parameters.Add(param);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Company m = new Company();
                    m.Id = (int)row["id"];
                    m.CompanyName = row["CompanyName"].ToString();
                    m.CompanyAddress = row["CompanyAddress"].ToString();
                    m.FoundationYear = (int)row["FoundationYear"];
                    m.AnnualRevenue = (int)row["AnnualRevenue"];
                    m.BusinessType = row["BusinessType"].ToString();
                    listOfCompany.Add(m);
                }
                return listOfCompany;
            }
        }

        public void addNewRecord(Company companyRecord)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in CompanyCatalog->Properties-?Settings.settings");
                }
                else if (companyRecord == null)
                    throw new Exception("The passed argument 'companyRecord' is null");

                SqlCommand query = new SqlCommand("addRecord", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("pCompanyName", SqlDbType.VarChar);
                SqlParameter param2 = new SqlParameter("pCompanyAddress", SqlDbType.VarChar);
                SqlParameter param3 = new SqlParameter("pFoundationYear", SqlDbType.Int);
                SqlParameter param4 = new SqlParameter("pAnnualRevenue", SqlDbType.Int);
                SqlParameter param5 = new SqlParameter("pBusinessType", SqlDbType.VarChar);

                param1.Value = companyRecord.CompanyName;
                param2.Value = companyRecord.CompanyAddress;
                param3.Value = companyRecord.FoundationYear;
                param4.Value = companyRecord.AnnualRevenue;
                param5.Value = companyRecord.BusinessType;

                query.Parameters.Add(param1);
                query.Parameters.Add(param2);
                query.Parameters.Add(param3);
                query.Parameters.Add(param4);
                query.Parameters.Add(param5);

                query.ExecuteNonQuery();
            }
        }

        public void DelRecord(int id)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in CompanyCatalog->Properties-?Settings.settings");
                }

                SqlCommand query = new SqlCommand("deleteRecord", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("pId", SqlDbType.Int);
                param1.Value = id;
                query.Parameters.Add(param1);

                query.ExecuteNonQuery();
            }
        }

        public void UpdateRecord(Company companyRecord)
        {
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connString))
            {
                if (conn == null)
                {
                    throw new Exception("Connection String is Null. Set the value of Connection String in CompanyCatalog->Properties-?Settings.settings");
                }

                SqlCommand query = new SqlCommand("updateRecord", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("pId", SqlDbType.Int);
                SqlParameter param2 = new SqlParameter("pCompanyName", SqlDbType.VarChar);
                SqlParameter param3 = new SqlParameter("pCompanyAddress", SqlDbType.VarChar);
                SqlParameter param4 = new SqlParameter("pFoundationYear", SqlDbType.Int);
                SqlParameter param5 = new SqlParameter("pAnnualRevenue", SqlDbType.Int);
                SqlParameter param6 = new SqlParameter("pBusinessType", SqlDbType.VarChar);

                param1.Value = companyRecord.Id;
                param2.Value = companyRecord.CompanyName;
                param3.Value = companyRecord.CompanyAddress;
                param4.Value = companyRecord.FoundationYear;
                param5.Value = companyRecord.AnnualRevenue;
                param6.Value = companyRecord.BusinessType;

                query.Parameters.Add(param1);
                query.Parameters.Add(param2);
                query.Parameters.Add(param3);
                query.Parameters.Add(param4);
                query.Parameters.Add(param5);
                query.Parameters.Add(param6);

                query.ExecuteNonQuery();
            }
        }
    }
}
