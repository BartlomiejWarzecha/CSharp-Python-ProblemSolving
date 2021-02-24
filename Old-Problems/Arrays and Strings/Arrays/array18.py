
row = 6
column = 6

tab_row = 4
tab_col = 4

matrix = [[0 for x in range(column)] for y in range(row)] 

tabela = [[0 for x in range(tab_col)] for y in range(tab_row)] 


k = 0

for i in range(6):

    b = list(input().split())

    for k in range(0, len(b)): 
        b[k] = int(b[k])

    for j in range(6):
        matrix[i][j] = b[j]

for i in range(4):
    for j in range(4):
        tabela[i][j] = matrix[i][j]
        tabela[i][j] += matrix[i][j+1]
        tabela[i][j] += matrix[i][j+2]
        tabela[i][j] += matrix[i+1][j+1]
        tabela[i][j] += matrix[i+2][j]
        tabela[i][j] += matrix[i+2][j+1]
        tabela[i][j] += matrix[i+2][j+2]

wynik = []

for i in tabela:
    for k in i:
        wynik.append(k)

print(max(wynik))



