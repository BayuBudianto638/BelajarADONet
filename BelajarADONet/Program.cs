// ADO.NET = ActiveX Data Objects .NET
// ADO = ActiveX Data Objects. Digunakan oleh developer yg menggunakan VS untuk mengakses database.
// Visual Studio 6 di scrap ===> ADO .NET vs ADO. 
// Visual Studio yang menggunakan ADO adalah mayoritas Programmer Visual Basic.
// Visual Studio = VB, C++, Foxpro dan ASP Classic.
// C++ biasanya di gunakan untuk ke alat atau hardware pakai MFC (Microsoft Foundation Class_
// Foxpro dia ada konektor ke table *.db
// Visual Basic ADO. Setiap programmer boleh membuka koneksi sendiri.
// ASP = ODBC.

// VS .NET dia pakai teknologi baru yg namanya adalah ADO .NET.
// ADO .NET untuk mengakses yang namanya RDBMS bernama SQL Server.
// JSON = Javascript Object Notation. Format data.
// XML = Xtra Markup Language
// ini = Initiliation
// SQL Server --> Koneksi 1 ---> Load Query (CLOSE)--> Akan terus Open smp Koneksi di close
//            ----> Koneksi 2 ---> Load Query (RUNNING)
//            ----> Koneksi 3 ---> Load Query (Suspend)
//            ----> Koneksi 4 ---> Load Query (Suspend) 
// Visual J# <--- di hapus karena kena tuntut Sun Microsystem terkait Java.
// J++ di remove.
// J#
// ASP.Net, VB .Net, C++ (MFC Remove), J# dan C#.
// J# dihapus
// C++ MFC dikembalikan lg
// ASP.NET mirip web form.
// Dapper = OM = Object Mapping.

// 1. Kurangi penggunaan COALESCE
// 2. Kurangi penggunaan IIF dan CASE
// 3. Kurangi penggunaan CURSOR
// 4. Gunakan InMemory Database karena tidak perlu open dan close connection setiap x request

// Aplikasi -----> DataProvider ----> DataBase
// Aplikasi <----- DataProvider <---- DataBase

// public SQLCommand sqlCommand(string query, SqlParameter[] parameters)
// {
//        loop parameters
//        sqlcommand.commandtext = query;
//        sqlcommand.add(parameter);
//        return sqlcommand;
// }

// sqlParameter.add(value);
// sqlParameter.add(value);
// var cmd = sqlCommand("InsertStudent", parameters);

//using System.Data.SqlClient;

//class Program
//{
//    static void Main()
//    {
//        SqlConnection sqlConnection
//              = new SqlConnection("Server=FAIRUZ-PC\\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True;");

//        try
//        {          
//            sqlConnection.Open(); // membuka koneksi ke server DB
//            // Manipulasi DML
//            Console.WriteLine("Connect to DB Successfully!");
//        }
//        catch(Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

