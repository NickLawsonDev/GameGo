using GameGo.Data;
using GameGo.Models;
using GameGo.Models.StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameGo.Service
{
    public class StoreService
    {
        private readonly Guid _userId;

        public StoreService(Guid userId)
        {
            _userId = userId;
        }

        public IEnumerable<StoreListItemViewModel> GetStores()
        {
            using (var ctx = new GameGoDbContext())
            {
                return
                    ctx
                        .Stores
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                             e =>
                                new StoreListItemViewModel
                                {
                                    StoreId = e.StoreId,
                                    Name = e.Name,
                                    Location = e.Location,
                                    PhoneNumber = e.PhoneNumber,
                                    Website = e.Website
                                })
                        .ToArray();
            }
        }

        public bool CreateStore(StoreCreateViewModel vm)
        {
            using (var ctx = new GameGoDbContext())
            {

                var entity =
                    new Store
                    {
                        OwnerId = _userId,
                        Name = vm.Name,
                        Location = vm.Location,
                        Website = vm.Website,
                        PhoneNumber = vm.PhoneNumber,
                        CreatedUtc = DateTimeOffset.UtcNow
                    };

                ctx.Stores.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public StoreDetailViewModel GetStoreById(int StoreId)
        {
            Store entity;

            using (var ctx = new GameGoDbContext())
            {
                entity =
                    ctx
                        .Stores
                            .SingleOrDefault(e => e.OwnerId == _userId && e.StoreId == StoreId);
            }

            return
                new StoreDetailViewModel
                {
                    StoreId = entity.StoreId,
                    Name = entity.Name,
                    Location = entity.Location,
                    PhoneNumber = entity.PhoneNumber,
                    Website = entity.Website,
                    CreatedUtc = entity.CreatedUtc
                };
        }

        public bool UpdateStore(StoreDetailViewModel vm)
        {
            using (var ctx = new GameGoDbContext())
            {
                var entity =
                    ctx
                        .Stores
                            .SingleOrDefault(e => e.OwnerId == _userId && e.StoreId == vm.StoreId);

                entity.Name = vm.Name;
                entity.Location = vm.Location;
                entity.Website = vm.Website;
                entity.PhoneNumber = vm.PhoneNumber;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteStore(int StoreId)
        {
            using (var ctx = new GameGoDbContext())
            {
                var entity =
                    ctx
                        .Stores
                            .SingleOrDefault(e => e.OwnerId == _userId && e.StoreId == StoreId);

                ctx.Stores.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
