using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DataFetchAPI.Models;
using DataFetchAPI.Utils;
namespace DataFetchAPI.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/Values")]

        [HttpGet]
        [Route("api/GetPortalUsers")]
        public IHttpActionResult GetPortalUsers()
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.ECommerceUsers.ToList();
            return Json(users);
        }

        [HttpGet]
        [Route("api/GetPortalCustomers/{customerNo}")]
        public IHttpActionResult GetPortalCustomers(string customerNo)
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.Customers.Where(c=>c.No == customerNo).ToList();
            return Json(users);
        }

        [HttpGet]
        [Route("api/PortalUsersbyId/{custNo}")]
        public IHttpActionResult PortalUsersbyId(string custNo)
        {
            var odataCon = DBConfig.ODataObj();
            var users = odataCon.ECommerceUsers.ToList().Where(p => p.customerNo == custNo);
            return Json(users);
        }

        [HttpGet]
        [Route("api/GetPortalBooks")]
        public IHttpActionResult GetPortalBooks()
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.AllBooks.ToList();
            return Json(items);
        }

        [HttpGet]
        [Route("api/GetPortalBookDetails/{bookId}")]
        public IHttpActionResult GetPortalBookDetails(string bookId)
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.AllBooks.Where(n=>n.No== bookId).ToList();
            return Json(items);
        }

        [HttpGet]
        [Route("api/GetPortalBookByCategory/{invePostingId}")]
        public IHttpActionResult GetPortalBookByCategory(string invePostingId)
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.AllBooks.Where(n => n.Inventory_Posting_Group == invePostingId).ToList();
            return Json(items);
        }


        [HttpGet]
        [Route("api/GetInventoryPostGroup")]
        public IHttpActionResult GetInventoryPostGroup()
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.Inventory_Posting_Groups.ToList();
            return Json(items);
        }

        [HttpGet]
        [Route("api/GetCart/{custNo}")]
        public IHttpActionResult GetCart(string custNo)
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.Cart.Where(c=>c.CustomerNo ==  custNo).ToList();
            return Json(items);
        }

        [HttpGet]
        [Route("api/GetOrders/{custNo}")]
        public IHttpActionResult GetOrders(string custNo)
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.Sales_Header.Where(c=>c.Sell_to_Customer_No == custNo).ToList();
            return Json(items);
        }


        [HttpGet]
        [Route("api/GetOrderDetails/{orderNo}")]
        public IHttpActionResult GetOrderDetails(string orderNo)
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.Sales_Line.Where(c => c.Document_No == orderNo).ToList();
            return Json(items);
        }

        [HttpGet]
        [Route("api/GetCreditMemo/{custNo}")]
        public IHttpActionResult GetCreditMemo(string custNo)
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.PostedCreditMemos.Where(c => c.Sell_to_Customer_No == custNo).ToList();
            return Json(items);
        }

        [HttpGet]
        [Route("api/GetCreditMemoDetails/{documentNo}")]
        public IHttpActionResult GetCreditMemoDetails(string documentNo)
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.CreditMemoLines.Where(c => c.Document_No == documentNo).ToList();
            return Json(items);
        }

        [HttpGet]
        [Route("api/GetPostedReceipt/{custNo}")]
        public IHttpActionResult GetPostedReceipt(string custNo)
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.Posted_Receipts.Where(c => c.Payee_Account_No == custNo).ToList();
            return Json(items);
        }

        [HttpGet]
        [Route("api/GetPostedSalesInvoices/{custNo}")]
        public IHttpActionResult GetPostedSalesInvoices(string custNo)
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.PostedSalesInvoicesHeader.Where(c => c.Sell_to_Customer_No == custNo).ToList();
            return Json(items);
        }


        [HttpGet]
        [Route("api/GetCart")]
        public IHttpActionResult GetCart()
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.Cart.ToList();
            return Json(items);
        }

        [HttpGet]
        [Route("api/GetInventoryPostingGrp")]
        public IHttpActionResult GetInventoryPostingGrp()
        {
            var odataCon = DBConfig.ODataObj();
            var items = odataCon.Inventory_Posting_Groups.ToList();
            return Json(items);
        }

    }
}
