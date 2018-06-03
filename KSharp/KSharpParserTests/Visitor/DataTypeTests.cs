﻿using Antlr4.Runtime;

using NUnit.Framework;

using System;

namespace KSharpParserTests.Visitor
{
    class DataTypeTests
    {
        [TestFixture]
        public class BasicStructuresTests : KSharpTestBase
        {
            [TestCase("true", true)]
            [TestCase("false", false)]

            [TestCase("1", 1)]
            [TestCase("98746311", 98746311)]

            [TestCase("-1", -1)]
            [TestCase("-98746311", -98746311)]

            [TestCase("3.465e-5", 3.465e-5)]
            [TestCase("3.465e+5", 3.465e+5)]
            [TestCase("3.465", 3.456)]

            [TestCase("30%", 0.30)]
            [TestCase("30.4%", 0.304)]

            [TestCase("\"String\"", "String")]
            public void BasicStructures_IsSuccessful_HasResult(string input, object expected)
            {
                var tree = GetParser(input).begin_expression();
                Assert.AreEqual(expected, Visitor.GetFirstResult(tree));
            }


            [TestCase(";")]
            [TestCase(";;;")]
            [TestCase("2identifier")]  // invalid identifier, it is ignored when found
            public void BasicStructures_IsSuccessful_NoResult(string input)
            {
                var tree = GetParser(input).begin_expression();
                Assert.IsNull(Visitor.GetResultList(tree));
            }
        }


        [TestFixture]
        public class StringTests : KSharpTestBase
        {
            [TestCase("\"String\" + \"AnotherString\"", "StringAnotherString")]
            [TestCase("Variable = \"String\" + \"AnotherString\"; Variable", "StringAnotherString")]

            [TestCase("\"\" + \"ahoj\"", "ahoj")]
            [TestCase("\"\" + 23.05", "23.05")]
            [TestCase("\"\" + False", "False")]

            [TestCase("@\"This string displays as is. No newlines\n, tabs\t or backslash-escapes\\.\"", "@\"This string displays as is. No newlines\n, tabs\t or backslash-escapes\\.")]
            public void String_IsSuccessful_HasResult(string input, string expected)
            {
                var tree = GetParser(input).begin_expression();
                Assert.AreEqual(expected, Visitor.GetFirstResult(tree));
            }


            [TestCase("")]
            [TestCase(" ")]
            public void String_IsSuccessful_HasResult(string input)
            {
                var tree = GetParser(input).begin_expression();
                Assert.IsNull(Visitor.GetResultList(tree));
            }


            [TestCase("\"String\" \"AnotherString\"")]
            [TestCase("\"\"")]
            [TestCase("\"\\\"\"")]
            [TestCase("@\"\"")]
            public void String_NotSuccessful_ThrowsInputMismatch(string input)
            {
                Assert.Throws<InputMismatchException>(() => Visitor.GetFirstResult(GetParser(input).begin_expression()));
            }


            [TestCase("\"String\" - \"AnotherString\"")]
            public void String_NotSuccessful_ThrowsInvalidOperation(string input)
            {
                Assert.Throws<InvalidOperationException>(() => Visitor.GetFirstResult(GetParser(input).begin_expression()));
            }
        }


        [TestFixture]
        public class GuidTests : KSharpTestBase
        {
            [TestCase("0362d604-e293-496e-a73f-abdf522ce31d")]

            public void Guid_IsSuccessful_HasResult(string input)
            {
                var tree = GetParser(input).begin_expression();

                Assert.AreEqual(new Guid("0362d604-e293-496e-a73f-abdf522ce31d"), Visitor.GetFirstResult(tree));
            }
        }


        [TestFixture]
        public class DateTimeTests : KSharpTestBase
        {
            [TestCase("12.12.2012")]
            [TestCase("12/12/2012")]
            public void DateTime_IsSuccessful_HasResult(string input)
            {
                var tree = GetParser(input).begin_expression();

                Assert.AreEqual(new DateTime(2012, 12, 12), Visitor.GetFirstResult(tree));
            }
        }
    }
}
