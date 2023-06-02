﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class SpecialAbilitiesModel
{
    private UserDb _db;

    public SpecialAbilitiesModel()
    {
        _db = UserDb.Instance;
    }

    public UserRole GetUserRole(string login)
    {
        return _db.GetRole(login);
    }
}