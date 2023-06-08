def calc1(a):
    return a+a

def calc2(a):
    return a*a

def math(op,x):
    print(op(x))

math(calc1,5)
math(calc2,7)

def math2(function_name, x, y):
    print(function_name(x,y))

def calc3(a,b):
    return a - b

math2(calc3, 4,10)