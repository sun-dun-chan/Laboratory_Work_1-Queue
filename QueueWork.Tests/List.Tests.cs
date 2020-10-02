using System;
using Xunit;

namespace QueueWork.Tests
{
    public class ListTests
    {
        [Fact]
        public void Create_List_Using_Init_Ctor_Check_Element() 
        {
            // Arrange
            List<int> list;
            int expected = 2;

            // Act
            list = new List<int>(1, 2, 3);
            int actual = list[1];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Create_List_Using_Copy_Ctor_Compare_Lists_Get_True()
        {
            // Arrange
            List<int> firstList = new List<int>();
           

            // Act
            for (int i = 0; i < 5; i++) firstList.PushBack(i * i);
            List<int> secondList = new List<int>(firstList);

            // Assert
            Assert.True(firstList.Equals(secondList));
        }
        [Fact]
        public void List_Count_With_Elements_Get_Count()
        {
            // Arrange
            List<int> list = new List<int>();
            int expected = 3;

            // Act
            for (int i = 0; i < expected; i++) list.PushBack(1);
            int actual = list.Count;

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void List_Count_Without_Elems__Get_Zero()
        {
            // Arrange
            List<int> list = new List<int>();
            int expected = 0;

            // Act
            int actual = list.Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void List_With_Elems_Get_Data()
        {
            // Arrange
            List<int> list = new List<int>();
            int expected = 5;

            // Act
            list.PushBack(expected);
            int actual = list[0];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void List_With_Elems_Set_Data()
        {
            // Arrange
            List<int> list = new List<int>();
            int expected = 3;
            // Act
            list.PushBack(2);
            list[0] = expected;
            int actual = list[0];

            // Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Set_New_Data_Check_New_Data_In_List_Get_True()
        {
            // Arrange
            List<int> list = new List<int>();
            bool expected = true;

            // Act
            for (int i = 0; i < 3; i++) list.PushBack(i);
            list[1] = 5;
            bool actual = list.Contains(5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_Non_Exist_Data_In_List_Get_False()
        {
            // Arrange
            List<int> list = new List<int>();
            bool expected = false;

            // Act
            for (int i = 0; i < 3; i++) list.PushBack(i);
            bool actual = list.Contains(5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void List_Get_Data_With_Invalid_Index_Should_Throw_ArgumentOutOfRangeException()
        {
            // Arrange
            List<int> list = new List<int>();
            int index = -5;
            int a;

            // Act
            list.PushBack(2);

            // Assert
            Assert.Throws<System.IndexOutOfRangeException>(() => a = list[index]);
        }

        [Fact]

        public void List_Set_Data_With_Invalid_Index_Should_Throw_ArgumentOutOfRangeException()
        {
            // Arrange
            List<int> list = new List<int>();
            int index = -5;

            // Act
            list.PushBack(2);

            // Assert
            Assert.Throws<System.IndexOutOfRangeException>(() => list[index] = 3);
        }

        [Fact]

        public void Empty_List_Get_Data_Should_Throw_NullReferenceException() 
        {
            // Arrange
            List<int> list = new List<int>();
            int a;

            // Act and Assert
            Assert.Throws<System.NullReferenceException>(() => a = list[0]);
        }

        [Fact]
        public void Empty_List_Set_Data_Should_Throw_NullReferenceException()
        {
            // Arrange
            List<int> list = new List<int>();
            
            // Act and Assert
            Assert.Throws<System.NullReferenceException>(() => list[0] = 2);
        }

        [Fact]

        public void List_PushBack_Data_In_Empty_List_Get_First_Element()
        {
            // Arrange
            List<int> list = new List<int>();
            int expected = 10;

            // Act
            list.PushBack(expected);
            int actual = list[0];

            // Arrange
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void List_PushUp_Data_In_Empty_List_Get_First_Element()
        {
            // Arrange
            List<int> list = new List<int>();
            int expected = 10;

            // Act
            list.PushUp(expected);
            int actual = list[0];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void List_PushBack_Data_In_Not_Empty_List_Get_Last_Element()
        {
            // Arrange
            List<int> list = new List<int>();
            int expected = 10;

            // Act
            for (int i = 0; i < 3; i++) list.PushBack(i);
            list.PushBack(10);
            int actual = list[list.Count - 1];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void List_PushUp_Data_In_Not_Empty_List_Get_First_Element()
        {
            // Arrange
            List<int> list = new List<int>();
            int expected = 5;

            // Act
            for (int i = 0; i < 3; i++) list.PushBack(i);
            list.PushUp(5);
            int actual = list[0];

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Check_The_Elem_In_List_Get_True()
        {
            // Arrange
            List<int> list = new List<int>();
            bool expected = true;

            // Act
            list.PushBack(3);
            bool actual = list.Contains(3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_The_Elem_In_List_Get_False()
        {
            // Arrange
            List<int> list = new List<int>();
            bool expected = false;

            // Act
            list.PushBack(4);
            bool actual = list.Contains(3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Check_The_Removed_Elem_Get_False()
        {
            // Arrange
            List<int> list = new List<int>();
            bool expected = false;

            // Act
            for (int i = 0; i < 5; i++) list.PushBack(i);
            list.Remove(2);
            bool actual = list.Contains(2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Check_The_Removed_With_Index_Elem_Get_False()
        {
            // Arrange
            List<int> list = new List<int>();
            bool expected = false;

            // Act
            list.PushBack(1);
            list.PushBack(2);
            list.RemoveAt(1);
            bool actual = list.Contains(2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void Clear_Not_Empty_List_Get_Count()
        {
            // Arrange
            List<int> list = new List<int>();
            int expected = 0;

            // Act
            for (int i = 0; i < 5; i++) list.PushBack(i);
            list.Clear();
            int actual = list.Count;

            // Assert
            Assert.Equal(expected, actual);
        }
                
    }
    }
