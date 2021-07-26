using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface ILiveZoomService
    {
        int GetCount();
        IEnumerable<LiveZoom> GetAll();
        Task Add(LiveZoom liveZoom);
        Task ChangeLiveStatus(LiveZoom liveZoom);
        LiveZoom Get(int id);
    }
}
