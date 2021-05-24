#Dijkstra: szukaj najbliższego (zachłanny) i aktualizuj
#Directed Valued Graph DVGr[i]=[[ojciec,value],[1syn,odl],[2syn,...] 

global Inf, DVGr 
global Solved, Queue
Inf=999

DVGr=[[[-1,0],[1,2],[2,6]],[[None,Inf],[2,1],[3,3]]]
DVGr.extend([[[None,Inf],[4,5]],[[None,Inf],[5,4],[2,1]]])
DVGr.extend([[[None,Inf],[3,1]],[[None,Inf]]])

Solved=[-1,0]; Queue=[]
for n in DVGr:
    print(n)

def Value (pa):
    for son in DVGr[pa]:
        sonID=son[0]
        if sonID not in Solved :
            if DVGr[pa][0][1]+son[1]<DVGr[sonID][0][1]:
                DVGr[sonID][0][1]=DVGr[pa][0][1]+son[1]
                DVGr[sonID][0][0]=pa
            if sonID not in Queue :
                Queue.append(sonID)
    return 

def minNode():
    min=Inf
    for n in Queue:
        if DVGr[n][0][1]<min:
            min=DVGr[n][0][1]
            nmin=n
    Solved.append(nmin)
    Queue.remove(nmin)
    return nmin

Value(0)
while len(Queue)>0:
    Value(minNode())

for n in DVGr:
    print(n[0])
print()

#Bellman-Ford
Gr=[[[-1,0],[1,2],[2,5]],[[None,Inf],[2,8],[3,7]]]
Gr.extend([[[None,Inf],[3,2],[4,4]],[[None,Inf],[5,1]]])
Gr.extend([[[None,Inf],[3,6],[5,3]],[[None,Inf]]])

def BellFo(Gr):
    nx=-1; loo=0; chng=True
    for i in range(len(Gr)):
        nx+=len(Gr[i])-1
    while loo<nx and chng:
        loo+=1; chng=False
        for i in range(len(Gr)):
            if Gr[i][0][0] != None:
                for j in range(1,len(Gr[i])):
                    rel=Gr[i][0][1]+Gr[i][j][1]
                    son=Gr[i][j][0]
                    if Gr[son][0][1]>rel:
                        Gr[son][0][1]=rel
                        Gr[son][0][0]=i
                        chng=True
    return Gr,chng

for n in Gr:
    print(n)
GrSolv,zle=BellFo(Gr)
for i in GrSolv:
    print(i[0])
