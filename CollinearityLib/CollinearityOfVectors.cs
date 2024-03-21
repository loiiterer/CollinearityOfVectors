namespace CollinearityLib
{
    public static class CollinearityOfVectors
    {
        public static bool CollinearityInTwoDimensions(int x1, int y1, int x2, int y2)
        {
            // A vector with coordinates (0, 0) is collinear to all vectors.
            if ((x1 == 0 && y1 == 0) || (x2 == 0 && y2 == 0))
            {
                return true;
            }

            // Two vectors are collinear if there is a number k such that b = k * a.
            // In other words: (x2, y2) = (k * x1, k * y1).
            // Find the non-zero element of the first vector and then calculate k.
            double k = (x1 != 0)
                       ? Convert.ToDouble(x2) / Convert.ToDouble(x1)
                       : Convert.ToDouble(y2) / Convert.ToDouble(y1);

            // Checking the expression (x2, y2) = (k * x1, k * y1)
            return ((k * x1 == x2) && (k * y1 == y2));
        }

        public static bool CollinearityInTwoDimensions(Vector2D vect1, Vector2D vect2) 
        {
            if ((vect1.X == 0 && vect1.Y == 0) || (vect2.X == 0 && vect2.Y == 0))
            {
                return true;
            }

            double k = (vect1.X != 0) 
                       ? Convert.ToDouble(vect2.X) / Convert.ToDouble(vect1.X)
                       : Convert.ToDouble(vect2.Y) / Convert.ToDouble(vect1.Y);

            return ((k * vect1.X == vect2.X) && (k * vect1.Y == vect2.Y));
        }
    }
}
