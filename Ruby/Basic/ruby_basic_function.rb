class RubyBasicFunction
  puts 1.to_s  #output: "1"
  puts 1.0.to_s  #output: "1.0"
  puts "123".to_i #output: 123
  puts 1.nil? #output: false
  puts 1.is_a?(Fixnum) #output: true
  #puts a.is_a?(Fixnum) #output: undefine local variable or method 'a'
  puts nil.is_a?(TrueClass) #output: true
  puts "1".class #output: string
  puts 1.class #output: Fixnum
  puts 1.0.class #output: Float
  puts nil.class #output: NilClass
  puts true.class #output: TrueClass
  puts a=2 #output: 2
  puts a==2 #output: true
  puts a==3 #output: false
  puts 1==1 #output: true
  puts a.is_a?(Object) #output: true
  puts a.is_a?(Fixnum) #output: true
  puts a.is_a?(String) #output: false
  puts a=a+1 #output: 3
  puts a+=2 #output: 5
  puts a/2.0 #output: 2.5
  puts a/2 #output: 2
  puts a.even? #output: false
  puts text="hello" #output: hello
  puts text=text+" hello" #output: hello hello
  puts text+=" there" #output: hello hello there
  puts text/2 #output: error
end