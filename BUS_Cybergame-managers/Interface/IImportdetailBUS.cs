﻿using DAL_Cybergame_managers;
using DAL_Cybergame_managers.interfaces;
using DocumentFormat.OpenXml.Bibliography;
using DTO_Cybergame_managers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface IImportdetailBUS
    {
        
        int Insert(ImportDetail dt);
        void KetXuatWord(int MaNV,int makh, string templatePath, string exportPath);
        IList<ImportDetail> getAll();
        
    }
}