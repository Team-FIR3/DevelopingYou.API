﻿using DevelopingYou.API.Data.Interfaces;
using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;
using Microsoft.EntityFrameworkCore;
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



        public async Task<InstanceDTO> GetInstanceById(int id)
        {
            var instance = await _context.Instance
                .Select(instance => new InstanceDTO
                {
                    Id = instance.Id,
                    GoalTitle = instance.Goal.Title,
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

        public async Task<InstanceDTO> SaveNewInstance(int id, CreateInstance instanceData)
        {
            var instance = new Instance
            {
                GoalId = id,
                StartTime = instanceData.StartTime,
                EndTime = instanceData.EndTime,
                Comment = instanceData.Comment,
            };

            _context.Instance.Add(instance);
            await _context.SaveChangesAsync();
            var newInstance = await GetInstanceById(instance.Id);
            return newInstance;
        }

        public async Task<bool> UpdateInstance(int id, DateTime startTime, CreateInstance instanceData)
        {
            var instance = await _context.Instance
                .FirstOrDefaultAsync(instance => instance.Id == id && instance.StartTime == instanceData.StartTime);

            if (instance is null) return false;
            instance.StartTime = instanceData.StartTime;
            instance.EndTime = instanceData.EndTime;
            instance.Comment = instanceData.Comment;

            _context.Entry(instance).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return true;

        }
        public async Task<InstanceDTO> DeleteInstance(int id)
        {
            var instance = await _context.Instance.FirstOrDefaultAsync(instance => instance.Id == id);
            if (instance == null)
            {
                return null;
            }
            var instanceToReturn = await GetInstanceById(id);
            _context.Instance.Remove(instance);
            await _context.SaveChangesAsync();
            return instanceToReturn;
        }


    }
}
