using BlazorLearnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLearnApp.Services
{
    public interface IMyService
    {
        int Count();

        Restaurant[] GetRestaurants();
    }
}
