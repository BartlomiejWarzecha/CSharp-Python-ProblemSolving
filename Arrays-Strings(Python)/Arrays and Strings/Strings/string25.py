def split(word): 
    return [char for char in word]

string = str(input())
S = split(string)
string = str(input())
S_2 = split(string)


dlugosc = len(S)+len(S_2)

zgadzajace = 0 

for i in range(len(S)):
    for j in range(len(S_2)):
        if(S[i] == S_2[j]):
            S_2[j] = '-'
            zgadzajace += 1
            break

for i in range(len(S_2)):
    if(S_2[i] == '-'):
        zgadzajace += 1



wynik = dlugosc - zgadzajace

print(wynik)