// Object dalam ADO .NET
// 1. Connection atau SQLConnecton => Koneksi ke database
// 2. Command = SQLCommand => dipakai untuk mengeksekusi Query untuk DDL atau DML
// 3. DataReader = SQLDataReader => dipakai untuk membaca data
// 4. DataAdapter = SQLDataAdapter => dipakai sebagai jembatan antara datasource dgn DataSet
//                                      atau DataTable
// 5. DataSet = SQLDataSet => dipakai sebagai inmemory database, DS adalah koleksi dari 
//                              banyak table. Koneksi tidak harus open. Karena jika sudah 
//                              diload ke InMemory, koneksi di close.
//using System.Data.SqlClient;
//using System.Configuration;
//class Program
//{
//    static void Main()
//    {
//        string ConString = 
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {
//            sqlConnection.Open(); // membuka koneksi ke server DB
//            // Manipulasi DML
//            Console.WriteLine("Connect to DB Successfully!");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {            
//            // Manipulasi DDL via SQLCommand
//            SqlCommand cmd = new SqlCommand(@"CREATE TABLE Students(Id INT NOT NULL,
//                                            Name VARCHAR(50),
//                                            Age INT)", sqlConnection);
//            sqlConnection.Open(); // membuka koneksi ke server DB
//            cmd.ExecuteNonQuery(); // mengeksekusi perintah query DDL
//            Console.WriteLine("Table created Successfully!");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {
//            // Manipulasi DML via SQLCommand
//            SqlCommand cmd = new SqlCommand(@"INSERT INTO Students
//                    (Id, Name, Age) VALUES 
//                    (1, 'Anton', 25)", sqlConnection);
//            sqlConnection.Open(); // membuka koneksi ke server DB
//            cmd.ExecuteNonQuery(); // mengeksekusi perintah query DDL/DML tanpa Return/Result
//            Console.WriteLine("Insert Table Successfully!");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {
//            // Manipulasi DML via SQLCommand
//            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Students", sqlConnection);
//            sqlConnection.Open(); // membuka koneksi ke server DB
//            // mengeksekusi perintah query DDL/DML dengan Return/Result dan SQLDataReader
//            SqlDataReader sdr = cmd.ExecuteReader();

//            // Loop SDR
//            while (sdr.Read())
//            {
//                Console.WriteLine(sdr["Id"] + " " + sdr["Name"] + " " + sdr["Age"]);
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {
//            // Manipulasi DML via SQLCommand
//            SqlCommand cmd = new SqlCommand(@"UPDATE Students
//                                                SET Name ='Anton Medan',
//                                                Age=30 WHERE Id = 1", sqlConnection);
//            sqlConnection.Open(); // membuka koneksi ke server DB
//            cmd.ExecuteNonQuery();

//            Console.WriteLine("Update Student Successfully");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;

//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {
//            // Manipulasi DML via SQLCommand
//            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students;", sqlConnection);
//            sqlConnection.Open(); // membuka koneksi ke server DB

//            DataSet ds = new DataSet();

//            sda.Fill(ds); // mengisi dataset via sqldataadapter
//            sqlConnection.Close(); // tutup koneksi ke server DB

//            // akses ke table rows dan assign ke datarow
//            // untuk di ambil row 1 per 1
//            Console.WriteLine("Using DataSet");
//            foreach (DataRow row in ds.Tables[0].Rows) // Rows = Collection dari DataRow
//            {
//                Console.WriteLine(row["Id"] + " " + row["Name"] + " " + row["Age"]);
//            }

//            Console.WriteLine("Using DataTable");
//            DataTable dt = new DataTable(); // menggunakan DataTable
//            sda.Fill(dt);

//            foreach (DataRow row in dt.Rows) // Rows = Collection dari DataRow
//            {
//                Console.WriteLine(row["Id"] + " " + row["Name"] + " " + row["Age"]);
//            }

//            Console.WriteLine("Select Student Successfully");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;

//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {
//            // Manipulasi DML via SQLCommand
//            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Students;" +
//                "SELECT * FROM Courses", sqlConnection);
//            sqlConnection.Open(); // membuka koneksi ke server DB

//            DataSet ds = new DataSet();

//            sda.Fill(ds); // mengisi dataset via sqldataadapter
//            sqlConnection.Close(); // tutup koneksi ke server DB

//            // akses ke table rows dan assign ke datarow
//            // untuk di ambil row 1 per 1
//            Console.WriteLine("Student");
//            foreach (DataRow row in ds.Tables[0].Rows) // Rows = Collection dari DataRow
//            {
//                Console.WriteLine(row["Id"] + " " + row["Name"] + " " + row["Age"]);
//            }

//            Console.WriteLine("Courses");
//            foreach (DataRow row in ds.Tables[1].Rows) // Rows = Collection dari DataRow
//            {
//                Console.WriteLine(row["Id"] + " " + row["Name"]);
//            }

//            Console.WriteLine("Select Student Successfully");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;

//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {
//            // Manipulasi DML via SQLCommand
//            string query = @"SELECT * FROM Courses WHERE Id = @Id";
//            Console.Write("Input Id :");
//            int Id = int.Parse(Console.ReadLine());

//            SqlCommand cmd = new SqlCommand(query, sqlConnection);
//            cmd.Parameters.AddWithValue("@Id", Id);
//            sqlConnection.Open(); // membuka koneksi ke server DB

//            SqlDataReader sdr = cmd.ExecuteReader();

//            // akses ke table rows dan assign ke datarow
//            // untuk di ambil row 1 per 1
//            Console.WriteLine("Courses");
//            while(sdr.Read())
//            {
//                Console.WriteLine(sdr[0] + " " + sdr[1]);
//            }

//            Console.WriteLine("Select Courses Successfully");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;

//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {
//            // Manipulasi DML via SQLCommand
//            string query = @"INSERT INTO Courses (Name) VALUES 
//                                (@Name)";

//            Console.Write("Input Name :");
//            string Name = Console.ReadLine();

//            SqlCommand cmd = new SqlCommand(query, sqlConnection);
//            cmd.Parameters.AddWithValue("@Name", Name); // Kirim parameter ke SQLCmd
//            sqlConnection.Open(); // membuka koneksi ke server DB

//            cmd.ExecuteNonQuery();

//            Console.WriteLine("Insert Courses Successfully");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;

//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {
//            // Manipulasi DML via SQLCommand
//            string query = @"UPDATE Courses SET Name=@Name WHERE Id = @Id";

//            Console.Write("Input Id :");
//            int Id = int.Parse(Console.ReadLine());

//            Console.Write("Input Name :");
//            string Name = Console.ReadLine();

//            SqlCommand cmd = new SqlCommand(query, sqlConnection);
//            cmd.Parameters.AddWithValue("@Id", Id);
//            cmd.Parameters.AddWithValue("@Name", Name); // Kirim parameter ke SQLCmd
//            sqlConnection.Open(); // membuka koneksi ke server DB

//            cmd.ExecuteNonQuery();

//            Console.WriteLine("Insert Courses Successfully");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;

//class Program
//{
//    static void Main()
//    {
//        string ConString =
//            ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

//        SqlConnection sqlConnection
//              = new SqlConnection(ConString);

//        try
//        {            
//            SqlCommand cmd = new SqlCommand();
//            cmd.Connection = sqlConnection;
//            cmd.CommandType = CommandType.StoredProcedure; // mengakses StoredProcedure
//            cmd.CommandText = "GetStudentById"; // Nama Procedure
//            cmd.Parameters.AddWithValue("@Id", 1);
//            sqlConnection.Open(); // membuka koneksi ke server DB

//            SqlDataReader reader = cmd.ExecuteReader();

//            while(reader.Read())
//            {
//                Console.WriteLine(reader["Id"] + " " + reader["Name"] + " " + reader["Age"]);
//            }

//            Console.WriteLine("SELECT Student Successfully");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.ToString());
//        }
//        finally
//        {
//            sqlConnection.Close(); // tutup koneksi ke server DB
//        }
//    }
//}

using System.Configuration;
using System.Data.SqlClient;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public interface IDataAcess
{
    List<Student> GetAllStudent();
    Student GetStudentById(int id);
    void InsertStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(int id);
}

public abstract class DataAccessBase : IDataAcess
{
    public abstract void DeleteStudent(int id);

    public abstract List<Student> GetAllStudent();

    public abstract Student GetStudentById(int id);

    public abstract void InsertStudent(Student student);

    public abstract void UpdateStudent(Student student);
}

public class AdoNetDataAccess : DataAccessBase
{
    private readonly SqlConnection _connection;

    public AdoNetDataAccess(SqlConnection connection)
    {
        _connection = connection;
    }

    public override void DeleteStudent(int id)
    {
        using (var cmd = _connection.CreateCommand())
        {
            cmd.CommandText = "DELETE FROM Students WHERE Id = @Id";
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }

    public override List<Student> GetAllStudent()
    {
        using (var command = _connection.CreateCommand())
        {
            command.CommandText = "SELECT * FROM Students";

            using (var reader = command.ExecuteReader())
            {
                var students = new List<Student>(); //collection students

                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Age = (int)reader["Age"]
                    });
                }

                return students;
            }
        }
    }

    public override Student GetStudentById(int id)
    {
        using (var command = _connection.CreateCommand())
        {
            command.CommandText = "SELECT * FROM Students WHERE Id = @id";
            command.Parameters.AddWithValue("@id", id);

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Student
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Age = (int)reader["Age"]
                    };
                }
            }
        }
        // return null --> ini tetap makan memory meskipun null.
        return new Student();
    }

    public override void InsertStudent(Student student)
    {
        using (var command = _connection.CreateCommand())
        {
            //command.CommandText = "INSERT INTO Students (Name, Age) VALUES (@name, @age)";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "CreateStudent";
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@age", student.Age);
            command.ExecuteNonQuery();
        }
    }

    public override void UpdateStudent(Student student)
    {
        using (var command = _connection.CreateCommand())
        {
            command.CommandText = "UPDATE Students SET Name = @name, Age = @age WHERE Id = @id";
            command.Parameters.AddWithValue("@id", student.Id);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@age", student.Age);
            command.ExecuteNonQuery();
        }
    }
}

