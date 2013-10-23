class Coffee
  def cost
    2
  end
end

class Sugar
  def initialize(component)
    @component = component
  end

  def cost
    @component.cost + 0.2
  end
end

class Milk
  def initialize(component)
    @component = component
  end

  def cost
    @component.cost + 0.4
  end
end

coffee = Coffee.new
puts "Should print 2.6"
puts Sugar.new(Milk.new(coffee)).cost  # 2.6
puts "Should print 2.4"
puts Sugar.new(Sugar.new(coffee)).cost # 2.4
puts "Should print Sugar"
puts Sugar.new(Milk.new(coffee)).class # Sugar

# The thing to note here is that I did not have to create a CoffeeWithMilkAndSugar and a CoffeeWithTwoSugars class
