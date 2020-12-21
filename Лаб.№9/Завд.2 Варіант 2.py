def add_product(base_of_products,count_of_new_products):
    n=1
    new_product=dict()
    while n<=count_of_new_products:
        name_of_product =input("Введіть назву нового продукту: ")
        measurement =input("Введіть одиницю виміру: ")
        count =int(input("Введіть кількість продукта: "))
        price=float(input("Введіть вартість одиниці: "))
        new_product[name_of_product]=[measurement,count,price]

        base_of_products.update(new_product)
        n+=1
    print("Оновлена база товарів:", base_of_products)
    return base_of_products

def search_product(base_of_products):

    searching=input("Введіть назву продукта: ")
    print(base_of_products.get(searching,"Нічого не знайдено"))

base_of_products={'Молоко':['пак.',10,15], 'Хліб':["шт.",6,14.50],'Сіль':['пак.',13,7],'Кола':["банок",15,10.75]}

search_product(base_of_products)

