﻿using Proiect.DAL.Entities;
using Proiect.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Interfaces
{
    public interface IDonorRepository 
    {
        
        Task<List<Donor>> GetAll();
        Task<DonorModel> GetById(int id);
        Task Create(Donor student);
        Task Update(Donor student);

        Task Delete(Donor student);
        Task<List<Donor>> WhereCount(int count);

        Task<List<Donor>> OrderByName();

        Task<IQueryable<Donor>> GetAllQuery();


    }
}
