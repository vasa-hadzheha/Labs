r=int(input("кількість рядків r="))
e=int(input("кількість елементів e="))

a=[[float(input("a[{0}][{1}]=".format(i,j)))  for j in range(e)] for i in range(r)]
print("Матриця а ={0}".format(a))
h=[]
for i in range(r):
    for j in range(2,e,2):
        if a[i][j]>0:
            h+=[a[i][j]]
print("h=",h)
print(a.sort(key= lambda sum:))
