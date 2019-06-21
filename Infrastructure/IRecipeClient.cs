using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Infrastructure
{
    public interface IRecipeClient
    {
        Recipe GetRecipeById(string id);
    }
}
