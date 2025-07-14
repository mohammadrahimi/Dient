

using Dient.Domain.common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diet.Domain.food;

public class FoodGroup : BaseEntity
{
    public string Title { get; set; }

    private FoodGroup(){}
}
public class FoodStupp : BaseEntity
{
    public string Title { get; set; }

    private FoodStupp() { }
}
