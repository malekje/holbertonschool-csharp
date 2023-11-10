﻿using System;

/// Abstract Base class
public abstract class Base
{
    public string name;

    public override string ToString()
    {
        return (name + " is a " + this.GetType());
    }

}
