using System.Collections.Generic;
using TravelAssist.Core.Business_Interface;
using TravelAssist.Core.Models;
using TravelAssist.Core.Repository_Interface;

namespace TravelAssist.Business.Business
{
    public class SpotBusiness : ISpotBusiness
    {
        private readonly ISpotRepository _spotRepository;

        public SpotBusiness(ISpotRepository spotRepository)
        {
            _spotRepository = spotRepository;
        }

        public void Add(Spot entity)
        {
            _spotRepository.Add(entity);
        }

        public void Update(Spot entity)
        {
            _spotRepository.Update(entity);
        }

        public void Delete(Spot entity)
        {
            _spotRepository.Delete(entity);
        }

        public ICollection<Spot> GetAll()
        {
            return _spotRepository.GetAll();
        }

        public Spot GetById(int id)
        {
            return _spotRepository.GetById(id);
        }
    }
}
