#include <stdio.h>

int main() {
    int numeros[10];

    // Llenar el arreglo con los números del 1 al 10
    for (int i = 0; i < 10; i++) {
        numeros[i] = i + 1;
    }

    // Mostrar los números en orden inverso, separados por comas
    printf("Números en orden inverso:\n");
    for (int i = 9; i >= 0; i--) {
        if (i != 0)
            printf("%d, ", numeros[i]);
        else
            printf("%d\n", numeros[i]); // Último número sin coma al final
    }

    return 0;
}

