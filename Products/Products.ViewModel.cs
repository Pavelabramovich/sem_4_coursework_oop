﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class ProductsViewModel : SwitchebleViewModel
{
    private ProductsModel _model;

    private string? _login;

    private bool _isCreatingOrder;

    private Product? _currentProduct = null;

    private string _cardNumber = string.Empty;


    private ProductType _currentType;


    private int _count = 1;
   
    public ProductsViewModel(ProductType type)
    {
        _model = new ProductsModel();

        _login = null;

        CurrentProduct = null;

        _isCreatingOrder = false;

        _currentType = type;
    }
    public ProductsViewModel(string login, ProductType type)
    {
        _model = new ProductsModel();

        _login = login;

        CurrentProduct = null;

        _isCreatingOrder = false;

        _currentType = type;
    }


    public Product? CurrentProduct
    {
        get => _currentProduct;
        set
        {
            if (_currentProduct != value)
            {
                _currentProduct = value;
                OnPropertyChanged();

                IsCreatingOrder = false;
            }
        }
    }

    public bool IsCreatingOrder
    {
        get => _isCreatingOrder;
        set
        {
            if (_isCreatingOrder == value) 
                return;

            _isCreatingOrder = value;
            OnPropertyChanged();
        }
    }

    public bool IsAnonymous
    {
        get => _login is null;
    }

    public int Count
    {
        get => _count;
        set
        {
            if (value != _count)
            {
                _count = value;
                OnPropertyChanged();
            }
        }
    }

    public int Min => 1;
    public int Max => 100; 

    public string CardNumber
    {
        get => _cardNumber;
        set
        {
            if (_cardNumber != value)
            {
                _cardNumber = value;
                OnPropertyChanged();
            }
        }
    }

    public IEnumerable<Product> Products
    {
        get => _model.GetProductsByType(_currentType);
    }

    public ICommand BackCommand => new DelegateCommand(o =>
    {
        if (!IsCreatingOrder)
            SwitchToPage<UserViewModel>();
    });

    public ICommand OrderCreatingCommand => new DelegateCommand(o =>
    {
        if (IsAnonymous)
            return;

        IsCreatingOrder = true;
    });

    public ICommand CancelCommand => new DelegateCommand(o =>
    {
        Count = 1;
        IsCreatingOrder = false;
    });

    public ICommand OrderApprovalCommand => new DelegateCommand(o =>
    {
        if (_login is null)
            return;

        if (CurrentProduct is null)
            throw null;

        _model.AddOrder(_login, CurrentProduct.Name, Count, CardNumber);

        Count = 1;
        IsCreatingOrder = false;
    });
}