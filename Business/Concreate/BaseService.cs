using AutoMapper;
using Business.Abstract;
using Business.Config;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class BaseService<TDto,TEntity> : IBaseService<TDto, TEntity> where TEntity : BaseEntity
    {
        MapperConfiguration _mapperConfiguration;
        public IMapper _mapper;
        public AppDbContext _dbContext;
        public DbSet<TEntity> _dbSet;

        public BaseService()
        {
            _dbContext = new AppDbContext();
            _dbSet = _dbContext.Set<TEntity>();
            _mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<MapperProfile>());
            _mapper = _mapperConfiguration.CreateMapper();
        }
        public IEnumerable<TDto> GetAll()
        {
            var res = _dbSet.ToList();
            var mappedRes =  _mapper.Map<IEnumerable<TDto>>(res);
            return mappedRes;
        }

        public TDto Get(int id)
        {
            var ent = _dbSet.Find(id);
            var res = _mapper.Map<TDto>(ent);
            return res;
        }

        public void Create(TDto dto)
        {
            var ent = _mapper.Map<TEntity>(dto);
            _dbSet.Add(ent);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            //var ent = _dbSet.Find(id);
            //_dbSet.Remove(ent);
            //_dbContext.SaveChanges();
        }

        public void Update(int id , TDto dto)
        {
            var entById = _dbSet.Find(id);
            var ent = _mapper.Map<TEntity>(dto);
            entById = ent;
            _dbContext.SaveChanges();
        }
    }
}
