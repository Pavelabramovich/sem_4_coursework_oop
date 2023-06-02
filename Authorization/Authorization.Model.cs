using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class AuthorizationModel
{
    private UserDb _db;

    public AuthorizationModel()
    {
        _db = UserDb.Instance;
    }

    public bool Contains(string login)
    {
        return _db.Contains(login);
    }

    public bool ValidatePassword(string login, IEnumerable<char> password)
    {
        return _db.ValidatePassword(login, password);
    }
}
