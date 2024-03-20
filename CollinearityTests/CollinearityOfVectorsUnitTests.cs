using CollinearityLib;

namespace CollinearityTests;

public class CollinearityOfVectorsUnitTests
{
    [Fact]
    public void VectorsContainsZeros_4_0_11_0()
    {
        int x1 = 4;  int y1 = 0;
        int x2 = 11; int y2 = 0;
        bool excepted = true;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);      
    }

    [Fact]
    public void VectorsContainsZeros_0_1_6_0()
    {
        int x1 = 0; int y1 = 1;
        int x2 = 6; int y2 = 0;
        bool excepted = false;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsContainsZeros_4_4_0_4()
    {
        int x1 = 4; int y1 = 4;
        int x2 = 0; int y2 = 4;
        bool excepted = false;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsContainsZeros_0_0_0_0()
    {
        int x1 = 0; int y1 = 0;
        int x2 = 0; int y2 = 0;
        bool excepted = true;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsContainsZeros_0_0_1_0()
    {
        int x1 = 0; int y1 = 0;
        int x2 = 1; int y2 = 0;
        bool excepted = true;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsContainsZeros_5_7_0_0()
    {
        int x1 = 5; int y1 = 7;
        int x2 = 0; int y2 = 0;
        bool excepted = true;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsDirectedDifferentDirections_1_1_6_1()
    {
        int x1 = 1; int y1 = 1;
        int x2 = 6; int y2 = 1;
        bool excepted = false;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsDirectedDifferentDirections_1_2_1_minus2()
    {
        int x1 = 1; int y1 = 2;
        int x2 = 1; int y2 = -2;
        bool excepted = false;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsDirectedOppositeDirections_1_1_minus1_minus1()
    {
        int x1 = 1; int y1 = 1;
        int x2 = -1; int y2 = -1;
        bool excepted = true;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsDirectedOppositeDirections_1_minus2_minus2_4()
    {
        int x1 = 1; int y1 = -2;
        int x2 = -2; int y2 = 4;
        bool excepted = true;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsDirectedSameDirections_1_1_1_1()
    {
        int x1 = 1; int y1 = 1;
        int x2 = 1; int y2 = 1;
        bool excepted = true;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }

    [Fact]
    public void VectorsDirectedSameDirections_1_2_2_4()
    {
        int x1 = 1; int y1 = 2;
        int x2 = 2; int y2 = 4;
        bool excepted = true;

        bool actual = CollinearityOfVectors.CollinearityInTwoDimensions(x1, y1, x2, y2);

        Assert.Equal(actual, excepted);
    }
}