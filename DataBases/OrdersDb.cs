using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

[Table("Orders")]
public class Order
{
    [PrimaryKey, Indexed, AutoIncrement]
    [Column("Id")]
    public int Id { get; set; }

    [Column("CustomerLogin")]
    public string CustomerLogin { get; set; }

    [Column("ProductName")]
    public string ProductName { get; set; }

    [Column("Count")]
    public int Count { get; set; }

    [Column("CardNumber")]
    public string CardNumber { get; set; }
}


public class OrdersDb
{
    private SQLiteConnection _conn;
    private bool _disposed;

    public static OrdersDb Instance { get; } = new OrdersDb();

    private OrdersDb()
    {
        var flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create;
        var filePath = "Orders.db";

        _conn = new SQLiteConnection(filePath, flags);
        _conn.CreateTable<Order>();
    }

    
    public void Add(Order order) => _conn!.Insert(order);
    public void Remove(int id) => _conn!.Delete<Order>(id);

    public bool Contains(int id) => Orders.Count(x => x.Id == id) != 0;

    public IEnumerable<Order> Orders => _conn!.Table<Order>();

    public IEnumerable<Order> GetOrdersByLogin(string login)
    {
        return Orders.Where(o => o.CustomerLogin == login);
    }
     
    public IEnumerable<Order> GetOrsersByProductName(string name) 
    {
        return Orders.Where(o => o.ProductName == name);
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
    ~OrdersDb()
    {
        Dispose(disposing: false);
    }
}
