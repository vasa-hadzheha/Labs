n=int(input("Введіть ціле значення n: "))
x0=x1=1
i=2
xi=0
x=1
while i<=n:
    xi +=x1+2*x0
    i+=1
print(xi)