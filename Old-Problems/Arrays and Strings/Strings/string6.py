
def split(word): 
    return [char for char in word]

T = int(input())

while(T):

    string = input()
    a = split(string)
    a.sort()

    x = 2
    k = 0
    max = 1

    for i in range(len(a)-1):
        if(a[i] == a[i+1]):
            x += 1
        else: 
            if(x > max):
                if(i == 0): x -= 1 
                max = x
                k = i
                x = 1

    print('najczęstsza = ',a[i])

    T -= 1 

