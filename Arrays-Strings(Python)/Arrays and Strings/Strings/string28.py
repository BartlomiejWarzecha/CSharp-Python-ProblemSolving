def split(word): 
    return [char for char in word]

string = str(input())
S = split(string)
string =  str(input())
S_2 = split(string)

n = len(S)
n_2 = len(S_2)

k = 0
wynik = 0

for i in range(n-1):
    for j in range(n_2 - k - 1):
        if(n_2 - k - 1 == j +k):
            if(S_2[n_2-1] == S[i]):
                wynik += 1        
                break
        if(S[i] == S_2[j + k]):
            k += 1
            wynik += 1
            break


print(wynik)
