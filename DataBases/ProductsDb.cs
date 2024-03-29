﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using SQLite;

namespace CourseProjectOpp;

[Flags]
public enum ProductType
{
    Flower     =  0b_000001,
    Candle     =  0b_000010,
    Wreath     =  0b_000100,
    Coffin     =  0b_001000,
    Fence      =  0b_010000,
    Tombstone  =  0b_100000,
}


[Table("Products")]
public class Product
{
    [PrimaryKey, Indexed]
    [Column("Name")]
    public string Name { get; set; }

    [Column("Price")]
    public int Price { get; set; }

    [Column("Description")]
    public string Description { get; set; }

    [Column("ImagePath")]
    public string ImagePath { get; set; }

    [Column("Type")]
    public ProductType Type { get; set; }

    [Column("Discount")]
    public int Discount { get; set; }
}

public class ProductsDb : IDisposable
{
    private SQLiteConnection _conn;
    private bool _disposed;


    private ProductsDb()
    {
        var flags = SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create;
        var filePath = "Products.db";

        _conn = new SQLiteConnection(filePath, flags);
        _conn.CreateTable<Product>();
    }

    public static ProductsDb Instance { get; } = new ProductsDb();


    public void Add(Product product) => _conn!.Insert(product);
    public void Remove(string name) => _conn!.Delete<Product>(name);

    public void Update(Product product) => _conn!.InsertOrReplace(product);

    public bool Contains(string name) => Products.Count(x => x.Name == name) != 0;

    public Product? Get(string name) => Products.FirstOrDefault(f => f.Name == name);

    public IEnumerable<Product> Products => _conn!.Table<Product>();
    

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
    ~ProductsDb()
    {
        Dispose(disposing: false);
    }
}
