namespace ShapeCalculator{
    class Rectangle:Shape, Area 
    {
        public double ShapeLength {get; set; }
        public double ShapeWidth {get; set; }

        public Rectangle(string name, int shapeLength, int shapeWidth): base(name) {
            this.ShapeLength = shapeLength;
            this.ShapeWidth = shapeWidth;
        }

        public  double CalculateArea(){
           double area= ShapeLength * ShapeWidth;
           return area;
        }

        public override void Display()
    {
        base.Display();
        Console.WriteLine($"Length: {ShapeLength}, Width: {ShapeWidth}, Area: {CalculateArea():F2}");
    }

    }
}