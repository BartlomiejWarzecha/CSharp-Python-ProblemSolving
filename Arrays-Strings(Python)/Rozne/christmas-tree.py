

print("Ile rzędów ma mieć choinka?")

n = int(input())


for i in range(n):
    a = ''
    for j in range(n-i):
        a += ' '

    print(a + (i+1)*'*'*2)

 
        