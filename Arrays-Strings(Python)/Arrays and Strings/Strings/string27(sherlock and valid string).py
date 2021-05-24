


def split(word): 
    return [char for char in word]

string = str(input())
S = split(string)

S.sort()

n = len(S)

tab = []
final_tab = []
for j in range(n):
    tab.append(1)

k = 0

for i in range(n-1):
    if(S[i] == S[i + 1]):
        tab[k] += 1
    else:
        k += 1

for u in range(k):
    final_tab.append(tab[u])

j = 0
false = 0

print(final_tab)

x = final_tab[0]
y = 0
xx = x

yy = 0
g = 0
k = 0
b = 0
for i in range(len(final_tab) - 1):
    if(final_tab[i+1] != x):
        print("test1")
        y = final_tab[i+1]
        yy += y
        k = i
        b = i + 1
        break
    g += 1
    xx += x

o = 0

if(abs(x - y) <= 1):
    for i in range(len(final_tab)- k  ):
        if(final_tab[i + k] == x and i+k != g):
            xx += x
        if(final_tab[i + k] == y and i + k != b):
            print("test2")
            yy += y
        if(final_tab[i + k] != x and final_tab[i + k] != y ):
            o = 0
            print("NO")
            break
        o = 1
else:
    print("NO")
print(final_tab)
print(xx,yy)
print(x, y)
if
    if( xx / x >= 2 and yy / y >= 2):
        print("NO")

if((o and abs(x - y) <= 1) or y == 0):
    print("YES")
