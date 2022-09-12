using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class ModuloFirstTest
    {
        [Test]
        public void ModuloFirstSimple()
        {
            int[] input = { 3, 6, 9, 10, 11, 12 };
            int[] output = ModuloFirst.modulo(input);
            int[] expected = { 0, 0, 0, 1, 2, 0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
