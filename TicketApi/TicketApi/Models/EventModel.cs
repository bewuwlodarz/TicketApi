using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApi.Models
{
    public class EventModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Required."), StringLength(50, ErrorMessage = "Title cannot be longer than 50 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string City { get; set; }



        public static List<SelectListItem> Category = new List<SelectListItem>
        {
            new SelectListItem("Music", "1"),
            new SelectListItem("Theater", "2"),
            new SelectListItem("Dance", "3"),
            new SelectListItem("Exhibition", "4"),
            new SelectListItem("Sport", "5"),
            new SelectListItem("Comedy", "6"),
            new SelectListItem("Other", "7"),



        };

        public static List<SelectListItem> Types = new List<SelectListItem>
        {
            new SelectListItem("Adults", "1"),
            new SelectListItem("Kids", "2"),
            new SelectListItem("Open","3")

        };
        [Required(ErrorMessage = "Required.")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Categories { get; set; }
        [Required(ErrorMessage = "Required."), StringLength(1000, ErrorMessage = "Title cannot be longer than 50 characters.")]
        public string Description { get; set; }

       

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedDate { get; set; }
        [Required(ErrorMessage = "Required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EventDate { get; set; }
        public string _UserID { get; set; }
        public bool SeatReservation { get; set; }
        public int Price { get; set; }

        public string Photo { get; set; }

    }
}
