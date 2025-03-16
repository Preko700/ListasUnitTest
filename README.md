# Proyecto de Estructuras de Datos en C#

## Descripción
Este proyecto implementa diferentes estructuras de datos en C# con enfoque en listas enlazadas. Incluye implementaciones de listas enlazadas simples y doblemente enlazadas con sus respectivas pruebas unitarias para garantizar su funcionamiento correcto.

## Estructura del Proyecto
La solución está organizada en tres proyectos:

- **DataStructures**: Biblioteca de clases que contiene las implementaciones de estructuras de datos.
  - `SinglyLinkedList<T>`: Implementación de lista enlazada simple.
  - `DoublyLinkedList<T>`: Implementación de lista doblemente enlazada con punteros a nodo anterior y siguiente.

- **DataStructures.Tests**: Proyecto de pruebas unitarias usando xUnit.
  - Contiene pruebas exhaustivas para verificar el funcionamiento de cada operación.
  - Alcanza una cobertura de código ≥ 90% para garantizar la calidad.

- **ListasUnitTest**: Proyecto de consola para demostraciones y ejemplos de uso.

## Funcionalidades Implementadas

### Lista Enlazada Simple (SinglyLinkedList)
- `AddFirst`: Agrega un elemento al inicio de la lista.
- `AddLast`: Agrega un elemento al final de la lista.
- `Remove`: Elimina la primera ocurrencia de un elemento específico.
- `Contains`: Verifica si un elemento existe en la lista.
- `Clear`: Vacía la lista completamente.
- `GetAt`: Obtiene el elemento en una posición específica.
- `Count`: Propiedad que devuelve el número de elementos en la lista.

### Lista Doblemente Enlazada (DoublyLinkedList)
Incluye todas las funcionalidades de la lista simple, pero con acceso bidireccional para mayor eficiencia:
- `AddFirst`: Agrega un elemento al inicio con complejidad O(1).
- `AddLast`: Agrega un elemento al final con complejidad O(1).
- `Remove`: Elimina un elemento con reconexión bidireccional.
- `GetAt`: Acceso optimizado que recorre desde el inicio o final según la posición.

## Pruebas Unitarias
El proyecto incluye pruebas exhaustivas para verificar:
- Creación de listas vacías
- Adición de elementos (primer y último)
- Eliminación de elementos en diferentes posiciones
- Búsqueda de elementos
- Manipulación de elementos por índice
- Comportamiento con valores nulos o índices fuera de rango
- Eficiencia en recorridos bidireccionales

## Requisitos
- .NET 8.0
- Compatibilidad con Visual Studio 2022 o superior

## Cómo Usar

### Instalación
1. Clona el repositorio
2. Abre la solución en Visual Studio
3. Compila la solución

### Ejemplo de Uso

```csharp
// Crear una lista doblemente enlazada
var lista = new DoublyLinkedList<int>();

// Agregar elementos
lista.AddLast(10);
lista.AddLast(20);
lista.AddFirst(5);

// Acceder a elementos
int valor = lista.GetAt(1); // Obtiene 10

// Eliminar elementos
bool eliminado = lista.Remove(20); // Elimina 20 y devuelve true

// Verificar contenido
bool contiene = lista.Contains(5); // Devuelve true
```

## Ejecutar Pruebas
Para ejecutar las pruebas y verificar la cobertura:

1. En Visual Studio: Test > Run All Tests
2. Para ver la cobertura: Test > Analyze Code Coverage for All Tests

## Licencia
Este proyecto bajo la licencia Apache-2.0
