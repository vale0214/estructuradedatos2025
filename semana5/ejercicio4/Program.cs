#include <stdio.h>
#include <stdlib.h>

#define TOTAL_NUMEROS 6

// Función para ordenar un arreglo usando el método burbuja
void ordenar(int arr[], int n) {
    for (int i = 0; i < n-1; i++) {
        for (int j = 0; j < n-i-1; j++) {
            if (arr[j] > arr[j+1]) {
                // Intercambio de elementos
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
        }
    }
}

int main() {
    int numeros[TOTAL_NUMEROS];

    // Solicitar al usuario los números ganadores
    printf("Ingrese los %d números ganadores de la lotería primitiva:\n", TOTAL_NUMEROS);
    for (int i = 0; i < TOTAL_NUMEROS; i++) {
        printf("Número %d: ", i + 1);
        scanf("%d", &numeros[i]);
    }

    // Ordenar los números
    ordenar(numeros, TOTAL_NUMEROS);

    // Mostrar los números ordenados
    printf("\nNúmeros ganadores ordenados de menor a mayor:\n");
    for (int i = 0; i < TOTAL_NUMEROS; i++) {
        printf("%d ", numeros[i]);
    }
    printf("\n");

    return 0;
}

