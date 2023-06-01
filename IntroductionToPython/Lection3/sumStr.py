def sumStr(*args):
    res = ""  
    for i in args:
        res+=i
    return res
print(sumStr('q', 'w', 'e', 'r'))
print(sumStr('a', "asdf", "asdf"))