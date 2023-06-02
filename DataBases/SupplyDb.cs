using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

[Table("Supplies")]
public class Supply
{
    [PrimaryKey, Indexed, AutoIncrement]
    [Column("Id")]
    public int Id { get; set; }

    [Column("ProductName")]
    public string ProductName { get; set; }

    [Column("ProviderLogin")]
    public string ProviderLogin { get; set; }
}


public class SupplyDb : IDisposable
{
    private SQLiteConnection _conn;
    private bool _disposed;


    private SupplyDb()
    {
        var flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create;
        var filePath = "Supply.db";

        _conn = new SQLiteConnection(filePath, flags);
        _conn.CreateTable<Supply>();
    }

    public static SupplyDb Instance { get; } = new SupplyDb();


    public void Add(Supply suply) => _conn.Insert(suply);
    public void Remove(int id) => _conn.Delete<Supply>(id);

   
    public IEnumerable<Supply> Supplies => _conn.Table<Supply>();


    public IEnumerable<string> ProductsNames => Supplies.Select(s => s.ProductName);
    public IEnumerable<string> ProvidersLogins => Supplies.Select(s => s.ProviderLogin);

    public IEnumerable<string> ProductsNamesByProviderLogin(string login)
    {
        return Supplies.Where(s => s.ProviderLogin == login).Select(s => s.ProductName);
    }
    public IEnumerable<string> ProvidersLoginsByProductName(string productName)
    {
        return Supplies.Where(s => s.ProductName == productName).Select(s => s.ProviderLogin);
    }

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
    ~SupplyDb()
    {
        Dispose(disposing: false);
    }
}
