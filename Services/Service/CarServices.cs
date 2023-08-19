using Domain.DTOs;
using Infrastructure.Infrastructure;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class CarServices : ICarsService
    {
        private ICarRepository _repo;

        public CarServices(ICarRepository repo)
        {
            _repo = repo;
        }

        public int AddCar(Car car)
        {
            try
            {
                var result = _repo.AddCar(car);
                return result;
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }

        }
    }
}
