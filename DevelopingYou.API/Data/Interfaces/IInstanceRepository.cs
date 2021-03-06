﻿using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevelopingYou.API.Data.Interfaces
{
    public interface IInstanceRepository
    {

        //Read
        Task<InstanceDTO> GetInstanceById(int id);
        Task<IEnumerable<InstanceDTO>> GetInstances();

        //Update
        Task<bool> UpdateInstance(int id, DateTime startTime, CreateInstance instanceData);
        Task<InstanceDTO> SaveNewInstance(int id, CreateInstance instanceData);

        //Delete
        Task<InstanceDTO> DeleteInstance(int id);

    }
}
