
pom = list(input().split())

for k in range(0, len(pom)): 
    pom[k] = int(pom[k])

n = pom[0]
rot = pom[1]

a = list(input().split())

for k in range(n): 
    a[k] = int(a[k])

c = []

for j in range(n):
    c.append(a[j])


for i in range(n):
    if(i - rot < 0):
        k = i - rot + n 
        c[k] = a[i]

    if(i >= 0):
        k = i - rot
        c[k] = a[i]

for i in c:
    print(i,end = ' ')

