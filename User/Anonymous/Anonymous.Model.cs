using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class AnonymousModel : BaseUserModel
{
    private UserDb _db;

    public AnonymousModel()
    {
        _db = UserDb.Instance;
    }

    public new bool Contains(string login)
    {
        return _db.Contains(login);
    }

    public new string GetName(string login)
    {
        return _db.GetName(login);
    }

    public new bool ValidatePassword(string login, IEnumerable<char> password)
    {
        return _db.ValidatePassword(login, password);
    }
}
