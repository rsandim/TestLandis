using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLandysModel.Interface;
using TesteLandysModel.Models;
using TesteLandysRepository.Context;

namespace TesteLandysRepository.Repository
{
    public class EndPointRepository : IEndPointRepository
    {
        public readonly TesteLanysContext _context;

        public EndPointRepository()
        {
            _context = new TesteLanysContext(new DbContextOptionsBuilder<TesteLanysContext>()
            .UseInMemoryDatabase("TesteLanysContext")
            .Options);
        }

        public async Task AddEnPoint(EndPoint endPoint)
        {
            await _context.EndPoints.AddAsync(endPoint);
            await SaveChanges();
        }

        public async Task UpdateEndPoint(EndPoint endPointExist)
        {
            _context.EndPoints.Update(endPointExist);
            await SaveChanges();
        }

        public async Task DeleteEndPoint(EndPoint endPoint)
        {
            _context.EndPoints.Remove(endPoint);
            await SaveChanges();
        }

        public Task<EndPoint> GetBySerialNumber(string serialNumber)
        {
            return _context.EndPoints.Where(e => e.SerialNumber ==
            serialNumber).FirstOrDefaultAsync();
        }

        public Task<List<EndPoint>> GetAllEndPoints()
        {
            return _context.EndPoints.ToListAsync();
        }

        private async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
