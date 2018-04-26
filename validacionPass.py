espacio=False  #variable para identificar espacios
mayuscula=False #variable para identificar letras mayúsculas
minuscula=False #variable para contar identificar letras minúsculas
numeros=False #variable para identificar números
alfa = False #booleano que dice si tiene o no alfanumericos
contra = input("Mete la contra ")
longitud = len(contra)
y=contra.isalnum()
for posicion in contra: #ciclo for que recorre caracter por caracter en la contraseña

    if posicion.isspace()==True: #Saber si el caracter es un espacio
                espacio=True #si encuentra un espacio se cambia el valor user
    if posicion.isupper()== True: #saber si hay mayuscula
                mayuscula=True #acumulador o contador de mayusculas                
    if posicion.islower()== True: #saber si hay minúsculas
                minuscula=True #acumulador o contador de minúsculas              
    if posicion.isdigit()== True: #saber si hay números
                numeros=True #acumulador o contador de n
    if posicion.isalnum()== True: #saber si hay caracteres no alfanumericos
                alfa=True #Booleando de si tiene o no alfa
if longitud >= 8 and espacio == False and mayuscula == True and minuscula == True and numeros == True and alfa == False:
    print ("ACCEPTADA")
else:
    print ("DENEGADA")
