using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Entity;
using System.Data;
using System.Collections;

namespace PetvetPOS_Inventory_System
{
    /// <summary>
    /// Class that involves in creating an sql statement and returning 
    /// data from the database
    /// </summary>
    public abstract class DatabaseMapper
    {
        protected MySqlDB db;
        protected MySqlCommand command;
        protected MySqlDataReader reader;
        protected  object id;

        public string tableName, insertQuery, selectQuery, deleteQuery, updateQuery;
        protected string[] fieldsname;
        protected string[] fieldsname_forselect;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="db"> mysqldb instance </param>
        public DatabaseMapper(MySqlDB db)
        {
            this.db = db;
        }

        /// <summary>
        /// It returns a single data from table
        /// </summary>
        /// <param name="fieldname"> the field to return</param>
        /// <param name="condition"> condition </param>
        /// <returns> object of single data </returns>
        protected object readScalar(string fieldname, string condition)
        {
            try
            {
                selectQuery = String.Format("SELECT {0} FROM {1} ", fieldname, tableName);
                selectQuery += String.Format("WHERE {0}", condition);
                return getScalarValue(selectQuery);
            }catch(Exception){
                return 0;
            }
        }

        /// <summary>
        /// Initialize and setup the select query with condition
        /// </summary>
        /// <param name="condition"> condition </param>
        public void setSelectQuery(string condition)
        {
            setSelectQuery();
            selectQuery += String.Format(" WHERE {0}", condition);
        }

        /// <summary>
        /// Initialize and setup a select query without condition
        /// </summary>
        public void setSelectQuery()
        {
            try
            {
                string[] selectFields;
             
                if (fieldsname_forselect == null)
                    selectFields = fieldsname;
                else
                    selectFields = fieldsname_forselect;

                selectQuery = "SELECT ";
                int n = selectFields.Length;
                for (int i = 0; i < n; i++)
                {
                    if (i == (n - 1))
                        selectQuery += selectFields[i];
                    else
                        selectQuery += selectFields[i] + ", ";
                }
                selectQuery += String.Format(" FROM {0}", tableName);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
        }


        /// <summary>
        /// Programmatically create an update command statement
        /// </summary>
        /// <param name="condition"> condition </param>
        /// <param name="fields"> fields to update </param>
        /// <returns> the update command </returns>
        public string updateSet(string condition, params string[] fields)
        {
            try{
                updateQuery = String.Format("UPDATE {0} SET ", tableName);
                List<string> fields_that_is_not_null = new List<string>();

                foreach (string x in fields){
                    if (!String.IsNullOrEmpty(x))
                        fields_that_is_not_null.Add(x);
                }

                int n = fields_that_is_not_null.Count;
                for (int i = 0; i < n; i++){
                    if (i == (n - 1))
                        updateQuery += fields_that_is_not_null[i];
                    else
                        updateQuery += fields_that_is_not_null[i] + ", ";
                }

                updateQuery += String.Format(" WHERE {0}", condition);
                return updateQuery;
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
                return string.Empty;
            }
        }


        protected List<Entity> getListOfEntity(string condition)
        {
            List<Entity> entities = new List<Entity>();

            try
            {
                db.open();
                setSelectQueryForGetEntity(condition);
                using (command = new MySqlCommand(selectQuery, db.Connection))
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Entity entity = new Entity(this.id, fieldsname);
                        int n = fieldsname.Length;
                        for (int i = 0; i < n; i++)
                            entity.setField(fieldsname[i], reader.GetValue(i));
                        entities.Add(entity);
                    }
                    db.close();
                }
            }
            catch (MySqlException mex)
            {
                ErrorLog.Log(mex);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
            finally
            {
                db.dispose();
            }
            return entities;
        }

        
        private Entity getEntity()
        {
            Entity entity = new Entity(this.id, fieldsname);
            
            try
            {
                db.open();
                using (command = new MySqlCommand(selectQuery, db.Connection))
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int n = fieldsname.Length;
                        for (int i = 0; i < n; i++)
                            entity.setField(fieldsname[i], reader.GetValue(i));
                    }
                    db.close();
                }

            }
            catch (MySqlException mex)
            {
                ErrorLog.Log(mex);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
            finally
            {
                db.dispose();
            }
            return entity;
        }

        /// <summary>
        /// Overload of getEntityFromId(object id); works as the same but instead
        /// of returning a row based on primary key, it works from a condition
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public Entity getEntityWhere(string condition)
        {
            setSelectQueryForGetEntity(condition);
            return getEntity();
        }

        /// <summary>
        /// A wrapper method that sets the select query outsmarting
        /// the setSelectQuery() by temporarily setting the
        /// fieldsname_forselect field to null.
        /// 
        /// This method should be only use by getEntityWhere(string condition)
        /// and getEntityFromId() methods
        /// </summary>
        /// <param name="condition"> the condition of select query </param>
        private void setSelectQueryForGetEntity(string condition)
        {
            string[] holder = fieldsname_forselect;
            fieldsname_forselect = null;
            setSelectQuery(condition);
            fieldsname_forselect = holder;
        }

        /// <summary>
        /// This returns a single row from a table and store it in the Entity class
        /// based on the primary key
        /// </summary>
        /// <param name="id"> the primary key of the table </param>
        /// <returns> An Entity object </returns>
        public Entity getEntityFromId(object id) 
        {
            string condition = "";
            if (id is string)
                condition = String.Format(" {0} = '{1}'", this.id, id);
            else
                condition=  String.Format(" {0} = {1}", this.id, id);

            setSelectQueryForGetEntity(condition);
            return getEntity();
        }

