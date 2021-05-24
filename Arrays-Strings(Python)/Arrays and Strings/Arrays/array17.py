
T = int(input())

for i in range(T):

    a = list(input().split())
    b = list(input().split())

    for i in range(0, len(a)): 
        a[i] = int(a[i])

    row = a[0]
    column = a[1]

    matrix = [[0 for x in range(row)] for y in range(column)] 

    tabela = []    

    for i in range(0, len(b)): 
        b[i] = int(b[i])

    k = 0
    for i in range(row):
        for j in range(column):
            matrix[i][j] = b[k]
            k += 1



    while(row + column):

        k = 0
        l = 0
        i = 0

        for j in range(column):
            k += 1
            tabela.append(matrix[i][j])

        row -= 1

        if(k == column):
            i += 1
            while(i != row-1):
                tabela.append(matrix[i][k])
                i += 1
            column -= 1
        
        k = column - 1 

        for i in range(column):
            
            tabela.append(matrix[i][k])

            k -= 1

        print(tabela)
        row = 0
        culumn = 0

    # rows o jeden mniej schodzenie dol/gora
    # columny ilosc kolumn = ilosci o ile schodzi sie dol gora



