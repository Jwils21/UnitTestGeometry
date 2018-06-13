using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestGeometry {
	public class Rectangle {
		public decimal Side1 { get; set; }
		public decimal Side2 { get; set; }
		public decimal Side3 { get; set; }
		public decimal Side4 { get; set; }


		public Rectangle(decimal side1, decimal side2, decimal side3, decimal side4) {
			Side1 = side1;
			Side2 = side2;
			Side3 = side3;
			Side4 = side4;
		}

		public decimal Area(Rectangle rectangle) {
			List<decimal> RectSides = new List<decimal>();
			RectSides.Add(rectangle.Side1);
			RectSides.Add(rectangle.Side2);
			RectSides.Add(rectangle.Side3);
			RectSides.Add(rectangle.Side4);

			decimal FirstSide;
			decimal SecondSide = 0;
			FirstSide = rectangle.Side1;

			for(int i = 1;i < 3;i++) {
				if((RectSides[i]) != FirstSide) {
					SecondSide = RectSides[i];
					break;
				}
			}
			return (FirstSide * SecondSide);
		}

		public decimal Perimiter(Rectangle rectangle) {
			List<decimal> RectSides = new List<decimal>();
			RectSides.Add(rectangle.Side1);
			RectSides.Add(rectangle.Side2);
			RectSides.Add(rectangle.Side3);
			RectSides.Add(rectangle.Side4);

			decimal Perimeter=0;

			foreach(decimal side in RectSides) {
				Perimeter += side;
			}
			return Perimeter;
		}


		public Rectangle() {

		}
	}
}
