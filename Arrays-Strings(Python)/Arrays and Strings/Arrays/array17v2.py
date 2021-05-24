
T = int(input())

for i in range(T):

    a = list(input().split())
    b = list(input().split())

    for i in range(0, len(a)): 
        a[i] = int(a[i])

    row = a[0]
    column = a[1]

    matrix = [[0 for x in range(column)] for y in range(row)] 

    tabela = [1]    

    k = 0

    for i in range(row):
        for j in range(column):
            matrix[i][j] = b[k]
            k += 1

    x = row
    y = column
    
    l = 0
    k = 0
    i = 0

    while(l < column and k < row): 

        i = l
        # print first row from the remaining rows
        while(i < column):
            tabela.append(matrix[k][i])
            i +=1
        k += 1

        # print the last column from the remaining columns
        i = k 
        while(i < row):
            tabela.append(matrix[i][column - 1])
            i += 1
        column -= 1

        #print last row from remaining rows
        i = column - 1
        while(i ):
            tabela.append(matrix[row - 1][i])
            i -= 1
        row -= 1

        #print the first column from remain
        i = row - 1
        while(i):
            tabela.append(matrix[i][l])
            i -= 1
        l += 1
    
    while(len(tabela)!=x * y):
        tabela.pop()
    
    print(*tabela)







