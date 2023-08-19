using Domain.DTOs;
using Infrastructure.Data;
using Infrastructure.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Reposotories
{
    public class CarRepository : ICarRepository
    {
        AutomovilesContext _context;
        public CarRepository(AutomovilesContext context)
        {
            _context = context;
        }
        public int AddCar(Car car)
        {
            Automobile automobile = new Automobile()
            {
                Id = car.Id,
                Nombre = car.CarName
            };
            try
            {
                _context.Automobiles.Add(automobile);
                return 1;
            }
            catch(Exception ex) {
                return -1;
            }            
        }
    }
}
