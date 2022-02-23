using Microsoft.VisualStudio.TestTools.UnitTesting; 
using ToDoList; 

namespace ToDoList.Tests {
  [TestClass] 
  public class ItemTests {
    [TestMethod] 
    public void ItemConstructor_CreateInstanceOfItem_Item() {  
      Item newItem = new Item();  
      Assert.AreEqual(typeof(Item), newItem.GetType()); 
    }
  }
}