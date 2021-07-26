using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class LiveZoomService : ILiveZoomService
    {
        private readonly UnitOfWork _uow;
        public LiveZoomService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }
        public int GetCount()
        {
            return _uow.LiveZoomRepo.Count();
        }

        public LiveZoom Get(int id)
        {
            var liveZoom = _uow.LiveZoomRepo.Get(id);
            if (liveZoom == null)
                throw new Exception();
            return liveZoom;
        }

        public IEnumerable<LiveZoom> GetAll()
        {
            return _uow.LiveZoomRepo.GetAll();
        }
        public async Task Add(LiveZoom liveZoom)
        {
            if (!ValidateLiveZoomDetails(liveZoom))
                throw new Exception();
            _uow.LiveZoomRepo.Add(liveZoom);
            await _uow.Save();
        }

        public async Task ChangeLiveStatus(LiveZoom liveZoom)
        {
            liveZoom.IsLive = liveZoom.IsLive ? false : true;
            _uow.LiveZoomRepo.Update(liveZoom);
            await _uow.Save();
        }

        private bool ValidateLiveZoomDetails(LiveZoom liveZoom)
        {
            if (liveZoom == null)
                return false;
            if (string.IsNullOrEmpty(liveZoom.Title) || string.IsNullOrWhiteSpace(liveZoom.Title))
                return false;
            if (string.IsNullOrEmpty(liveZoom.Link) || string.IsNullOrWhiteSpace(liveZoom.Link))
                return false;
            return true;
        }
    }
}
