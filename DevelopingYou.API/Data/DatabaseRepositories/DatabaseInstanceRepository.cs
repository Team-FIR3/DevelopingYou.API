using DevelopingYou.API.Data.Interfaces;
using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


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

        public async Task<InstanceDTO> GetInstanceById(int id)
        {
            var instance = await _context.Instance
                .Select(instance => new InstanceDTO
                {
                    Id = instance.Id,
                  
                    StartTime = instance.StartTime,
                    EndTime = instance.EndTime,
                    Comment = instance.Comment,

                })
                .FirstOrDefaultAsync(instance => instance.Id == id);
            return instance;
        }

        public async Task<IEnumerable<InstanceDTO>> GetInstances()
        {
            var instances = await _context.Instance
                .Select(instance => new InstanceDTO
                {
                    Id = instance.Id,
                    StartTime = instance.StartTime,
                    EndTime = instance.EndTime,
                    Comment = instance.Comment,

                })
                .ToListAsync();
            return instances;
        }

        public async Task<Instance> SaveNewInstance(Instance instance)
        {
            _context.Instance.Add(instance);
            await _context.SaveChangesAsync();
            return instance;
        }

        public async Task<bool> UpdateInstance(int id, Instance instance)
        {
            _context.Entry(instance).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!InstanceExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        public bool InstanceExists(int id)
        {
            return _context.Instance.Any(e => e.Id == id);
        }
    }
}
