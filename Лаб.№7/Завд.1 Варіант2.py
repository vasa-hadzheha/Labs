#Визначити суму додатних елементів матриці з першим парним і другим непарним індексами.
r=int(input("кількість рядків r="))
e=int(input("кількість елементів e="))
# a=[]
# for i in range(r):
#     row=[]
#     for j in range(e):
#         el=float(input('a[{0}][{1}]='.format(i,j)))
#         row.append(el)
#     a.append(row)
a=[[float(input("a[{0}][{1}]=".format(i,j)))  for j in range(e)] for i in range(r)]
print("Матриця а ={0}".format(a))
s=0
for i in range(2,r,2):
    for j in range(1,e,2):
        if a[i][j]>0:
            s+=a[i][j]
print("сума додатних елементів матриці з першим парним і другим непарним індексами= {0}".format(s))