﻿using System;

namespace iTypes.Interfaces;

public class Book : IDocument
{
    public string ISBN { get; set; }

    public string Name { get; set; }

    public string GetString()
    {
        return $"{this.GetType().Name} | {Name} | {ISBN}";
    }
}

