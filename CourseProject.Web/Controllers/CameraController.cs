using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseProject.Web.Controllers;
using CourseProject.DB;
using CourseProject.Web;
using CourseProject.DataAccess.Repository;
using CourseProject.DB.Entities;
using CourseProject.Web.Models;
using CourseProject.DataAccess;

namespace CourseProject.Web.Controllers
{
    public class CameraController : Controller
    {
 //       public CameraController() { }
            private readonly CourseProjectDbContext Context;
            private BaseRepository<Camera> repo;
            public CameraController(CourseProjectDbContext ctx)
            {
                Context = ctx;
                repo = new BaseRepository<Camera>(Context);
            }

            public ActionResult Index()
            {
                List<Camera> cameras = repo.GetAll();
                List<CamerasViewModel> model = new List<CamerasViewModel>();

                foreach (var c in cameras)
                {
                    CamerasViewModel camera = new CamerasViewModel(c);

                    model.Add(camera);
                }

                return View(model);
            }
        
    }
}