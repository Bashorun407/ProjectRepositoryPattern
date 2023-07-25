using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Models.Enums
{
    public enum ProductCategories
    {
        [Description("Local Dishes")]
        LocalDishes = 1,
        [Description("Continental Dishes")]
        ContinentalDishes,
        Snacks

    }
}
