

def split(word): 
    return [char for char in word]

T = int(input())

while(T):

    string = input()
    a = split(string)
    la = len(a)
    x = ""
    y = ""
    final = 0
    for i in range(la-1):
        x += a[i]
        y = a[la - 1 - i] + y
        if(x == y):
            final = i + 1
    print(final)

    T -= 1 
