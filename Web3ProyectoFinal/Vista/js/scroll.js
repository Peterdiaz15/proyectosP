$(document).ready(function($) {
	


	$(window).scroll(function(){
   if ($(this).scrollTop() > 100) {
        $('.scrollup').fadeIn();
   } else {
        $('.scrollup').fadeOut();
   }


});
	$('.scrollup').click(function(){
    $("html, body").animate({ scrollTop: 0 }, 600);
    return false;
});

	var altura = $('.navbar-collapse').offset().top;
	
	$(window).on('scroll', function(){
		if ( $(window).scrollTop() > altura ){
			$('.navbar-collapse').addClass('menu-fixed');
		} else {
			$('.navbar-collapse').removeClass('menu-fixed');
		}
	});
});