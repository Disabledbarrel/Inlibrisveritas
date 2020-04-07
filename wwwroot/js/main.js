// Navigation

$('nav a#toggle').click(function () {
    $('ul').slideToggle(200, function () {
        // Animation complete.
    });
});