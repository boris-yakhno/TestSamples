namespace NUnitFlakyTests;

public class Tests
{
    // 50% success rate
    private static readonly Random Random = new();
    private static bool IsFlakyTestPassed() => Random.NextDouble() > 0.5;

    [Test] public void FlakyTest1() => Assert.True(IsFlakyTestPassed());
    [Test] public void FlakyTest2() => Assert.True(IsFlakyTestPassed());
    [Test] public void FlakyTest3() => Assert.True(IsFlakyTestPassed());
    [Test] public void FlakyTest4() => Assert.True(IsFlakyTestPassed());
    [Test] public void FlakyTest5() => Assert.True(IsFlakyTestPassed());
    [Test] public void FlakyTest6() => Assert.True(IsFlakyTestPassed());
    [Test] public void FlakyTest7() => Assert.True(IsFlakyTestPassed());
    [Test] public void FlakyTest8() => Assert.True(IsFlakyTestPassed());
    [Test] public void FlakyTest9() => Assert.True(IsFlakyTestPassed());
    [Test] public void FlakyTest10() => Assert.True(IsFlakyTestPassed());
}