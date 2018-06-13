using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestGeometry;

namespace UnitTestGeometryLibrary {
	[TestClass]
	public class UnitTestRectangle {
		[TestMethod]
		public void TestRectangle() {
			Rectangle Rect1 = new Rectangle(3, 3, 4, 4);
			decimal area = Rect1.Area(Rect1);
			Assert.AreEqual(12, area, "The are should be 12");
		}


		[TestMethod]
		public void TestForValidConstructor() {
			Rectangle Rect1 = new Rectangle(-3, 3, 4, 4);
			Assert.IsNotInstanceOfType(Rect1, typeof(Rectangle));
		}
	}
}