class Program
{
    private static readonly string ConString =
        ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
    //@"Server=FAIRUZ-PC\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;";

    public static void Main()
    {
        SqlConnection sqlConnection = new SqlConnection(ConString);
        sqlConnection.Open();

        // Create an instance of the data access layer
        IDataAcess dataAccess = new AdoNetDataAccess(sqlConnection);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. View all students");
            Console.WriteLine("2. View student by ID");
            Console.WriteLine("3. Add new student");
            Console.WriteLine("4. Update student");
            Console.WriteLine("5. Delete student");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                // Call the GetAllStudents method
                List<Student> students = dataAccess.GetAllStudent();

                // Display the students
                foreach (Student student in students)
                {
                    Console.WriteLine("ID: {0}", student.Id);
                    Console.WriteLine("Name: {0}", student.Name);
                    Console.WriteLine("Age: {0}", student.Age);
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
            else if (choice == 2)
            {
                // View Student By Id
                Console.Clear();
                Console.WriteLine("Get Student");
                Console.WriteLine("---------------");
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());

                var student = dataAccess.GetStudentById(id);

                if (student.Id != 0)
                {
                    Console.WriteLine("ID: {0}", student.Id);
                    Console.WriteLine("Name: {0}", student.Name);
                    Console.WriteLine("Age: {0}", student.Age);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Student Not Found!!");
                }

                Console.ReadKey();
            }
            else if (choice == 3)
            {
                // Insert student
                Console.Clear();
                Console.WriteLine("Create Student");
                Console.WriteLine("---------------");
                Console.Write("Name:");
                string nama = Console.ReadLine();
                Console.Write("Age:");
                int age = int.Parse(Console.ReadLine());

                var student = new Student()
                {
                    Name = nama,
                    Age = age
                };

                dataAccess.InsertStudent(student);

                Console.ReadKey();
            }
            else if (choice == 4)
            {
                // Update students
                Console.Clear();
                Console.WriteLine("Update Student");
                Console.WriteLine("---------------");
                Console.Write("Search By Id:");
                int id = int.Parse(Console.ReadLine());

                var student = dataAccess.GetStudentById(id);

                if (student.Id != 0)
                {
                    Console.Write("Name : ");
                    string nama = Console.ReadLine();
                    Console.Write("Age : ");
                    int age = int.Parse(Console.ReadLine());

                    student.Name = nama;
                    student.Age = age;

                    dataAccess.UpdateStudent(student);
                }
                else
                {
                    Console.WriteLine("Student Not Found!!");
                }

                Console.ReadKey();
            }
            else if (choice == 5)
            {
                // Delete students
                Console.Clear();
                Console.WriteLine("Delete Student");
                Console.WriteLine("---------------");
                Console.Write("Search By Id:");
                int id = int.Parse(Console.ReadLine());

                var student = dataAccess.GetStudentById(id);

                if (student.Id != 0)
                {
                    dataAccess.DeleteStudent(student.Id);
                }
                else
                {
                    Console.WriteLine("Student Not Found!!");
                }

                Console.ReadKey();
            }
            else if (choice == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
        }
    }
}