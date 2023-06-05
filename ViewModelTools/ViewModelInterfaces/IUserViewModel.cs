using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseProjectOpp;

public interface IUserViewModel
{
    string Name { get; }

    string AvatarPath { get; }

    ICommand AuthorizationCommand { get; }

    ICommand ToOrdersCommand { get; }

    ICommand ToFlowersCommand { get; }
    ICommand ToCandlesCommand { get; }
    ICommand ToWreathsCommand { get; }
    ICommand ToCoffinsCommand { get; }
    ICommand ToFencesCommand { get; }
    ICommand ToTombstonesCommand { get; }

    ICommand ToSpecialAbilitiesCommand { get; }
} 
