#pragma checksum "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1bd4a8441e950828c41236175213dd1d7c37979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Details), @"mvc.1.0.view", @"/Views/Recipes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipes/Details.cshtml", typeof(AspNetCore.Views_Recipes_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Guest/Desktop/FoodSaverClient/Views/_ViewImports.cshtml"
using FoodSaverClient;

#line default
#line hidden
#line 5 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
using FoodSaverClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1bd4a8441e950828c41236175213dd1d7c37979", @"/Views/Recipes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94863bbcd32d8c82821662163f73ea5811c8cc44", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
  
    ViewData["Title"] = "RecipeId";

#line default
#line hidden
            BeginContext(41, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(88, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(94, 16, false);
#line 8 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
Write(Model.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(110, 151, true);
            WriteLiteral(": </h1>\n\n  <div class = \"row\"></div>\n  <div class=\"card\" id=\"card1\">\n      <div class=\"card-body\">\n        <h5 class=\"card-title\">/h5> \n          <h4> ");
            EndContext();
            BeginContext(262, 14, false);
#line 14 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
          Write(Model.PrepTime);

#line default
#line hidden
            EndContext();
            BeginContext(276, 20, true);
            WriteLiteral("</h4>\n          <h4>");
            EndContext();
            BeginContext(297, 20, false);
#line 15 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
         Write(Model.CostPerServing);

#line default
#line hidden
            EndContext();
            BeginContext(317, 153, true);
            WriteLiteral("</h4>\n      </div>\n    </div>\n    <div class=\"card\" id=\"card1\">\n      <div class=\"card-body\">\n        <h5 class=\"card-title\">Directions</h5>\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 470, "", 493, 1);
#line 21 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
WriteAttributeValue("", 475, Model.RecipePhoto, 475, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(493, 58, true);
            WriteLiteral(" alt= \"O\" class=\"recipepic\">\n        <p class=\"card-text\">");
            EndContext();
            BeginContext(552, 16, false);
#line 22 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                        Write(Model.Directions);

#line default
#line hidden
            EndContext();
            BeginContext(568, 192, true);
            WriteLiteral("</p>\n\n        \n      </div>\n    </div>\n    <br>\n    <div class=\"card\" id=\"card2\">\n      <div class=\"card-body\">\n        <h5 class=\"card-title\">Nutrition Info</h5>\n        <p class=\"card-text\">");
            EndContext();
            BeginContext(761, 19, false);
#line 31 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                        Write(Model.NutritionInfo);

#line default
#line hidden
            EndContext();
            BeginContext(780, 172, true);
            WriteLiteral("</p>\n      </div>\n    </div>\n    <br>\n    <div class=\"card\" id=\"card3\">\n      <div class=\"card-body\">\n        <h5 class=\"card-title\">Tips</h5>\n        <p class=\"card-text\">");
            EndContext();
            BeginContext(953, 16, false);
#line 38 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                        Write(Model.RecipeTips);

#line default
#line hidden
            EndContext();
            BeginContext(969, 185, true);
            WriteLiteral("</p>\n      </div>\n    </div>\n    <br>\n    <div class=\"card\" id=\"card4\">\n      <div class=\"card-body\">\n        <h5 class=\"card-title\">Price Per Serving</h5>\n        <p class=\"card-text\">");
            EndContext();
            BeginContext(1155, 20, false);
#line 45 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                        Write(Model.CostPerServing);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 79, true);
            WriteLiteral("</p>\n      </div>\n    </div>\n  </div>\n\n\n\n\n\n\n\n\n\n<!-- <ol>\n    <ul>\n        <li> ");
            EndContext();
            BeginContext(1255, 16, false);
#line 60 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
        Write(Model.RecipeName);

#line default
#line hidden
            EndContext();
            BeginContext(1271, 30, true);
            WriteLiteral("</li>\n        <li>Directions: ");
            EndContext();
            BeginContext(1302, 16, false);
#line 61 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                   Write(Model.Directions);

#line default
#line hidden
            EndContext();
            BeginContext(1318, 36, true);
            WriteLiteral("</li>\n        <li>Nutritional Info: ");
            EndContext();
            BeginContext(1355, 19, false);
#line 62 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                         Write(Model.NutritionInfo);

#line default
#line hidden
            EndContext();
            BeginContext(1374, 24, true);
            WriteLiteral("</li>\n        <li>Tips: ");
            EndContext();
            BeginContext(1399, 16, false);
#line 63 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
             Write(Model.RecipeTips);

#line default
#line hidden
            EndContext();
            BeginContext(1415, 38, true);
            WriteLiteral(" </li>\n        <li>Price per serving: ");
            EndContext();
            BeginContext(1454, 20, false);
#line 64 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                          Write(Model.CostPerServing);

#line default
#line hidden
            EndContext();
            BeginContext(1474, 60, true);
            WriteLiteral(" </li>\n    </ul>\n</ol> -->\n\n<button class=\"btn btn-default\">");
            EndContext();
            BeginContext(1535, 40, false);
#line 68 "/Users/Guest/Desktop/FoodSaverClient/Views/Recipes/Details.cshtml"
                           Write(Html.ActionLink("Back To Home", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 11, true);
            WriteLiteral("</button>\n\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
