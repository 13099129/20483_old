using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            InsertBook("5", "book1", "2019");

            System.Data.DataTable dt = GetTable("Select * from books");
            foreach(System.Data.DataRow row in dt.Rows)
            {
                Console.WriteLine(row["title"].ToString()   );
            }
            Console.ReadLine();
        }


        static System.Data.DataTable GetTable(string sql)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            //string cnstr = "server=student\sqlexpress;database=library;uid=sa;pwd=secret";
            string cnstr = "server=student\\sqlexpress;database=library;integrated security=true";
            System.Data.SqlClient.SqlDataAdapter da 
                = new System.Data.SqlClient.SqlDataAdapter(sql,cnstr);
            da.Fill(dt);
            return dt;
        }

        static bool InsertBook(string id, string title, string pubyear)
        {
            bool result = true;
            string sql = $"INSERT INTO Books(title,publishYear) VALUES('{title}',{pubyear})";
            string cnstr = "server=student\\sqlexpress;database=library;integrated security=true";
            using (System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(cnstr))
            {
                cn.Open();
                System.Data.SqlClient.SqlTransaction tx = cn.BeginTransaction();
                System.Data.SqlClient.SqlCommand cm = new System.Data.SqlClient.SqlCommand(sql, cn, tx);
                try
                {
                    cm.ExecuteNonQuery();
                    tx.Commit();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    tx.Rollback();
                    result = false;
                }
                finally
                {
                    cn.Close();
                }
            }//close using block
            return result;
        }


        static System.Data.DataSet BuildDB()
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            System.Data.DataTable booksTable = new System.Data.DataTable();
            booksTable.Columns.Add("BookId");
            booksTable.Columns.Add("Title");

            ds.Tables.Add(booksTable);

            System.Data.DataRow bookRow = booksTable.NewRow();

            bookRow[0] = "123";
            bookRow["Title"] = "Wrinkle in Time";

            booksTable.Rows.Add(bookRow);

            System.Data.DataView dv 
                = new System.Data.DataView(booksTable, "title>'m'","title asc"
                   ,System.Data.DataViewRowState.CurrentRows);


            return ds;
        }

    }
}
