
class Something:

    def result(self):
        x=[]
        y=[]
        with open("Points.txt") as f:
            for num, row in enumerate(f,1):  # row= '313 4 52'
                numbers = list(map(float, row.split(' ')))  # ['313','4','52']
                if num==1:
                    for el in numbers:
                        if el <0:
                            x.append(el)
                elif num==2:
                    for el in numbers:
                        if el>0:
                            y.append(el)

        return print("x={0}'\n'y={1}".format(x,y))


r=Something()
r.result()


