using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class ChangeUsersModel
{
    private UserDb _userDb;

    public ChangeUsersModel()
    {
        _userDb = UserDb.Instance;
    }


    public IEnumerable<string> Logins => _userDb.Logins;


    public string GetName(string login) => _userDb.GetName(login);

    public UserRole GetRole(string login) => _userDb.GetRole(login);

    public int GetDiscount(string login) => _userDb.GetDiscount(login);


    public void UpdateUser(string login, string newName, UserRole newRole, int newDiscount)
    {
        _userDb.UpdateName(login, newName);
        _userDb.UpdateRole(login, newRole);
        _userDb.UpdateDiscount(login, newDiscount);
    }
}
