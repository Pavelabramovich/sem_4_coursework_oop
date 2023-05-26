using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using SQLite;

namespace CourseProjectOpp;

[Table("Flowers")]
public class Flower
{
    [PrimaryKey, Indexed]
    [Column("Name")]
    public string Name { get; set; }

    [Column("Price")]
    public string Price { get; set; }

    [Column("Description")]
    public string Description { get; set; }

    [Column("ImagePath")]
    public string ImagePath { get; set; }
}

public class FlowersDb : IDisposable
{
    private SQLiteConnection _conn;
    private bool _disposed;


    private FlowersDb()
    {
        var flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create;
        var filePath = "Flowers.db";

        _conn = new SQLiteConnection(filePath, flags);
        _conn.CreateTable<Flower>();
    }

    public static FlowersDb Instance { get; } = new FlowersDb();


    public void Add(Flower flower) => _conn!.Insert(flower);
    public void Remove(string name) => _conn!.Delete<User>(name);

    public bool Contains(string name) => Flowers.Count(x => x.Name == name) != 0;

    public IEnumerable<Flower> Flowers => _conn!.Table<Flower>();
    

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
    ~FlowersDb()
    {
        Dispose(disposing: false);
    }
}
