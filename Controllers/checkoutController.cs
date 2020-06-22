using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingCartCore.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace ShoppingCartCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class checkoutController : ControllerBase
    {




        // GET: api/checkout

        [HttpGet]
        public IEnumerable<InventoriesData> Get()
        {
            string json;
            using (StreamReader r = new StreamReader("InventoriesData.json"))
            { json = r.ReadToEnd(); }
            var data = JsonConvert.DeserializeObject<IEnumerable<InventoriesData>>(json);


            return data;

        }



        [HttpPost]
        public ResponseModel Post(string[] selection)

        {
            string json;
            using (StreamReader r = new StreamReader("InventoriesData.json"))
            { json = r.ReadToEnd(); }
            var data = JsonConvert.DeserializeObject<IEnumerable<InventoriesData>>(json);

            InventoriesData InvData = data.First<InventoriesData>();

            // Get the products with offer
            var productsWithDiscount = from c in InvData.Inventory
                                       where !c.prodDiscountQuantity.Equals(string.Empty)
                                       select new { c.prodID, c.prodDiscountAmount, c.prodDiscountQuantity, c.prodPrice };

            decimal totPriceForProductsWithOffers = 0;
            decimal totPriceForProductsWithoutOffer = 0;


            //Loop through the items with offer
            foreach (var row in productsWithDiscount)
            {

                //count the customer selection with products with offers For example 5 rolex watches - with discount offer 3 for 200
                int countDiscountedItem = (from c in selection
                                           where c.Equals(row.prodID)
                                           select c).Count();

                //calculate the product price having offers

                int remainder = countDiscountedItem % int.Parse(row.prodDiscountQuantity);
                int quotient = countDiscountedItem / int.Parse(row.prodDiscountQuantity);
                decimal totDiscountedPrice = quotient * decimal.Parse(row.prodDiscountAmount);
                totPriceForProductsWithOffers += (remainder * row.prodPrice) + totDiscountedPrice;



            }



            // Get the products without offer
            var productsWithoutDiscount = from c in InvData.Inventory
                                          where c.prodDiscountQuantity.Equals(string.Empty)
                                          select new { c.prodID, c.prodDiscountAmount, c.prodDiscountQuantity, c.prodPrice };


            foreach (var row in productsWithoutDiscount)
            {
                //count the customer selection with products without offers 
                int countNonDiscountedItem = (from c in selection
                                              where c.Equals(row.prodID)
                                              select c).Count();

                totPriceForProductsWithoutOffer += (countNonDiscountedItem * row.prodPrice);


            }




            

            ResponseModel res = new ResponseModel();
            res.statusCode = "000";
            res.statusDesc = "Success";
            res.summaryResponse.TotalPrice = totPriceForProductsWithOffers + totPriceForProductsWithoutOffer;



            return res;


        }



    }
}
