﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTypes.Interfaces;

public interface IDocument
{
    string Name { get; set; }

    string GetString();
}
