def add_good(base_of_goods,count_of_new_goods):
    n=1
    new_good=dict()
    while n<=count_of_new_goods:
        name_of_good =input("Введіть назву нового товара: ")
        measurement =input("Введіть одиницю виміру: ")
        count =int(input("Введіть кількість: "))

        new_good[name_of_good]=[measurement,count]

        base_of_goods.update(new_good)
        n+=1
    print("Оновлена база товарів:", base_of_goods)
    return base_of_goods


def del_good(base_of_goods,count_of_del_goods):
    n=1
    while n<=count_of_del_goods:
        name_of_good = input("Введіть назву товара: ")
        del base_of_goods[name_of_good]
        n+=1
    print("База з видаленими товарами:", base_of_goods)
    return base_of_goods



base_of_goods={'Молоко':['пак.',10], 'Хліб':["шт.",6],'Сіль':['пак.',13],'Кола':["банок",15]}
print("Поточна база товарів:",base_of_goods)

add_good(base_of_goods,2)
del_good(base_of_goods,1)
print("Поточна база товарів:",base_of_goods)




