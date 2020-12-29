
res=[]
with open("Test2.txt") as f:
    for row in f:       # row= '313 4 52'
        numbers=list(map(float, row.split(' ')))  # ['313','4','52']
        res+=numbers

print(res)
m=max(res)

new_list=str(map(lambda el:el==m if el==0 else el , res))
print(new_list)
with open("new_data",'w') as f:
    f.write(new_list)     # Показує тільки адресу





