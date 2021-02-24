


def split(word): 
    return [char for char in word]

T = int(input())


while(T):

    string = input()
    a = split(string)
    
    for i in range(len(a)):
        print(a[i],i)

    T -= 1