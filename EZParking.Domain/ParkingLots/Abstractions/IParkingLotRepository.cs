﻿using EZParking.Core.Models;
using EZParking.Domain.ParkingLots.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Domain.ParkingLots.Abstractions
{
    public interface IParkingLotRepository : IGenericRepository<ParkingLot>
    {
    }
}