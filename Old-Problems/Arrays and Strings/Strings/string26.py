def split(word): 
    return [char for char in word]
n = int(input())

delete = []

for c in range(n):
    delete.append(c)

for i in range(n):

    wynik = 0

    string = str(input())
    S = split(string)

    for j in range(len(S)-1):
        if(S[j] == S[j+1]):
            wynik += 1


    delete[i] = wynik 


for k in delete:
    print(k)