#include <stdio.h>
#include <pthread.h>
#include <stdlib.h>


/*Funcion que determina si un  numero es par*/

void *es_par(void *n){
    long num = *((long*)n);
    if(num%2==0){
        return (void*)1;
    }
    return (void*)0;
}

/*  Programa principal  */

int main(int argc, char *argv[]){
    int *s;
    if(argc>=1){
        pthread_t thread;
        long n = atoi(argv[1]);
        pthread_create(&thread,NULL,es_par,&n);
        pthread_join(thread,(void*)s);
    }
    printf("Resultado = %d \n",*((int*)s));
    return 1;
}
