//site.js
(function () {    
    //var ele = $("#username");
    //ele.text("Neo Anderson");

    //var main = $("#main");
    //main.on("mouseleave", function () {
    //    main.style="";
    //});
    //main.on("mouseenter", function () {
    //    main.style="background-color: #888;";
    //});

    //var menuItems = $("ul.menu li a");
    //menuItems.on("click", function () {
    //    var me = $(this);
    //    alert(me.text());
    //});
    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click",function(){
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            //  $(this).text("Show Sidebar");
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        }
        else {
            //$(this).text("Hide Sidebar");
            $icon.addClass("fa-angle-left");
            $icon.removeClass("fa-angle-right");
        }
});
})();