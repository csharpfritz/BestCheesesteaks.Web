using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BestCheesesteaks.Web.Models;

namespace BestCheesesteaks.Web.Controllers
{

  [Route("api/Shops")]
  public class ShopApiController : ApiController
  {
    private ShopContext _ctx;

    public ShopApiController()
    {
      _ctx = new Models.ShopContext();
    }

    // GET: api/ShopApi
    public IEnumerable<Shop> Get()
    {
      return _ctx.Shops;
    }

    //// GET: api/ShopApi/5
    //public string Get(int id)
    //{
    //  return "value";
    //}

    //// POST: api/ShopApi
    //public void Post([FromBody]string value)
    //{
    //}

    //// PUT: api/ShopApi/5
    //public void Put(int id, [FromBody]string value)
    //{
    //}

    //// DELETE: api/ShopApi/5
    //public void Delete(int id)
    //{
    //}
  }
}
