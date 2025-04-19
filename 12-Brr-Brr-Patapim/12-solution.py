# Enunciado:    Brr Brr Patapim
# Problema:     
# Fecha:        13/04/2025    
# Autor:        Mirco Sair Salcedo Ataulluco


numCases = int(input())

results = []

for o in range(numCases):
    n = int(input())
    matriz = []
    for i in range(n):
        fila = input().split()
        filaInts = [int(k) for k in fila if int(k)]  
        matriz.append(filaInts)

    tiramPermutation = []
    posiblePermutation = [i for i in range(1,2*n+1)]
    
    for i in range(n):
        tiramPermutation.append(matriz[i][0])
        posiblePermutation.pop(posiblePermutation.index(matriz[i][0]))

    for i in range(1, n):
        tiramPermutation.append(matriz[i][n-1])
        posiblePermutation.pop(posiblePermutation.index(matriz[i][n-1]))

    tiramPermutation.insert(0, posiblePermutation[0])
    results.append(tiramPermutation)

for result in results:
    strResult = [str(num) for num in result]
    sentence = " ".join(strResult)
    print(sentence)

