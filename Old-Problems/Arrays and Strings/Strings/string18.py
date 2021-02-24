
def split(word): 
    return [char for char in word]


T = int(input())


while(T):

    string = str(input())
    S = split(string)
    N = len(S)
    result = 0 

    array = []

    for i in range(N):
        h = 0
        array = S[i]
        for j in range(N - i - 1):
            if(S[i + j + 1] not in array):
                array += S[i + j + 1]
                h += 1
                if(h >= result):
                    result = h
            else: break

    print(result + 1)

    T -= 1