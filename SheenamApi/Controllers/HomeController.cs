//================================================
// Copyright(c) Colition of Good-Hearted Engineers
// Free To Use Comfort and Peace
//================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace SheenamApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello Mario, the princess is in another castle! ");
       
            
    }
}
