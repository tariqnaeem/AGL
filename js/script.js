
function callAPI(endpoint){
		$.ajax({url: endpoint, 
			success: function(data){
				return filter(data);
			}			
		});
}

	function filter(data) {
		var arrData = [];
		//removing items that do not have pets
			_.forEach(data, function (item) {
				if(item.pets !=null ){
					arrData.push(item);
				}
				  
			});
			return process(arrData);
	}
	
	function process(arrData){
		
		/**
			group by gender and animals
			**/
			var html = '';						
			result = _.chain(arrData)
									.groupBy("gender")
									.pairs()
									.map(function (currentItem) {
										return _.object(_.zip(["gender", "animals"], currentItem));
									})
									.value();
									
									
									
									_.forEach(result, function (item) {
										html += '<b>'+item.gender+'</b><ul>';
										_.forEach(item.animals, function (animal) {
			
											animals  = _.sortBy(animal.pets, "name");
											
											_.forEach(animals, function (pet) {
												if(pet.type == 'Cat'){
													html += '<li>'+pet.name+'</li>';
												}
											});
											
										  });
										  html += '</ul>'
									});
									
									
											
			$("#result").html(html);								

		
	}