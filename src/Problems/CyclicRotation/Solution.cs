using Xunit;

public class CyclicRotation {

  public int[] Solution(int[] A, int K) {
    if (K == 0 || A.Length == 0) {
      return A;
    }

    void Rotate(int[] Arr) {
      var lastElement = Arr[Arr.Length - 1];

      for (int i = Arr.Length - 1; i >= 0; i--) {
        if (i == 0) {
          Arr[i] = lastElement;
        } else {
          Arr[i] = Arr[i - 1];
        }
      }
    }

    var numberOfTimesRotate = K % A.Length;

    for (int i = 0; i < numberOfTimesRotate; i++) {
      Rotate(A);
    }

    return A;
  }

  [Theory]
  [InlineData(new[] { 3, 8, 9, 7, 6 }, 3, new[] { 9, 7, 6, 3, 8 })]
  [InlineData(new[] { 0, 0, 0 }, 1, new[] { 0, 0, 0 })]
  [InlineData(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
  public void Test(int[] value1, int value2, int[] expected) {
    Assert.Equal(expected, Solution(value1, value2));
  }
}
