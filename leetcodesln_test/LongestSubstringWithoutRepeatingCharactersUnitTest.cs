﻿using leetcodesln;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcodesln_test
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class LongestSubstringWithoutRepeatingCharactersUnitTest
    {
        [TestMethod]
        public void LongestSubstringWithoutRepeatingCharactersTestMethod()
        {
            LongestSubstringWithoutRepeatingCharacters longestSubstringWithoutRepeatingCharacters = new LongestSubstringWithoutRepeatingCharacters();
            //Assert.AreEqual(3, longestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("abcabcbb"));
            //Assert.AreEqual(1, longestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("bbbb"));
            //Assert.AreEqual(3, longestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("pwwkew"));
            //Assert.AreEqual(2, longestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("au"));
            //Assert.AreEqual(1, longestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("a"));
            Assert.AreEqual(7, longestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring("bpfbhmipx"));

        }
    }
}
