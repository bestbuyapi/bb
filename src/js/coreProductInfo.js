(function ($) {
    
			$.fn.loadProductInfo = function (productId, serviceUrl) 
			{

				$("#goBackBtn").click(function() {
							history.back();
							return false;
				});

				var ajaxCore = new AjaxCore();
				var userData = { "ProductId" : productId }
				var requestMainPage = ajaxCore.sendRequestData(userData, serviceUrl);
				requestMainPage.done(function (data) {				
					
					if (data != undefined && data != null) { 
				
						$("#vendorProductName").html(data.ProductTitle);
						$("#productImage").attr("src", data.ProductImage);
						$("#ProductDetails").html(data.ProductDescription);
						
					};
				});
		    
    };
})(jQuery);