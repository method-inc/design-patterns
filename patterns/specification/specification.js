// Specification
var ISpecification = {
  Satisfies : function(shirt){}
}

// Object
var Tshirt = function(name){
  this.Name = name;
}

// ConcreteSpecification
var TshirtSpecification = function(){};

// Extend the ISpecification for TshirtSpecification 
TshirtSpecification.prototype = Object.create(ISpecification);
TshirtSpecification.prototype.Satisfies = function(shirt){
  return shirt.Name == "Awesome";
};

// Log helper
var log = (function () {
  var log = "";
  return {
    add: function (msg) { log += msg + "\n"; },
    show: function () { console.log(log); log = ""; }
  }
})();


function run() {
  var ats = new Tshirt("Awesome");
  var nts = new Tshirt("Not Awesome");
  var criteria = new TshirtSpecification();

  log.add("Is the shirt awesome? " + criteria.Satisfies(ats));
  log.add("Is the shirt awesome? " + criteria.Satisfies(nts));
  
  log.show();
}

run();
