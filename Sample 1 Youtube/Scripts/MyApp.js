(function () {

    // Create a Module 
    Var app = angular.module('MyApp', ['ng-Route']);

    
    // Create Controller

    app.controller('HomeConrtoller', function($scope)
    {
        $scope.Message = "My First Angular JS Program";

}); 
})();


