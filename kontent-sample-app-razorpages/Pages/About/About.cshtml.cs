﻿using System.Threading.Tasks;
using Kentico.Kontent.Delivery.Abstractions;
using kontent_sample_app_razorpages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace kontent_sample_app_razorpages
{
    public class AboutModel : PageModel
    {
        private readonly IDeliveryClient _deliveryClient;

        public IDeliveryItemResponse<AboutUs> AboutUs { get; set; }

        public AboutModel(IDeliveryClient deliveryClient)
        {
            _deliveryClient = deliveryClient;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            AboutUs = await _deliveryClient.GetItemAsync<AboutUs>("about_us");

            return Page();
        }
    }
}