        /// <summary>
        /// Programmatically generate an insert command
        /// </summary>
        /// <param name="args"> The array of Values in an insert command </param>
        /// <returns> The insert command string </returns>
        protected string insertValues(params object[] args)
        {
            try
            {
                insertQuery = "INSERT INTO " + tableName + "(";
                int n = fieldsname.Length;
                int lastIndex = n - 1;
                for (int i = 0; i < n; i++)
                {
                    if (i == lastIndex)
                        insertQuery += fieldsname[i];
                    else
                        insertQuery += fieldsname[i] + ", ";
                }

                insertQuery += ") VALUES(";

                n = args.Length;
                lastIndex = n - 1;
                for (int i = 0; i < n; i++)
                {
                    string argsWithQuote = "'{" + i + "}'";
                    string argsWithoutQuote = "{" + i + "}";

                    if (args[i] is Int32 || args[i] is Decimal)
                    {
                        if (i == lastIndex)
                            insertQuery += argsWithoutQuote;
                        else
                            insertQuery += argsWithoutQuote + ", ";
                    }

                    if (args[i] is string)
                    {
                        string foo = (string)args[i];
                        if (foo.Contains('(') && foo.Contains(')') || foo == "null")
                        {
                            if (i == lastIndex)
                                insertQuery += argsWithoutQuote;
                            else
                                insertQuery += argsWithoutQuote + ", ";
                            continue;
                        }

                        if (i == lastIndex)
                            insertQuery += argsWithQuote;
                        else
                            insertQuery += argsWithQuote + ", ";
                    }
                }

                insertQuery += ")";
                return String.Format(insertQuery, args);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
                return string.Empty;
            }
        }

        /// <summary>
        /// CREATE: to be call when inserting row in table
        /// </summary>
        /// <param name="commandText"> the insert query </param>
        /// <returns> true when command is successful</returns>
        protected bool create(string commandText)
        {
            return createUpdateDelete(commandText);
        }

        /// <summary>
        /// UPDATE: to be call when updating
        /// </summary>
        /// <param name="commandText"> the update query</param>
        /// <returns> true when successful </returns>
        protected bool update(string commandText)
        {
            return createUpdateDelete(commandText);
        }

        /// <summary>
        /// DELETE: to be call when deleting
        /// </summary>
        /// <param name="commandText"> the delete query</param>
        /// <returns> true when command is successful </returns>
        protected bool delete(string commandText)
        {
            return createUpdateDelete(commandText);
        }

        private object getScalarValue(string commandText)
        {
            object value = 0;
            try
            {
                db.open();
                using (command = new MySqlCommand(@commandText, db.Connection))
                    value = command.ExecuteScalar();
                db.close();
            }
            catch (MySqlException mex)
            {
                ErrorLog.Log(mex);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
            finally
            {
                db.dispose();
            }

            return value;
        }

        protected List<string> getList(string field){
            return getList(field, string.Empty);
        }


        protected List<string> getList(string field, string condition)
        {
            List<string> list = new List<string>();

            string selectQuery = string.Format("SELECT {0} FROM {1}", field, tableName);
            if(!string.IsNullOrWhiteSpace(condition))
                selectQuery += string.Format(" WHERE {0}", condition);

            try
            {
                db.open();
                using (command = new MySqlCommand(selectQuery, db.Connection))
                using (reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        list.Add(reader.GetString(field));
                }
            }
            catch (MySqlException mex)
            {
                ErrorLog.Log(mex);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
            finally
            {
                db.dispose();
            }
            
            return list;
        }


        private bool createUpdateDelete(string commandText)
        {
            bool success = false;
            
            try
            {
                db.open();
                using (command = new MySqlCommand(@commandText, db.Connection))
                    command.ExecuteNonQuery();
                db.close();
                success = true;
            }
            catch (MySqlException mx)
            {
                success = false;
                ErrorLog.Log(mx);
            }
            catch (Exception ex)
            {
                success = false;
                ErrorLog.Log(ex);
            }
            finally
            {
                db.dispose();
            }
            
            return success;
        }

        private object locker = new object();

        protected DataTable selectRows(DataTable dataTable, string query)
        {
            try
            {
                if (db.Connection.State != ConnectionState.Open)
                    db.open();

                lock (locker){
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = new MySqlCommand(query, db.Connection);
                    adapter.Fill(dataTable);   
                }
            }
            catch (MySqlException mex)
            {
                ErrorLog.Log(mex);
            }
            catch (Exception ex)
            {
                ErrorLog.Log(ex);
            }
            finally
            {
                if (db.Connection.State == ConnectionState.Open)
                    db.dispose();
            }

            return dataTable;
        }

        /// <summary>
        /// Return a table from database
        /// </summary>
        /// <param name="dt"> DataTable to where to populate the data </param>
        /// <returns> a DataTable of Data </returns>
        public DataTable loadTable(DataTable dt)
        {
            setSelectQuery();
            return selectRows(dt, selectQuery);
        }

        /// <summary>
        /// Return a table from database with specific condition
        /// </summary>
        /// <param name="dt"> DataTable to return </param>
        /// <param name="condition"></param>
        /// <returns> A Datatable </returns>
        public DataTable loadTable(DataTable dt, string condition){
            setSelectQuery(condition);
            return selectRows(dt, selectQuery);
        }

        /// <summary>
        /// Return a table from query
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="query"></param>
        /// <returns> A Datatable</returns>
        public DataTable loadTableFromQuery(DataTable dt, string query)
        {
            return selectRows(dt, query);
        }



    }
}
  