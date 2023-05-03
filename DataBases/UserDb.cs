using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using SQLite;

namespace CourseProjectOpp;

[Table("Users")]
public class User
{
    [PrimaryKey, Indexed]
    [Column("Login")]
    public string Login { get; set; } 
    [Column("Password")]
    public string Password { get; set; }

    [Column("Name")]
    public string Name { get; set; }
}

public class UserDb : IDisposable
{
    private static UserDb? _instance = null;

    private SQLiteConnection _conn;
    private bool _disposed;


    private UserDb() 
    {
        var flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create;
        var filePath = "Users.db";

        _conn = new SQLiteConnection(filePath, flags);
        _conn.CreateTable<User>();
    }

    public static UserDb Instance => _instance ??= new UserDb();


    public void Add(User user) => _conn!.InsertOrReplace(user);
    public void Remove(string login) => _conn!.Delete<User>(login);

    public bool Contains(string login) => GetName(login) is not null;


    public IEnumerable<char> GetPassword(string login)
    {
        for (int i = 1; ; i++)
        {
            string s = _conn.ExecuteScalar<string>($"SELECT substr(Password,{i},1) FROM Users WHERE Login = '{login}'");

            if (string.IsNullOrEmpty(s))
            {
                yield break;
            }
            else
            {
                yield return Convert.ToChar(s);
            }
        }
    }
    public bool ValidatePassword(string login, IEnumerable<char> password)
    {
        var dbPassword = GetPassword(login);

        return password.SequenceEqual(dbPassword);
    }

    public string GetName(string login) => _conn.ExecuteScalar<string>($"SELECT Name FROM Users WHERE Login = '{login}'");


    public void Dispose()
    {
        Dispose(disposing: true);

        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;

        if (disposing)
            _conn?.Dispose();

        _disposed = true;
    }
    ~UserDb()
    {
        Dispose(disposing: false);
    }
}
