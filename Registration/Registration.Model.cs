using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class RegistrationModel
{
    private UserDb _userDb;

    public RegistrationModel()
    {
        _userDb = UserDb.Instance;
    }

    public bool Contains(string login)
    {
        return _userDb.Contains(login);
    }


    public bool ValidatePassword(string login, IEnumerable<char> password)
    {
        return _userDb.ValidatePassword(login, password);
    }

    public bool ContainsLogin(string login)
    {
        return _userDb.Logins.Contains(login);
    }

    public void AddUser(string login, IEnumerable<char> password, string name)
    {
        _userDb.Add(new User { Login = login, Password = new string(password.ToArray()), Name = name, Discount = 0, Role = UserRole.Customer });
    }
}
