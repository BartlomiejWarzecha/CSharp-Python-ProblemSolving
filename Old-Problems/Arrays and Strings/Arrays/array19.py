
pom = list(input().split())

for k in range(0, len(pom)): 
    pom[k] = int(pom[k])

n = pom[0]
rot = pom[1]

a = list(input().split())

for k in range(0, len(a)): 
    a[k] = int(a[k])
c = a
b = c
rotation = n - rot
print(b)

i = 0
while(i < n):
    a[i-rotation] = b[i]
    i += 1

print(a)