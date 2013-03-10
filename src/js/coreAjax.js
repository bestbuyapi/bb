function AjaxCore() {
    
   this.sendRequest = function(serviceUrl)
   {   
		var request = $.ajax({
					url: serviceUrl,
					type: 'GET',
					dataType: 'json',
				error: function (a, b, c) {
					console.log(a);
					console.log(b);
					console.log(c);
				}
			});
	
		return request;
   } 

  this.sendRequestData = function(userData, serviceUrl)
   {   
		var request = $.ajax({
					url: serviceUrl,
					type: 'GET',
					data : userData,
					dataType: 'json',
				error: function (a, b, c) {
					console.log(a);
					console.log(b);
					console.log(c);
				}
			});
	
		return request;
   }    
}