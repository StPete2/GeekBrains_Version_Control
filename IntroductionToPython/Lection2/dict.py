d = {}
d = dict()

d ['q'] = 'qwerty'
print(d)
d ['w'] = 'werty'
print(d)
print(d['q'])
d ['e'] = 'erty'
print(d)
del d['e']
print(d.items())
for (k,v) in d.items():
    print(k,v)
