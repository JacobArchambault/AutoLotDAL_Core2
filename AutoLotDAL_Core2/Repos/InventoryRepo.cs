﻿using AutoLotDAL_Core2.EF;
using AutoLotDAL_Core2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.EF;

namespace AutoLotDAL_Core2.Repos
{
    public class InventoryRepo : BaseRepo<Inventory>, IInventoryRepo
    {
        public InventoryRepo(AutoLotContext context) : base(context)
        {
        }
        public override List<Inventory> GetAll() => GetAll(x => x.PetName, true).ToList();
        public List<Inventory> GetPinkCars() => GetSome(x => x.Color == "Pink");

        public List<Inventory> GetRelatedData()
        {
            throw new NotImplementedException();
        }

        public List<Inventory> Search(string searchString) => Context.Cars.Where(c => Functions.Like(c.PetName, $"%{searchString}%")).ToList();
    }
}
