using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public class ProductModel : ObservableObject
{
    private string _name;
    
    private string _description;

    private string _imagePath;

    private ProductType _type;

    private int _price;


    public ProductModel(string name, string description, string imagePath, ProductType type, int price)
    {
        _name = name;
        _description = description;

        _imagePath = imagePath;
        _type = type;
        _price = price;
    }

    public string Name => _name;

    public string Description
    {
        get => _description;
        set
        {
            if (value == _description)
                return;

            _description = value;
            OnPropertyChanged();
        }
    }

    public string ImagePath
    {
        get => _imagePath;
        set
        {
            if (value == _imagePath)
                return;

            _imagePath = value;
            OnPropertyChanged();
        }
    }

    public ProductType Type
    {
        get => _type;
        set
        {
            if (value == _type)
                return;

            _type = value;
            OnPropertyChanged();
        }
    }

    public int Price
    {
        get => _price;
        set
        {
            if (_price != value)
            {
                _price = value;
                OnPropertyChanged();
            }
        }
    }
}

public class TypeModel : ObservableObject
{
    private ProductType _name;

    private int _discount;

    public TypeModel(ProductType name, int discount)
    {
        _name = name;
        _discount = discount;
    }

    public ProductType Name => _name;

    public int Discount
    {
        get => _discount;
        set
        {
            if (_discount != value)
            {
                _discount = value;
                OnPropertyChanged();
            }
        }
    }

}


public class AdminProductsChangingViewModel : SwitchebleViewModel
{
    private AdminProductsChangingModel _model;

    public ObservableCollection<ProductModel> Products { get; set; }

    public ObservableCollection<TypeModel> Types { get; set; }


    public AdminProductsChangingViewModel()
    {
        _model = new AdminProductsChangingModel();

        Products = new( _model.Products.Select(f => CreateProductModel(f)) );

        Types = new(_model.Types);
    }




    public ICommand SaveChangesCommand => new DelegateCommand(o =>
    {
        foreach (var product in Products)
        {
            _model.UpdateProduct(CreateProduct(product));
        }

        SwitchToPage<SpecialAbilitiesViewModel>();
    });

    public override ICommand BackCommand => CancelCommand;



    public ICommand CancelCommand => new DelegateCommand(o =>
    {
        SwitchToPage<SpecialAbilitiesViewModel>();
    });


    private ProductModel CreateProductModel(Product product)
    {
        return new ProductModel(product.Name, product.Description, product.ImagePath, product.Type, product.Price);
    }

    private Product CreateProduct(ProductModel model)
    {
        return new Product 
        { 
            Name =  model.Name, 
            Description = model.Description, 
            ImagePath = model.ImagePath, 
            Type = model.Type, 
            Discount = Types.FirstOrDefault(t => t.Name == model.Type)?.Discount ?? 0 , 
            Price = model.Price
        };
    }
}
