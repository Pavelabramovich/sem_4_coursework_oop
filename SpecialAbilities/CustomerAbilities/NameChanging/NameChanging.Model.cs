using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class NameChangingModel
{
    private UserDb _userDb;


    public NameChangingModel() 
    {
        _userDb = UserDb.Instance;
    }

    public void SetName(string login, string newName)
    {
        _userDb.UpdateName(login, newName);
    }
}
