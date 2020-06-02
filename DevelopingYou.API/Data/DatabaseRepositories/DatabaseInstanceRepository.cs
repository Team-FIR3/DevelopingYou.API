using DevelopingYou.API.Data.Interfaces;
using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopingYou.API.Data.DatabaseRepositories
{
    public class DatabaseInstanceRepository : IInstanceRepository
    {
        private readonly DiscoveringYouDBContext _context;

        public DatabaseInstanceRepository(DiscoveringYouDBContext context)
        {
            _context = context;
        }

        public async Task<Instance> CreateInstance(Instance instance)
        {
            _context.Instance.Add(instance);
            await _context.SaveChangesAsync();
            return instance;
        }

        public async Task<Instance> DeleteInstance(int id)
        {
            var instance = await _context.Instance.FindAsync(id);
            if ( instance == null)
            {
                return null;
            }
            _context.Instance.Remove(instance);
            await _context.SaveChangesAsync();
            return instance;
        }

        public Task<InstanceDTO> GetInstanceById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<InstanceDTO>> GetInstances()
        {
            throw new NotImplementedException();
        }

        public Task<InstanceDTO> SaveNewInstance(Instance instance)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateInstance(int id, Instance instance)
        {
            throw new NotImplementedException();
        }
    }
}
