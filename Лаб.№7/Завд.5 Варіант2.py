r=int(input("кількість рядків r="))
e=int(input("кількість елементів e="))

a=[[float(input("a[{0}][{1}]=".format(i,j)))  for j in range(e)] for i in range(r)]
print("Матриця а ={0}".format(a))
#Недороблено ------------------------------------
j=0
count=0
for j in range(e):
    for i in range(r):
        if a[i][j] !=0:
            count+=1
print(count)



