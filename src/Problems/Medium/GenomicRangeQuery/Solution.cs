using System;
using System.Collections.Generic;
using Xunit;

public class GenomicRangeQuery {
  private enum GNOME {
    A = 'A',
    C,
    G,
    T,
  }

  public int[] Solution_0(String S, int[] P, int[] Q) {
    var result = new int[P.Length];
    var prevResults = new Dictionary<string, int>();
    var impactFactor = new Dictionary<char, int>() {
      {'A', 1},
      {'C', 2},
      {'G', 3},
      {'T', 4},
    };

    for (int i = 0; i < P.Length; i++) {
      var minimalImpact = int.MaxValue;
      var key = String.Concat(P[i], Q[i]);

      if (!prevResults.ContainsKey(key)) {
        for (int j = P[i]; j <= Q[i]; j++) {
          if (impactFactor[S[j]] < minimalImpact) {
            minimalImpact = impactFactor[S[j]];
          }
        }

        result[i] = minimalImpact;
        prevResults[key] = minimalImpact;
      } else {
        result[i] = prevResults[key];
      }
    }

    return result;
  }

  public int[] Solution_1(String S, int[] P, int[] Q) {
    var result = new int[P.Length];
    var genomsPrefixSums = new Dictionary<GNOME, int[]>();
    var impactFactor = new Dictionary<GNOME, int>() {
      {GNOME.A, 1},
      {GNOME.C, 2},
      {GNOME.G, 3},
      {GNOME.T, 4},
    };

    genomsPrefixSums[GNOME.A] = new int[S.Length + 1];
    genomsPrefixSums[GNOME.C] = new int[S.Length + 1];
    genomsPrefixSums[GNOME.G] = new int[S.Length + 1];
    genomsPrefixSums[GNOME.T] = new int[S.Length + 1];

    for (var i = 0; i < S.Length; i++) {
      int a = 0, c = 0, g = 0, t = 0;

      switch (S[i]) {
        case 'A':
          a = 1;
          break;
        case 'C':
          c = 1;
          break;
        case 'G':
          g = 1;
          break;
        case 'T':
          t = 1;
          break;
      }

      genomsPrefixSums[GNOME.A][i + 1] = genomsPrefixSums[GNOME.A][i] + a;
      genomsPrefixSums[GNOME.C][i + 1] = genomsPrefixSums[GNOME.C][i] + c;
      genomsPrefixSums[GNOME.G][i + 1] = genomsPrefixSums[GNOME.G][i] + g;
      genomsPrefixSums[GNOME.T][i + 1] = genomsPrefixSums[GNOME.T][i] + t;
    }

    for (var i = 0; i < P.Length; i++) {
      var leftPos = P[i];
      var rightPos = Q[i] + 1;

      if (genomsPrefixSums[GNOME.A][rightPos] - genomsPrefixSums[GNOME.A][leftPos] > 0) {
        result[i] = impactFactor[GNOME.A];
      } else if (genomsPrefixSums[GNOME.C][rightPos] - genomsPrefixSums[GNOME.C][leftPos] > 0) {
        result[i] = impactFactor[GNOME.C];
      } else if (genomsPrefixSums[GNOME.G][rightPos] - genomsPrefixSums[GNOME.G][leftPos] > 0) {
        result[i] = impactFactor[GNOME.G];
      } else if (genomsPrefixSums[GNOME.T][rightPos] - genomsPrefixSums[GNOME.T][leftPos] > 0) {
        result[i] = impactFactor[GNOME.T];
      }
    }

    return result;
  }

  [Theory]
  [InlineData("CAGCCTA", new[] { 2, 5, 0 }, new[] { 4, 5, 6 }, new[] { 2, 4, 1 })]
  public void Test(String value1, int[] value2, int[] value3, int[] expected) {
    Assert.Equal(expected, Solution_0(value1, value2, value3));
    Assert.Equal(expected, Solution_1(value1, value2, value3));
  }
}
