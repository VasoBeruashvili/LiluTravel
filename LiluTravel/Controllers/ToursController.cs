using LiluTravel.DataLayer;
using LiluTravel.Utilities;
using LiluTravel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiluTravel.Controllers
{
    public class ToursController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TourDetails(int id)
        {
            ViewBag.tourId = id;
            return View();
        }

        public ActionResult SubTourDetails(int tourId, int subTourId)
        {
            ViewBag.tourId = tourId;
            ViewBag.subTourId = subTourId;
            return View();
        }



        #region Private Methods
        public JsonResult GetTours()
        {
            using (DataContext dc = new DataContext())
            {
                return Json(dc.Tours.Select(t => new TourViewModel
                {
                    Id = t.Id,
                    Name = t.Name
                }).ToList());
            }
        }

        public JsonResult GetDetailedTour(int id)
        {
            using (DataContext dc = new DataContext())
            {
                var tour = dc.Tours.Include("SubTours").Include("TourImages").Where(t => t.Id == id).FirstOrDefault();
                if (tour == null)
                    return null;
                else
                {
                    var detailedTour = new TourViewModel
                    {
                        Id = tour.Id,
                        Name = tour.Name,
                        Description = tour.Description,
                        Images = tour.TourImages.Select(ti => new ImageViewModel
                        {
                            Image = ti.Image
                        }).ToList(),
                        SubTours = tour.SubTours.Select(st => new SubTourViewModel
                        {
                            Id = st.Id,
                            Name = st.Name
                        }).ToList()
                    };
                    
                    if(detailedTour.Images.Count > 0)
                        detailedTour.Images[0].Active = "active";

                    return Json(detailedTour);
                }
            }
        }

        public JsonResult GetDetailedSubTour(int id)
        {
            using (DataContext dc = new DataContext())
            {
                var subTour = dc.SubTours.Include("SubTourImages").Where(st => st.Id == id).FirstOrDefault();
                if (subTour == null)
                    return null;
                else
                {
                    var detailedSubTour = new SubTourViewModel
                    {
                        Id = subTour.Id,
                        Name = subTour.Name,
                        Description = subTour.Description,
                        Price = subTour.Price,
                        TourId = subTour.TourId,
                        Images = subTour.SubTourImages.Select(sti => new ImageViewModel
                        {
                            Image = sti.Image
                        }).ToList()
                    };

                    if (detailedSubTour.Images.Count > 0)
                        detailedSubTour.Images[0].Active = "active";

                    return Json(detailedSubTour);
                }
            }
        }

        public JsonResult GetSubTours(int id)
        {
            using (DataContext dc = new DataContext())
            {
                return Json(dc.SubTours.Where(st => st.TourId == id).Select(st => new SubTourViewModel
                {
                    Id = st.Id,
                    Name = st.Name
                }).ToList());
            }
        }
        #endregion
    }
}