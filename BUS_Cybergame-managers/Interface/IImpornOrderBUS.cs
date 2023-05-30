﻿using DTO_Cybergame_managers;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface IImpornOrderBUS
    {
        int Update(decimal totalMoney);
        int Insert(ImportOrder x);
        ImportOrder GetImport();
        IList<ImportOrder> getAll();
    }
}
