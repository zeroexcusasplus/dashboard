using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class ViewLiveZoomModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public bool IsLive { get; set; }
        public DateTime DateCreated { get; set; }
        public ViewLiveZoomModel(LiveZoom liveZoom)
        {
            Id = liveZoom.Id;
            Title = liveZoom.Title;
            Link = liveZoom.Link;
            IsLive = liveZoom.IsLive;
            DateCreated = liveZoom.DateCreated;
        }
    }

    public class AddLiveZoomModel
    {
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Se requiere título")]
        [RegularExpression("^[a-zA-Z0-9].*$", ErrorMessage = "El título debe comenzar con alphabeth o número")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Se requiere enlace")]
        public string Link { get; set; }
        public LiveZoom Add()
        {
            return new LiveZoom
            {
                Title = Title,
                Link = Link,
            };
        }
    }
}
