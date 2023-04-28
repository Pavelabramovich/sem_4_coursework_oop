using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class AuthorizationModel
{
    private UserDb _db;

    public AuthorizationModel(UserDb db)
    {
        _db = db;
    }

    public bool Contains(string login)
    {
        return _db.Contains(login);
    }

    public string GetName(string login)
    {
        return _db.GetName(login);
    }

    public bool ValidatePassword(string login, IEnumerable<char> password)
    {
        return _db.ValidatePassword(login, password);
    }
}
