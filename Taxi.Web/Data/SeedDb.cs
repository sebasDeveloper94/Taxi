using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taxi.Web.Data.Entities;

namespace Taxi.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;

        public SeedDb(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckTaxisAsync();
        }

        private async Task CheckTaxisAsync()
        {
            if (_dataContext.Taxis.Any())
            {
                return;
            }

            _dataContext.Taxis.Add(new TaxiEntity()
            {
                Plaque = "AAER45",
                Trips = new List<TripEntity>
                {
                    new TripEntity
                    {
                        StartDate = DateTime.UtcNow,
                        EndDate = DateTime.UtcNow.AddMinutes(30),
                        Qualification = 4.5f,
                        Source = "ITM Fraternidad",
                        Target = "ITM Robledo",
                        Remarks = "Buen servicio"
                    },
                    new TripEntity
                    {
                        StartDate = DateTime.UtcNow,
                        EndDate = DateTime.UtcNow.AddMinutes(30),
                        Qualification = 4.2f,
                        Source = "ITM direccion",
                        Target = "ITM llego",
                        Remarks = "Mas o menos servicio"
                    }
                }
            });
            _dataContext.Taxis.Add(new TaxiEntity()
            {
                Plaque = "TQEP99",
                Trips = new List<TripEntity>
                {
                    new TripEntity
                    {
                        StartDate = DateTime.UtcNow,
                        EndDate = DateTime.UtcNow.AddMinutes(30),
                        Qualification = 4.5f,
                        Source = "ITM Fraternidad",
                        Target = "ITM Robledo",
                        Remarks = "Buen servicio"
                    },
                    new TripEntity
                    {
                        StartDate = DateTime.UtcNow,
                        EndDate = DateTime.UtcNow.AddMinutes(30),
                        Qualification = 4.2f,
                        Source = "ITM direccion",
                        Target = "ITM llego",
                        Remarks = "Mas o menos servicio"
                    }
                }
            });
            await _dataContext.SaveChangesAsync();
        }
    }
}
