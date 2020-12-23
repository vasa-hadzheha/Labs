import random
class Matrix:

    def __init__(self,count_row,count_column):
        self.count_row=count_row
        self.count_column=count_column

    def matrix_generation(self):

        m=[[float(input("m[{0}][{1}]=".format(i,j))) for j in range(self.count_column)] for i in range(self.count_row)]

        return m
    def show_matrix(self,m):
        b = []
        for row in m:
            row_str = ['{0:5d}'.format(el) for el in row]
            b.append(row_str)

        b = [''.join(['{0:7d}'.format(el) for el in row]) for row in self.m]
        print("Ваша матриця:",*b, sep='\n')

    def __getitem__(self,el):
        for i in range(self.m):            #Не читає значення m--------------------------------------- (Вказувати значення у функції?)
            if el in self.m[i]==True:
                return el
            else:
                raise Exception("Такого елемента немає!!!")    #Error--не працює

    def __setitem__(self,row_count,column_count, value):
        if row_count in list(self.count_row)==True and column_count in list(self.count_column)==True:
            self.m[column_count][row_count]=value
        else:
            raise Exception("Значення введені неправильно!!!")    #Error--не працює

    def __delitem__(self,el):
        for i in range(self.m):
            if el in self.m[i]==True:
                self.m[i].remove(el)
            else:
                raise Exception("Такого елемента немає!!!")     #Error--не працює


    def max(self):
        h=[]
        for i in range(self.m):
            l=max(self.m[i])
            h+=l
        return max(h)

    def min(self):
        h = []
        for i in range(self.m):
            l = min(self.m[i])
            h += l
        return min(h)

d=Matrix(3,3)
d.matrix_generation()
d.min()
d.max
d[5]
d[2,1,1000]
del d[1]

