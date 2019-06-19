using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface IRecipeClient
    {
        JObject GetRecipeById(string id);
    }
}
