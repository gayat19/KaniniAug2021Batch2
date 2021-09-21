﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateMVCApplication.Services
{
    public interface IRepo<K>
    {
        K Add(K k);
        ICollection<K> GetAll();
        K Get(int id);
        K Update(K k);
        K Delete(int id);
    }
}
