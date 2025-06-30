//using BezorgApp.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using BezorgApp.MVVM.Model;
//using System.Web.Mvc;
//using Microsoft.AspNetCore.Mvc;

//namespace BezorgApp.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class OrderController : ControllerBase
//    {
//        private readonly SQLite_Connection _connection;
//        public OrderController(SQLite_Connection connection)
//        {
//            _connection = connection;
//        }

//        [HttpGet]
//        public ActionResult<IEnumerable<Order>> Get()
//        {
//            return _connection.orders;
//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<Order?>> GetById(int id)
//        {
//            return await _connection.orders.Where(x => x.Id == id).SingleOrDefaultAsync();
//        }

//        [HttpPost]
//        public async Task<ActionResult> Create(Order order)
//        {
//            await _connection.orders.AddAsync(order);
//            await _connection.SaveChangesAsync();
//            return Ok();
//        }

//        [HttpDelete]
//        public async Task<ActionResult> Delete(int id)
//        {
//            var orderGetByIdResult = await GetById(id);
//            if (orderGetByIdResult.Value == null)
//                return NotFound();

//            _connection.Update(orderGetByIdResult.Value);
//            await _connection.SaveChangesAsync();
//            return Ok();
//        }
//    }
//}
