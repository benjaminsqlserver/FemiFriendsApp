using Radzen;
using System;
using System.Web;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Data;
using System.Text.Encodings.Web;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using FemiFriendsApp.Data;

namespace FemiFriendsApp
{
    public partial class ConDataService
    {
        private readonly ConDataContext context;
        private readonly NavigationManager navigationManager;

        public ConDataService(ConDataContext context, NavigationManager navigationManager)
        {
            this.context = context;
            this.navigationManager = navigationManager;
        }

        public async Task ExportCountriesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/countries/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/countries/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportCountriesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/countries/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/countries/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnCountriesRead(ref IQueryable<Models.ConData.Country> items);

        public async Task<IQueryable<Models.ConData.Country>> GetCountries(Query query = null)
        {
            var items = context.Countries.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnCountriesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnCountryCreated(Models.ConData.Country item);

        public async Task<Models.ConData.Country> CreateCountry(Models.ConData.Country country)
        {
            OnCountryCreated(country);

            context.Countries.Add(country);
            context.SaveChanges();

            return country;
        }
        public async Task ExportGendersToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/genders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/genders/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportGendersToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/genders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/genders/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnGendersRead(ref IQueryable<Models.ConData.Gender> items);

        public async Task<IQueryable<Models.ConData.Gender>> GetGenders(Query query = null)
        {
            var items = context.Genders.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnGendersRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnGenderCreated(Models.ConData.Gender item);

        public async Task<Models.ConData.Gender> CreateGender(Models.ConData.Gender gender)
        {
            OnGenderCreated(gender);

            context.Genders.Add(gender);
            context.SaveChanges();

            return gender;
        }
        public async Task ExportMyFriendsToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/myfriends/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/myfriends/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportMyFriendsToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/myfriends/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/myfriends/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnMyFriendsRead(ref IQueryable<Models.ConData.MyFriend> items);

        public async Task<IQueryable<Models.ConData.MyFriend>> GetMyFriends(Query query = null)
        {
            var items = context.MyFriends.AsQueryable();

            items = items.Include(i => i.Gender);

            items = items.Include(i => i.Country);

            items = items.Include(i => i.State);

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnMyFriendsRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnMyFriendCreated(Models.ConData.MyFriend item);

        public async Task<Models.ConData.MyFriend> CreateMyFriend(Models.ConData.MyFriend myFriend)
        {
            OnMyFriendCreated(myFriend);

            context.MyFriends.Add(myFriend);
            context.SaveChanges();

            return myFriend;
        }
        public async Task ExportStatesToExcel(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/states/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/states/excel(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        public async Task ExportStatesToCSV(Query query = null, string fileName = null)
        {
            navigationManager.NavigateTo(query != null ? query.ToUrl($"export/condata/states/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')") : $"export/condata/states/csv(fileName='{(!string.IsNullOrEmpty(fileName) ? UrlEncoder.Default.Encode(fileName) : "Export")}')", true);
        }

        partial void OnStatesRead(ref IQueryable<Models.ConData.State> items);

        public async Task<IQueryable<Models.ConData.State>> GetStates(Query query = null)
        {
            var items = context.States.AsQueryable();

            if (query != null)
            {
                if (!string.IsNullOrEmpty(query.Filter))
                {
                    items = items.Where(query.Filter);
                }

                if (!string.IsNullOrEmpty(query.OrderBy))
                {
                    items = items.OrderBy(query.OrderBy);
                }

                if (!string.IsNullOrEmpty(query.Expand))
                {
                    var propertiesToExpand = query.Expand.Split(',');
                    foreach(var p in propertiesToExpand)
                    {
                        items = items.Include(p);
                    }
                }

                if (query.Skip.HasValue)
                {
                    items = items.Skip(query.Skip.Value);
                }

                if (query.Top.HasValue)
                {
                    items = items.Take(query.Top.Value);
                }
            }

            OnStatesRead(ref items);

            return await Task.FromResult(items);
        }

        partial void OnStateCreated(Models.ConData.State item);

        public async Task<Models.ConData.State> CreateState(Models.ConData.State state)
        {
            OnStateCreated(state);

            context.States.Add(state);
            context.SaveChanges();

            return state;
        }

        partial void OnCountryDeleted(Models.ConData.Country item);

        public async Task<Models.ConData.Country> DeleteCountry(int? countryId)
        {
            var item = context.Countries
                              .Where(i => i.CountryID == countryId)
                              .Include(i => i.MyFriends)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnCountryDeleted(item);

            context.Countries.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnCountryGet(Models.ConData.Country item);

        public async Task<Models.ConData.Country> GetCountryByCountryId(int? countryId)
        {
            var items = context.Countries
                              .AsNoTracking()
                              .Where(i => i.CountryID == countryId);

            var item = items.FirstOrDefault();

            OnCountryGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.ConData.Country> CancelCountryChanges(Models.ConData.Country item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnCountryUpdated(Models.ConData.Country item);

        public async Task<Models.ConData.Country> UpdateCountry(int? countryId, Models.ConData.Country country)
        {
            OnCountryUpdated(country);

            var item = context.Countries
                              .Where(i => i.CountryID == countryId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(country);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return country;
        }

        partial void OnGenderDeleted(Models.ConData.Gender item);

        public async Task<Models.ConData.Gender> DeleteGender(int? genderId)
        {
            var item = context.Genders
                              .Where(i => i.GenderID == genderId)
                              .Include(i => i.MyFriends)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnGenderDeleted(item);

            context.Genders.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnGenderGet(Models.ConData.Gender item);

        public async Task<Models.ConData.Gender> GetGenderByGenderId(int? genderId)
        {
            var items = context.Genders
                              .AsNoTracking()
                              .Where(i => i.GenderID == genderId);

            var item = items.FirstOrDefault();

            OnGenderGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.ConData.Gender> CancelGenderChanges(Models.ConData.Gender item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnGenderUpdated(Models.ConData.Gender item);

        public async Task<Models.ConData.Gender> UpdateGender(int? genderId, Models.ConData.Gender gender)
        {
            OnGenderUpdated(gender);

            var item = context.Genders
                              .Where(i => i.GenderID == genderId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(gender);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return gender;
        }

        partial void OnMyFriendDeleted(Models.ConData.MyFriend item);

        public async Task<Models.ConData.MyFriend> DeleteMyFriend(Int64? friendId)
        {
            var item = context.MyFriends
                              .Where(i => i.FriendID == friendId)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnMyFriendDeleted(item);

            context.MyFriends.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnMyFriendGet(Models.ConData.MyFriend item);

        public async Task<Models.ConData.MyFriend> GetMyFriendByFriendId(Int64? friendId)
        {
            var items = context.MyFriends
                              .AsNoTracking()
                              .Where(i => i.FriendID == friendId);

            items = items.Include(i => i.Gender);

            items = items.Include(i => i.Country);

            items = items.Include(i => i.State);

            var item = items.FirstOrDefault();

            OnMyFriendGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.ConData.MyFriend> CancelMyFriendChanges(Models.ConData.MyFriend item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnMyFriendUpdated(Models.ConData.MyFriend item);

        public async Task<Models.ConData.MyFriend> UpdateMyFriend(Int64? friendId, Models.ConData.MyFriend myFriend)
        {
            OnMyFriendUpdated(myFriend);

            var item = context.MyFriends
                              .Where(i => i.FriendID == friendId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(myFriend);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return myFriend;
        }

        partial void OnStateDeleted(Models.ConData.State item);

        public async Task<Models.ConData.State> DeleteState(int? stateId)
        {
            var item = context.States
                              .Where(i => i.StateID == stateId)
                              .Include(i => i.MyFriends)
                              .FirstOrDefault();

            if (item == null)
            {
               throw new Exception("Item no longer available");
            }

            OnStateDeleted(item);

            context.States.Remove(item);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                context.Entry(item).State = EntityState.Unchanged;
                throw ex;
            }

            return item;
        }

        partial void OnStateGet(Models.ConData.State item);

        public async Task<Models.ConData.State> GetStateByStateId(int? stateId)
        {
            var items = context.States
                              .AsNoTracking()
                              .Where(i => i.StateID == stateId);

            var item = items.FirstOrDefault();

            OnStateGet(item);

            return await Task.FromResult(item);
        }

        public async Task<Models.ConData.State> CancelStateChanges(Models.ConData.State item)
        {
            var entity = context.Entry(item);
            entity.CurrentValues.SetValues(entity.OriginalValues);
            entity.State = EntityState.Unchanged;

            return item;
        }

        partial void OnStateUpdated(Models.ConData.State item);

        public async Task<Models.ConData.State> UpdateState(int? stateId, Models.ConData.State state)
        {
            OnStateUpdated(state);

            var item = context.States
                              .Where(i => i.StateID == stateId)
                              .FirstOrDefault();
            if (item == null)
            {
               throw new Exception("Item no longer available");
            }
            var entry = context.Entry(item);
            entry.CurrentValues.SetValues(state);
            entry.State = EntityState.Modified;
            context.SaveChanges();

            return state;
        }
    }
}
