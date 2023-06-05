using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class AdminAbilitiesModel
{
    private UserDb _db;

    public AdminAbilitiesModel()
    {
        _db = UserDb.Instance;
    }

    public UserRole GetUserRole(string login)
    {
        return _db.GetRole(login);
    }

    public int GetDiscount(string login)
    {
        return _db.GetDiscount(login);
    }

    public string GetAvatarPath(string login)
    {
        return _db.GetAvatar(login);
    }

    public string GetName(string login)
    {
        return _db.GetName(login);
    }

    public void UpdeateName(string login, string newName)
    {
        _db.UpdateName(login, newName);
    }
}
