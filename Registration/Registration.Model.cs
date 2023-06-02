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
}
