﻿using Core1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Personel:IEntity
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }

    }
}
