using Xunit;

namespace DataStructures.Tests
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void NuevaLista_DebeEstarVacia()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Assert
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void AddFirst_IncrementaContador()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Act
            list.AddFirst(10);

            // Assert
            Assert.Equal(1, list.Count);
        }

        [Fact]
        public void AddFirst_ElementoEsAgregado()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Act
            list.AddFirst(10);

            // Assert
            Assert.True(list.Contains(10));
        }

        [Fact]
        public void AddFirst_MultipleElementos_SeAgreganEnOrdenCorrecto()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Act
            list.AddFirst(30);
            list.AddFirst(20);
            list.AddFirst(10);

            // Assert
            Assert.Equal(10, list.GetAt(0));
            Assert.Equal(20, list.GetAt(1));
            Assert.Equal(30, list.GetAt(2));
        }

        [Fact]
        public void AddLast_IncrementaContador()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Act
            list.AddLast(10);

            // Assert
            Assert.Equal(1, list.Count);
        }

        [Fact]
        public void AddLast_ElementoEsAgregado()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Act
            list.AddLast(10);

            // Assert
            Assert.True(list.Contains(10));
        }

        [Fact]
        public void AddLast_MultipleElementos_SeAgreganEnOrdenCorrecto()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Act
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Assert
            Assert.Equal(10, list.GetAt(0));
            Assert.Equal(20, list.GetAt(1));
            Assert.Equal(30, list.GetAt(2));
        }

        [Fact]
        public void Remove_ListaVacia_RetornaFalse()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Act
            bool result = list.Remove(10);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Remove_ElementoNoExiste_RetornaFalse()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);

            // Act
            bool result = list.Remove(20);

            // Assert
            Assert.False(result);
            Assert.Equal(1, list.Count);
        }

        [Fact]
        public void Remove_ElementoExisteEnCabeza_RetornaTrue()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            bool result = list.Remove(10);

            // Assert
            Assert.True(result);
            Assert.False(list.Contains(10));
            Assert.Equal(1, list.Count);
            Assert.Equal(20, list.GetAt(0));
        }

        [Fact]
        public void Remove_ElementoExisteEnMedio_RetornaTrue()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Act
            bool result = list.Remove(20);

            // Assert
            Assert.True(result);
            Assert.False(list.Contains(20));
            Assert.Equal(2, list.Count);
            Assert.Equal(10, list.GetAt(0));
            Assert.Equal(30, list.GetAt(1));
        }

        [Fact]
        public void Remove_ElementoExisteAlFinal_RetornaTrue()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            bool result = list.Remove(20);

            // Assert
            Assert.True(result);
            Assert.False(list.Contains(20));
            Assert.Equal(1, list.Count);
            Assert.Equal(10, list.GetAt(0));
        }

        [Fact]
        public void Contains_ListaVacia_RetornaFalse()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Act
            bool result = list.Contains(10);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Contains_ElementoNoExiste_RetornaFalse()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);

            // Act
            bool result = list.Contains(20);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Contains_ElementoExiste_RetornaTrue()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);

            // Act
            bool result = list.Contains(10);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Clear_ListaVacia_NoError()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();

            // Act
            list.Clear();

            // Assert
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void Clear_ListaConElementos_SeVacia()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);

            // Act
            list.Clear();

            // Assert
            Assert.Equal(0, list.Count);
            Assert.False(list.Contains(10));
            Assert.False(list.Contains(20));
        }

        [Fact]
        public void GetAt_IndiceNegativo_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => list.GetAt(-1));
        }

        [Fact]
        public void GetAt_IndiceExcedeTamaño_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => list.GetAt(1));
        }

        [Fact]
        public void GetAt_IndiceValido_RetornaElemento()
        {
            // Arrange
            var list = new SinglyLinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);

            // Act
            var result = list.GetAt(1);

            // Assert
            Assert.Equal(20, result);
        }
    }
}