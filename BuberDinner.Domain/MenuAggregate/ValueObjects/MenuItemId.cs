﻿using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects;

public class MenuItemId : ValueObject
{
    public Guid Value { get; set; }

    private MenuItemId(Guid value)
    {
        Value = value;
    }

    public static MenuItemId CreateUniqie()
    {
        return new(Guid.NewGuid());
    }    
    
    public override IEnumerable<object?> GetEqualityComponents()
    {
        yield return Value;
    }
}