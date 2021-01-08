using System.Collections.Generic;
using TravelAssist.Core.Business_Interface;
using TravelAssist.Core.Models;
using TravelAssist.Core.UnitOfWork_Inferface;

namespace TravelAssist.Business.Business
{
    public class SpotBusiness : ISpotBusiness
    {
        private readonly IUnitOfWork _unitOfWork;

        public SpotBusiness(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Spot entity)
        {
            _unitOfWork.SpotRepository.Add(entity);
            _unitOfWork.SaveAllAsync();
        }

        public void Update(Spot entity)
        {
            _unitOfWork.SpotRepository.Update(entity);
            _unitOfWork.SaveAllAsync();
        }

        public void Delete(Spot entity)
        {
            _unitOfWork.SpotRepository.Delete(entity);
        }

        public ICollection<Spot> GetAll()
        {
            return _unitOfWork.SpotRepository.GetAll();
        }

        public Spot GetById(int id)
        {
            return _unitOfWork.SpotRepository.GetById(id);
        }
    }
}
