(function ($) {
    
		$.fn.configureMainPage = function (imageDiv, buttonListDiv, serviceUrl) {

				
				var ajaxCore = new AjaxCore(serviceUrl);
				var requestMenu = ajaxCore.sendRequest(serviceUrl);
			    requestMenu.done(function (data) {
						//console.log(data);
				});
		};
})(jQuery);