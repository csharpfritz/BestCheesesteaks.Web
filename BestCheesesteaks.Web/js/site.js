(function() {
	
	$(window).scroll(function() {
		var scrollTop = $(window).scrollTop();
		if (scrollTop > 370) {
			// scrolled off of the top
			$("ul.menu").addClass("hidden");
			$("ul.staticMenu").removeClass("hidden");
		} else {
			// at the top
			$("ul.menu").removeClass("hidden");
			$("ul.staticMenu").addClass("hidden");
		}	
		
		if($('#HowToOrder').offset().top < $(document).scrollTop()) {
			RemoveHighlight();
			$("a[href='#HowToOrder']").parent().addClass("active");
		} else if ($('#WhereToGo').offset().top < $(document).scrollTop()) {
			RemoveHighlight();
			$("a[href='#WhereToGo']").parent().addClass("active");
		} else {
			RemoveHighlight();
			$("a[href='#top']").parent().addClass("active");
		}

    });
		
	function RemoveHighlight() {
		$("li.active").removeClass("active");
	}
	
})();