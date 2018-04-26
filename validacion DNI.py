dni = input("Mete tu dni (8 numero - 1 letra)\n")
aux = dni.split("-") 
numeros = aux[0]
letra = aux[1]

arrayletras = ["T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E"]
numeros = int(numeros)
resto = numeros % 23
if arrayletras[resto] == letra:
    print ("DNI CORRECTO")
else:
    print ("DNI FALSO")
