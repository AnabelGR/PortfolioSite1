$("a[uk-slidenav-previous]", ".slider-container").click(function () { $("a[uk-switcher-item='previous']", "#slider").trigger('click') })

$("a[uk-slidenav-next]", ".slider-container").click(function () { $("a[uk-switcher-item='next']", "#slider").trigger('click') })

// You can even add some setInteval() scripts to simulate autoplay
taskID = setInterval(function () {
    $("a[uk-switcher-item='next']", "#slider").trigger('click')
}, 9000)