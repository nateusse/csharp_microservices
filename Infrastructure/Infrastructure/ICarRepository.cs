using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Infrastructure
{
    public interface ICarRepository
    {
        public int AddCar(Car car);
    }
}
