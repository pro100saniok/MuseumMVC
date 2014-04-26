using System.Web.Mvc;
using Museum.Data.Repositories.Interfaces;

namespace Museum.Web.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IImageRepository _imageRepository;

        public GalleryController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        //
        // GET: /Gallery/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}