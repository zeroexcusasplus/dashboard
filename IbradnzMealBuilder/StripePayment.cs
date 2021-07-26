using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Models;

using Microsoft.AspNetCore.Identity;
using RestSharp;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IbradnzMealBuilder
{
    public class StripePayment
    {
        

        public static async Task<dynamic> PayAsync(PaymentModel paymentModel,int amountInCents)
        {
            try
            {


                StripeConfiguration.ApiKey = "sk_test_51HLWNwAydFIsMiHPnCXWWj4LEcNZ9yvpPrYuNo7CH0vcktny2InKuihs5LapLDgdQBYmIXwcC92e25HHqYUYPlc900syJsguGt";

                var optionstoken = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = paymentModel.CardNumber,
                        ExpMonth = paymentModel.Month,
                        ExpYear = paymentModel.Year,
                        Cvc = paymentModel.Cvc,                        
                      
                    }
                };

                var tokenService = new TokenService();
                Token token = await tokenService.CreateAsync(optionstoken);

                var options = new CustomerCreateOptions
                {
                    Description = "My First Test Customer (created for API docs)",
                };
                var service = new CustomerService();
                service.Create(options);

                var chargeCreateOptions = new ChargeCreateOptions
                {
                    Amount = amountInCents,
                    Currency = "usd",
                    Description = "Zero Excusas PLUS mensual",
                    Source = token.Id,
                    
                    
                };


                var chargeService = new ChargeService();
                Charge charge = await chargeService.CreateAsync(chargeCreateOptions);
                //if(paymentModel != null && !String.IsNullOrEmpty(paymentModel.CouponCode))
                //{
                //    var CoupOptions = new PromotionCodeCreateOptions
                //    {
                //        Coupon = paymentModel.CouponId,
                //        Code = paymentModel.CouponCode,
                //    };
                //    var CoupService = new PromotionCodeService();
                //    PromotionCode promotionCode = CoupService.Create(CoupOptions);
                //}
               


                //var cs =charge.Customer;


                if (charge.Paid)
                {

                    return "Success";
                    
                }
                else
                {
                    return "Failed";
                }
             

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static Task<Stripe.Customer> CustomerCreatseOptions()
        {
            throw new NotImplementedException();
        }

        
    }
}
