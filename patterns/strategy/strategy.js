// http://www.dofactory.com/javascript-strategy-pattern.aspx
//
// Note since this is JavaScript and there are no interfaces (see duck typing)
// there is no Strategy Participant in this example

// Context
var Shipping = function() {
  this.company = "";
};

// Context
Shipping.prototype = {
  setStrategy: function(company) {
    this.company = company;
  },
  calculate: function(package) {
    return this.company.calculate(package);
  }
};

// ConcreteStrategy
var UPS = function() {
  this.calculate = function(package) {
    // calculations...
    return "$45.95";
  }
};

// ConcreteStrategy
var USPS = function() {
  this.calculate = function(package) {
    // calculations...
    return "$39.40";
  }
};

// ConcreteStrategy
var Fedex = function() {
  this.calculate = function(package) {
    // calculations...
    return "$43.20";
  }
};

// log helper
var log = (function() {
  var log = "";
  return {
    add: function(msg) { log += msg + "\n"; },
    show: function() { console.log(log); log = ""; }
  }
})();

function run() {
  var package = { from: "76712", to: "10012", weigth: "lkg" };

  // the 3 strategies

  var ups = new UPS();
  var usps = new USPS();
  var fedex = new Fedex();

  var shipping = new Shipping();
  shipping.setStrategy(ups);
  log.add("UPS Strategy: " + shipping.calculate(package));

  shipping.setStrategy(usps);
  log.add("USPS Strategy: " + shipping.calculate(package));

  shipping.setStrategy(fedex);
  log.add("Fedex Strategy: " + shipping.calculate(package));

  log.show();
}

run();
