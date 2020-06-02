using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopingYou.API.Data.Interfaces
{
    public interface IInstanceRepository
    {
        //Create
        Task<Instance> CreateInstance(Instance instance);

        //Read
        Task<InstanceDTO> GetInstanceById(int id);
        Task<IEnumerable<InstanceDTO>> GetInstances();

        //Update
        Task<bool> UpdateInstance(int id, Instance instance);
        Task<Instance> SaveNewInstance(Instance instance);

        //Delete
        Task<Instance> DeleteInstance(int id);

    }
}
