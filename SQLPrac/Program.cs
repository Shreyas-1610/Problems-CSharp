using Microsoft.Data.SqlClient;

namespace SQLPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=SHREYAS\SQLEXPRESS;Initial Catalog=shreyasdb;Integrated Security=True;Trust Server Certificate=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            try
            {

                Console.WriteLine("Database connected successfully");
                string answer;
                do
                {
                    Console.WriteLine("Select from the options\n1.Create\n2.Retrieve\n3.Update\n4.Delete");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            //Create
                            Console.WriteLine("Enter your name");
                            String userName = Console.ReadLine();
                            Console.WriteLine("Enter your age");
                            int userAge = int.Parse(Console.ReadLine());
                            string insertQuery = "INSERT INTO Details (user_name, user_age) VALUES('" + userName + "'," + userAge + ")";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.ExecuteNonQuery();
                            Console.WriteLine("Data stored successfully");
                            break;
                        case 2:
                            //Retrieve
                            string displayQuery = "SELECT * FROM Details";
                            SqlCommand viewCommand = new SqlCommand(displayQuery, sqlConnection);
                            SqlDataReader dataReader = viewCommand.ExecuteReader();
                            while (dataReader.Read())
                            {
                                Console.WriteLine("Id: "+dataReader.GetValue(0).ToString());
                                Console.WriteLine("Name: " + dataReader.GetValue(1).ToString());
                                Console.WriteLine("Age: " + dataReader.GetValue(2).ToString());
                            }
                            dataReader.Close();
                            break;
                        case 3:
                            //update
                            String u_name;
                            int u_id;
                            Console.WriteLine("Enter the id of the entry to be Updated");
                            u_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the name you would like to change");
                            u_name = Console.ReadLine();
                            String updateQuery = "UPDATE Details SET user_name = '" + u_name + "' WHERE user_id = " + u_id + "";
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                            updateCommand.ExecuteNonQuery();
                            Console.WriteLine("Successfully updated");
                            break;
                        case 4:
                            //delete
                            int d_id;
                            Console.WriteLine("Enter the id of the entry to be removed");
                            d_id = int.Parse(Console.ReadLine());
                            String deleteQuery = "DELETE FROM Details WHERE user_Id = " + d_id + "";
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
                            deleteCommand.ExecuteNonQuery();
                            Console.WriteLine("Successfully deleted");
                            break;
                        default:
                            Console.WriteLine("Please enter the valid choice");
                            break;
                    }
                    Console.WriteLine("Do you want to continue?");
                    answer = Console.ReadLine();
                } while (answer != "No");


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }

        }
    }
}
