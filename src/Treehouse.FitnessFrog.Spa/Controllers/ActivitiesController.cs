using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class ActivitiesController : ApiController
    {


        private ActivitiesRepository _activitiesRepository = null;

        public ActivitiesController(ActivitiesRepository activitiesRepository)
        {
            _activitiesRepository = activitiesRepository;

        }


        // Add a controller action method to handle GET requests
        //The method should return a collection of resources representing the available activities
        //Each returned activity resource should have an id and name property
        //Use the ActivitiesRepository.GetList method to get a list of the available activities


        public IHttpActionResult Get()
        {
            return Ok(_activitiesRepository.GetList());
        }






    }
}