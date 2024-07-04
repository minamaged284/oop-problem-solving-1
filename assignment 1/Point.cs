namespace assignment_1
{
    public struct Point
    {
        private double X;
        private double Y;
        public Point()
        {

        }

        public double x
        {

            get; set;
        }

        public double y
        {
            get; set;
        }


        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
