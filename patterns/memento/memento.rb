require 'thread'

# This is a technically a violation of the Memento pattern
# because there is no narrow interface for the Caretaker
class Memento
  @state = ""
  def get_state()
    @state
  end

  def set_state(s)
    @state = s
  end
end

class Originator
  attr_accessor :state
  
  def set_memento(m)
    self.state = m.get_state
  end

  def create_memento()
    m = Memento.new
    m.set_state(state)
    m
  end
end

class Caretaker
  @queue
  def initialize()
    @queue = Queue.new
  end

  def version(m)
    @queue << m
  end

  def rollback()
    m = @queue.deq
  end
end

c = Caretaker.new
o = Originator.new
o.state = "Foo"
puts o.state
c.version o.create_memento 
o.state = "Bar"
puts o.state
m = c.rollback
o.set_memento m
puts o.state
