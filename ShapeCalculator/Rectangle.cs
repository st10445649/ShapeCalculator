namespace ShapeCalculator{
    class Rectangle:Shape, Area 
    {
        public int ShapeLength {get; set; }
        public int ShapeWidth {get; set; }

        public Rectangle(string name, int shapeLength, int shapeWidth): base(name) {
            this.ShapeLength = shapeLength;
            this.ShapeWidth = shapeWidth;
        }

        public  int CalculateArea(){
           int area= ShapeLength * ShapeWidth;
           return area;
        }

        public override void Display()
    {
        base.Display();
        Console.WriteLine($"Length: {ShapeLength}, Width: {ShapeWidth}, Area: {CalculateArea()}");
    }

    }
}