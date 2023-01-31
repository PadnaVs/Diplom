using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Diplom_V4.src;

namespace Diplom_V4
{
    public class NetControl
    {
        public delegate void NCHeandler();
        public event NCHeandler useresAreFull;

        private static string _conStr = ConfigurationManager.ConnectionStrings["TestCs"].ConnectionString;
        public SqlConnection sqlConnetion = new SqlConnection(_conStr);

        public User currentUser = new User();
        public async void conectionToDb()
        {
            await this.sqlConnetion.OpenAsync();
        }

        public void connetionClose()
        {
            this.sqlConnetion.Close();
        }

        public async void inserToBd(string sqlCommand)
        {
            SqlCommand sqlCom = new SqlCommand(sqlCommand, this.sqlConnetion);
            try
            {
                await sqlCom.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                MessageBox.Show("Изменения в базе данных успешно сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public async void getIncomingUser(string who, string email)
        {
            string sqlCommand = "SELECT * FROM Users WHERE userType = " + "\'" + who + "\' AND email = " + "\'" + email + "\'";
            SqlCommand sqlCom = new SqlCommand(sqlCommand, this.sqlConnetion);
            SqlDataReader sqlReader = null;
            try
            {
                sqlReader = await sqlCom.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    User user = new User();
                    user.id = sqlReader.GetInt32(0);
                    user.name = sqlReader.GetString(1);
                    user.lasnName = sqlReader.GetString(2);
                    user.email = sqlReader.GetString(3);
                    user.userType = sqlReader.GetString(4);
                    user.password = sqlReader.GetString(5);
                    user.numGroup = sqlReader.GetString(6);

                    this.currentUser = user;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
                useresAreFull?.Invoke();
            }
        }

        public async void fillCollUsers(string who)
        {
            string sqlCommand = "SELECT * FROM Users WHERE userType = " + "\'" + who + "\'";
            SqlCommand sqlCom = new SqlCommand(sqlCommand, this.sqlConnetion);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await sqlCom.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    User user = new User();
                    user.id = sqlReader.GetInt32(0);
                    user.name = sqlReader.GetString(1);
                    user.lasnName = sqlReader.GetString(2);
                    user.email = sqlReader.GetString(3);
                    user.userType = sqlReader.GetString(4);
                    user.password = sqlReader.GetString(5);
                    user.numGroup = sqlReader.GetString(6);

                    App.data.users.Add(user);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
                useresAreFull?.Invoke();
            }
        }

        public void saveTest( int _idU, string _name, string _testStrJson ) 
        {
            string insertTestString = "INSERT INTO Tests( Name, StrTest, UId ) VALUES( '" + _name + "','" + _testStrJson + "',  '" + _idU + "' )";
            inserToBd(insertTestString);
            MessageBox.Show( "Ваш тест успешно сохранен!", "Информация.", MessageBoxButton.OK, MessageBoxImage.Information );
        }

        public async void checkCreateTest(string _name, string jso ) 
        {
            bool result = false;
            try
            {
                string sqlCommand = "SELECT * FROM Tests WHERE Name = " + "'" + _name + "'" + "";
                SqlCommand sqlCom = new SqlCommand(sqlCommand, this.sqlConnetion);
                SqlDataReader sqlReader = null;

                sqlReader = await sqlCom.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    result = true;
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (!result)
                {
                    saveTest( currentUser.id, _name, jso );
                    getAllTests();
                }
                else 
                {
                    MessageBox.Show("Такой тест уже существует!", "Такой тест уже существует!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

        }

        public async void getAllTests() 
        {
            string sqlCommand = "SELECT * FROM Tests INNER JOIN Users ON Users.id = Tests.UId";
            SqlCommand sqlCom = new SqlCommand(sqlCommand, this.sqlConnetion);

            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await sqlCom.ExecuteReaderAsync();
               
                App.data.TestsLoaded.Clear();
                
                while (await sqlReader.ReadAsync())
                {
                    User user = new User();
                    user.id = sqlReader.GetInt32(4);
                    user.name = sqlReader.GetString(5);
                    user.lasnName = sqlReader.GetString(6);
                    user.email = sqlReader.GetString(7);
                    user.userType = sqlReader.GetString(8);
                    user.password = sqlReader.GetString(9);
                    user.numGroup = sqlReader.GetString(10);

                    var test = JsonConvert.DeserializeObject<ObservableCollection<TaskTest>>(sqlReader.GetString(2));
                    
                    LoadTest newLoadtest = new LoadTest();
                    newLoadtest.Name = sqlReader.GetString(1);
                    newLoadtest.Creater = user;
                    newLoadtest.Tasks = test;

                    App.data.TestsLoaded.Add(newLoadtest);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }
        public async void delSelectTest( int _idUsert, string _nameTest)
        {
            string sqlCommand = "DELETE FROM Tests WHERE Name = " + "'" + _nameTest + "'" + " AND UId = " + _idUsert.ToString() + "";
            SqlCommand sqlCom = new SqlCommand(sqlCommand, this.sqlConnetion);
            try
            {
                await sqlCom.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void updateTests( string tNameStart, string tNameEnd, string tJs ) 
        {
            string updateTestStrSQL = "UPDATE Tests SET Name = '" + tNameEnd + "', StrTest = '" + tJs + "' WHERE Name = '" + tNameStart + "'";

            if (tNameEnd == null || tNameEnd == "") 
                   updateTestStrSQL = "UPDATE Tests SET StrTest = '" + tJs + "' WHERE Name = '" + tNameStart + "'";

            if(tJs == null || tJs == "")
                updateTestStrSQL = "UPDATE Tests SET Name = '" + tNameEnd + "' WHERE Name = '" + tNameStart + "'";

            inserToBd(updateTestStrSQL);
        }
    }
}

