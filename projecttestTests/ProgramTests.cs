using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

public class ProgramTests
{
    [Test]
    public void HitungLuasSegitiga_CorrectInput_ReturnsCorrectLuas()
    {
        // Arrange
        double alas = 5;
        double tinggi = 8;

        // Act
        double result = Program.HitungLuasSegitiga(alas, tinggi);

        // Assert
        Assert.AreEqual(20, result);
    }

    [Test]
    public void HitungLuasSegitiga_NegativeInput_ThrowsException()
    {
        // Arrange
        double alas = -5;
        double tinggi = 8;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Program.HitungLuasSegitiga(alas, tinggi));
    }
}
