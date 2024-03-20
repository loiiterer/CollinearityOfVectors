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

            double k;

            // Find the non-zero element of the first vector and then calculate k.
            if (x1 != 0)
            {
                k = Convert.ToDouble(x2) / Convert.ToDouble(x1);
            }
            else
            {
                k = Convert.ToDouble(y2) / Convert.ToDouble(y1);
            }

            // Checking the expression (x2, y2) = (k * x1, k * y1)
            if ((k * x1 == x2) && (k * y1 == y2))
            {
                // Since (x2, y2) equals to (k * x1, k * y1)
                return true;
            }

            return false;
        }
    }
}
