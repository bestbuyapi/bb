(function ($) {
    
			$.fn.getVendorProductInfo = function (vendorName, targetRenderId, serviceUrl) {

			var ajaxCore = new AjaxCore();
			var vendorData = { "VendorName" : vendorName }
            var requestMainPage = ajaxCore.sendRequestData(vendorData, serviceUrl);
			var productDescription = null;
			var productUnitType = null; 
			
            requestMainPage.done(function (data) {
				
					for (var i=0; i < data.length; i++)
					{						
						if (data[i].ProductDescription == null) 
							productDescription = "";
						else 
							productDescription = data[i].ProductDescription;
							
						if (data[i].ProductUnitType == null) 
							productUnitType = "";
						else 
							productUnitType = "/" + data[i].ProductUnitType;	
						
					
						$("#" + targetRenderId).append("<li><a data-ajax='false' href='productInfo.html?title=" + data[i].ProductId + "'><h2>" + data[i].ProductTitle + "</h2><p style='font-size:20px'>" + data[i].ProductPromotionPrice +  "   " + productUnitType + "</p> <p style='text-decoration: line-through; font-size: 17px'>" + data[i].ProductNormalPrice +  "</p><img src='" + data[i].ProductImage + "'><p><strong>&nbsp</strong></p><p>" + productDescription + "</p><p class='ui-li-aside'><strong>&nbsp;</strong>&nbsp;</p></a></li>");
						
					}
					$("#" + targetRenderId).listview("refresh");
					
			});					
		    
    };
})(jQuery);