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

    //public override string ToString()
    //{
    //    return $"{Id} \t {Name} \t {TrainerName}";
    //}
}

public class UserDb : IDisposable
{
    private static UserDb? _instance = null;

    private SQLiteConnection _db;
    private bool _disposed;


    private UserDb() 
    {
        var flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create;
        var filePath = "Users.db";

        _db = new SQLiteConnection(filePath, flags);
        _db.CreateTable<User>();
    }

    public static UserDb Instance => _instance ??= new UserDb();


    public IEnumerable<User> Users => _db!.Table<User>();

    public void Add(User user) => _db!.InsertOrReplace(user);

    public void Remove(string login) => _db!.Delete<User>(login);



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
            _db?.Dispose();

        _disposed = true;
    }
    ~UserDb()
    {
        Dispose(disposing: false);
    }
}
