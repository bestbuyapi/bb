var hostName = "http://localhost";
var interestingProductUrl = hostName + "/BBService/api/productInfo/GetMostInterestingProduct";
var vendorProductUrl = hostName + "/BBService/api/productInfo/GetProductByVendor/";
var getProductUrl = hostName + "/BBService/api/productInfo/GetProduct/";


		function getUrlVars()
		{
				var vars = [], hash;
				var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
				for(var i = 0; i < hashes.length; i++)
				{
					hash = hashes[i].split('=');
					vars.push(hash[0]);
					vars[hash[0]] = hash[1];
				}
				return vars;
		 }
		
		