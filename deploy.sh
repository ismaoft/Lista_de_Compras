#!/bin/bash

# Script de despliegue para ListaDeCompras
echo "Iniciando despliegue de ListaDeCompras..."

# Detener y eliminar contenedores existentes
echo "Deteniendo contenedores existentes..."
docker-compose -f docker-compose.prod.yml down

# Construir y levantar los contenedores
echo "Construyendo y iniciando contenedores..."
docker-compose -f docker-compose.prod.yml up -d --build

# Verificar que los contenedores estén funcionando
echo "Verificando estado de los contenedores..."
docker ps

# Esperar a que SQL Server esté listo
echo "Esperando a que SQL Server esté disponible..."
sleep 30

# Ejecutar migraciones de base de datos (si las tienes)
# echo "Ejecutando migraciones de base de datos..."
# docker exec webapp dotnet ef database update

echo "Despliegue completado. La aplicación está disponible en http://192.168.100.46"