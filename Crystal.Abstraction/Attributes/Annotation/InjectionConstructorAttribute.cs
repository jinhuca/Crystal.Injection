﻿using System;

namespace Crystal
{
    /// <summary>
    /// This attribute is used to indicate which constructor to choose when
    /// the container attempts to build a type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Constructor)]
    public sealed class InjectionConstructorAttribute : Attribute
    {
    }
}
