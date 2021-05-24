def split(word): 
    return [char for char in word]

string = str(input())
S = split(string)
string = str(input())
S_2 = split(string)

S.sort()
S_2.sort()

if(S < S_2):
    C = S
    S = S_2
    S_2 = C



both_len = len(S) + len(S_2)

k = 0

for i in range(len(S)):
    for j in range(len(S_2)):
        if(S[i] == S_2[j]):
            S_2[j] = '0'
            k += 1
            continue

print(both_len - (2*k))