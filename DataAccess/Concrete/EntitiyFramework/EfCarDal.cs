﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entitiy)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entitiy);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entitiy)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entitiy);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entitiy)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedEntity = context.Entry(entitiy);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
