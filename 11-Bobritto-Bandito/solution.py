# Enunciado:    Bobritto Bandito
# Problema:     
# Fecha:        13/04/2025    
# Autor:        Mirco Sair Salcedo Ataulluco

nroCases = int(input()) # nro de casos
cases = []

for i in range(nroCases):
    cases.append(input())

for case in cases:
    parameters = case.split()
    n, m, l, r = int(parameters[0]), int(parameters[1]), int(parameters[2]), int(parameters[3])
    infectedHousesRange = [k for k in range(l,r+1)] # genera una lista con el numero de casas infectadas

    # restar el nro de casas infectadas por cada dia de diferencia de n a m
    daysDiference = n - m 
    for j in range(daysDiference): # realizara el proceso n - m veces
        if (infectedHousesRange[-1] != 0):
            infectedHousesRange.pop() # elimina casa infectada de la derecha
        else:
            infectedHousesRange.pop(0) # elimina casa infectada de la izquierda

    # retronamos el intervalo resultante (cualquiera)
    if (len(infectedHousesRange) == 1):
        print(f"{infectedHousesRange[0]}")
    else:
        print(f"{infectedHousesRange[0]} {infectedHousesRange[-1]}")