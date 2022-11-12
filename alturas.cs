#include<stdio.h>
#include<conio.h>

int main()
{
    int f,may,men;
    float alturas[5];
    float suma,promedio;

    for (f=0; f<5; f++)
    {
        printf("Ingrese la altura de la persona:");
        scanf("%f",&alturas[f]);
    }
    suma=0;
    for(f=0; f<5; f++)
    {
        suma=suma+alturas[f];
    }
    promedio=suma/5;
    printf("Promedio de alturas:");
    printf("%0.2f",promedio);
    printf("\n");

    may=0;
    men=0;
    for(f=0; f<5; f++)
    {
        if (alturas[f] > promedio)
        {
            may++;
        }
        else
        {
            if (alturas[f] < promedio)
            {
                men++;
            }
        }
    }
    printf("Cantidad de personas mayores al promedio:");
    printf("%i",may);
    printf("\n");
    printf("Cantidad de personas menores al promedio:");
    printf("%i",men);
    getch();
    return 0;
}