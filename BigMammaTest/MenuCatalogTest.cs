using System.Threading.Tasks;
using BigMammaUML3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigMammaTest
{
    [TestClass]
    public class MenuCatalogTest
    {
        [TestMethod]
        public void AddMenuItemTest()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            int expectedNumber = catalog.Count + 1;
            IMenuItem t1 = new Topping(1, "Topping", "sdxfcgvhbj", 1, MenuType.Topping, true, true);

            //Act
            catalog.Add(t1);
            int result = catalog.Count;
            //Assert
            Assert.AreEqual(expectedNumber, result);
        }

        [TestMethod]
        [ExpectedException(typeof(MenuItemNumberExist))]
        public void AddMenuItemWithAlreadyExistingKeyTest()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            IMenuItem t1 = new Topping(1, "Topping", "sdxfcgvhbj", 1, MenuType.Topping, true, true);
            IMenuItem t2 = new Topping(1, "Topping", "sdxfcgvhbj", 1, MenuType.Topping, true, true);

            //Act
            catalog.Add(t1);
            catalog.Add(t2);

            //Assert
        }

        [TestMethod]
        public void SearchItemTest()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            IMenuItem t1 = new Topping(1, "Topping", "sdxfcgvhbj", 1, MenuType.Topping, true, true);
            IMenuItem t2 = new Topping(2, "more Topping", "a", 3, MenuType.Topping, false, false);

            //Act
            catalog.Add(t1);
            catalog.Add(t2);
            IMenuItem result = catalog.Search(1);
            //Assert
            Assert.AreEqual(t1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(MenuItemNumberDoesNotExist))]
        public void SearchMenuItemThatDoesNotExistTest()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();

            //Act
            catalog.Search(2);

            //Assert
        }

        [TestMethod]
        public void DeleteMenuItemTest()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            IMenuItem t1 = new Topping(1, "Topping", "sdxfcgvhbj", 1, MenuType.Topping, true, true);
            IMenuItem t2 = new Topping(2, "more Topping", "a", 3, MenuType.Topping, false, false);
            catalog.Add(t1);
            catalog.Add(t2);
            int expectedResult = catalog.Count - 1;

            //Act
            catalog.Delete(2);
            int result = catalog.Count;

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(MenuItemNumberDoesNotExist))]
        public void DeleteMenuItemThatDoesNotExistTest()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();

            //Act
            catalog.Delete(2);

            //Assert
        }

        [TestMethod]
        public void UpdateMenuItemTest()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            IMenuItem t1 = new Topping(1, "Topping", "sdxfcgvhbj", 1, MenuType.Topping, true, true);
            IMenuItem t1New = new Topping(1, "more Topping", "a", 3, MenuType.Topping, false, false);
            catalog.Add(t1);

            //Act
            catalog.Update(1, t1New);

            //Assert
            Assert.AreEqual(t1New, catalog.Search(1));
        }

        [TestMethod]
        [ExpectedException(typeof(MenuItemNumberDoesNotExist))]
        public void UpdateMenuItemThatDoesNotExist()
        {
            //Arrange
            IMenuCatalog catalog = new MenuCatalog();
            IMenuItem t1 = new Topping(1, "t", "d", 1, MenuType.Topping, false, false );

            //Act
            catalog.Update(1, t1);

            //Assert
        }
    }
}
