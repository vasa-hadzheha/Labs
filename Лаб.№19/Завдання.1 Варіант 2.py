def write_file(file_name, data):     #НЕ ЗНАЮ ЯК СТВОРИТИ ФАЙЛ
    '''Запис у файл значень з ітерованого об"єкта data'''
    with open(file_name,'w') as f:
        f.write( (' ').join( map(str,data) ) )
    print('Done')

def read_file(file_name):
    '''Функція для зчитування чисел з файлу у вигляді списку'''
    res=[]
    with open(file_name) as f:
        for row in f:       # row= '313 4 52'
            numbers=list(map(int, row.split(' ')))  # ['313','4','52']
            res+=numbers
    return  res


file_name=input('File name: ')
data=read_file(file_name)
data2=map((lambda el:el*2 if el>10 else el), data)
write_file(file_name,data2)
print(list(data2))





