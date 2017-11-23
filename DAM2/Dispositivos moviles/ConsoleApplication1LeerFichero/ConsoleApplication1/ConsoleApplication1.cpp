// ConsoleApplication1.cpp: define el punto de entrada de la aplicación de consola.
//

#include "stdafx.h"
#include "string.h"

typedef struct TAlumno
{
	char nombre[40];
	char apellido[40];
	int  edad;
};

void escribirFichero(struct TAlumno tabla[6],
	char nFichero[40])
{
	FILE *pf;

	fopen_s(&pf,nFichero, "wt");
	for (int i = 0;i < 6;i++)
	{
		fprintf(pf, "%s\n%s\n%d\n",
			tabla[i].nombre,
			tabla[i].apellido,
			tabla[i].edad);
	}
	fclose(pf);
}

void leerFichero(struct TAlumno tabla[6],
	char nFichero[40])
{
	FILE *pf;

	fopen_s(&pf, nFichero, "rt");
	for (int i = 0;i < 6;i++)
	{
		fgets(tabla[i].nombre, 40, pf);
		fgets(tabla[i].apellido, 40, pf);
		fscanf_s(pf,"%d\n",&(tabla[i].edad));
	}
	fclose(pf);
}

int main()
{
	struct TAlumno MiTabla[6];

	for (int i = 0;i < 6;i++)
	{
		MiTabla[i].nombre[0] = '\0';
		MiTabla[i].apellido[0] = '\0';
		MiTabla[i].edad = 0;
	}
	
	/*
	strcpy_s(MiTabla[0].nombre, "Pepito");
    strcpy_s(MiTabla[0].apellido, "Martin");
	MiTabla[0].edad = 23;

	strcpy_s(MiTabla[1].nombre, "Ana");
	strcpy_s(MiTabla[1].apellido, "Lopez");
	MiTabla[1].edad = 21;

	strcpy_s(MiTabla[2].nombre, "Juanito");
	strcpy_s(MiTabla[2].apellido, "Gomez");
	MiTabla[2].edad = 20;
	*/

	// Llamada a escribir fichero
	// escribirFichero(MiTabla, "D:\\clase.txt");

	// Llamada a leer fichero
	leerFichero(MiTabla, "D:\\clase.txt");

	return 0;
}

