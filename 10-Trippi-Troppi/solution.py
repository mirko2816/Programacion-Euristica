# Enunciado:    Trippi Troppi
# Problema:     
# Fecha:        13/04/2025    
# Autor:        Mirco Sair Salcedo Ataulluco

n = int(input())
ancientNames = []

for i in range(n):
    ancientNames.append(input())

for ancientName in ancientNames:
    ancientNameWords = ancientName.split()
    modernName = ""
    for word in ancientNameWords:
        modernName = modernName + word[0]
    print(modernName)
